/**
 * VoiceControl
 * Copyright (C) 2020  Martin Kaul (martin@familie-kaul.de)
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 **/

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SendVoiceCommands
{
    /// <summary>
    /// Main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        class ProcessItem
        {
            public string title;
            public System.Diagnostics.Process process;

            override public string ToString()
            {
                return title;
            }
        };

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private NAudio.Wave.WaveInEvent waveIn;

        // NAudio fft wants powers of two!
        private static int fftLength = 2048; // 8192; 

        // There might be a sample aggregator in NAudio somewhere but I made a variation for my needs
        private AudioSampleAggregator sampleAggregator = new AudioSampleAggregator(fftLength);

        private AudioSpectrumUtils _spectrumUtils;

        public MainForm()
        {
            InitializeComponent();

            Text = "Send Voice Command";
            _closeButton.Text = "Close";
            _refreshButton.Text = "Refresh";
            _testButton.Text = "Test";
            _spectrumButton.Text = "Spectrum";
            _levelLabel.Text = "Sound Level:";

            refreshProcessList();

            waveIn = new NAudio.Wave.WaveInEvent();
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.StartRecording();

            _spectrumUtils = new AudioSpectrumUtils(waveIn, fftLength);
        }

        private void closeButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshProcessList()
        {
            _processesBox.Items.Clear();
            _testButton.Enabled = false;
            _processesBox.Text = "";

            System.Diagnostics.Process[] processList = System.Diagnostics.Process.GetProcesses();
            Array.Sort(processList, (x, y) => String.Compare(x.ProcessName, y.ProcessName));

            foreach (System.Diagnostics.Process process in processList)
            {
                if (process.MainWindowHandle == null) continue;
                if (process.MainWindowHandle.ToInt32() == 0x00000000) continue;

                ProcessItem item = new ProcessItem();
                item.process = process;
                item.title = process.ProcessName + " [" + process.Id + "]";

                _processesBox.Items.Add(item);
            }
        }

        private void _testButton_Click(object sender, EventArgs e)
        {
        }

        private void _processesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_processesBox.SelectedItem != null)
            {
                _testButton.Enabled = true;
            }
            else
            {
                _testButton.Enabled = false;
            }
        }

        private void _refreshButton_Click(object sender, EventArgs e)
        {
            refreshProcessList();
        }

        private void OnDataAvailable(object sender, NAudio.Wave.WaveInEventArgs args)
        {
            MethodInvoker mi = new MethodInvoker(() => processAudioData(args));
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(mi);
            }
            else
            {
                mi.Invoke();
            }

        }

        private void processAudioData(NAudio.Wave.WaveInEventArgs args)
        {
            byte[] buffer = args.Buffer;
            int bytesRecorded = args.BytesRecorded;
            int bufferIncrement = waveIn.WaveFormat.BlockAlign;

            float max = 0;

            for (int index = 0; index < bytesRecorded; index += bufferIncrement)
            {
                short sample = (short)((args.Buffer[index + 1] << 8) |
                                        args.Buffer[index + 0]);
                float sample32 = sample;

                // calculate maximum value
                max = calculateMaximum(max, sample32);
                // perform FFT analysis
                sampleAggregator.Add(sample32);
            }

            int percentValue = (int)(100 * (max / 32768f));
            if (percentValue < 0) percentValue = -percentValue; // absolute value 
            progressBar1.Value = percentValue;
        }

        private float calculateMaximum(float currentMax, float currentValue)
        {
            if (currentValue > currentMax) currentMax = currentValue;
            return currentMax;
        }

        private void trigger()
        {
            //ProcessItem item = _processesBox.SelectedItem as ProcessItem;
            //if (item == null)
            //{
            //    return;
            //}

            //SetForegroundWindow(item.process.MainWindowHandle);
            //SendKeys.SendWait(" ");
            //SendKeys.Flush();
        }

        public int GetFFTFrequencyIndex(int frequency)
        {
            double maxFrequency;
            if (waveIn != null)
            {
                maxFrequency = waveIn.WaveFormat.SampleRate / 2.0d;
            }
            else
            {
                maxFrequency = 22050; // Assume a default 44.1 kHz sample rate.
            }
            return (int)((frequency / maxFrequency) * (fftLength / 2));
        }

        public int GetFFTIndexFrequency(int index)
        {
            double maxFrequency;
            if (waveIn != null)
            {
                maxFrequency = waveIn.WaveFormat.SampleRate / 2.0d;
            }
            else
            {
                maxFrequency = 22050; // Assume a default 44.1 kHz sample rate.
            }
            return (int)((index * maxFrequency) / (fftLength / 2));
        }

        private void _spectrumButton_Click(object sender, EventArgs e)
        {
            AudioSpectrumAnalyser dialog = new AudioSpectrumAnalyser(waveIn, sampleAggregator, _spectrumUtils);
            dialog.ShowDialog();
        }
    }
}