using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SendVoiceCommands
{
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
            trigger();
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
            if (percentValue >= trackBar1.Value)
            {
                trigger();
            }
        }

        private float calculateMaximum(float currentMax, float currentValue)
        {
            if (currentValue > currentMax) currentMax = currentValue;
            return currentMax;
        }

        private void trigger()
        {
            ProcessItem item = _processesBox.SelectedItem as ProcessItem;
            if (item == null)
            {
                return;
            }

            SetForegroundWindow(item.process.MainWindowHandle);
            SendKeys.SendWait(" ");
            SendKeys.Flush();
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