using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SendVoiceCommands
{
    public partial class AudioSpectrumAnalyser : Form
    {
        private NAudio.Wave.WaveInEvent _waveIn;
        private AudioSpectrumUtils _spectrumUtils;
        private MusicNoteUtils _musicNoteUtils;
        private AudioSampleAggregator _sampleAggregator;
        private Series _spectrumSeries;
        private Series _detectLevelSeries;
        private EventHandler<FftEventArgs> _fftEventHandler;
        private int _minimumFrequencyIndex;
        private int _maximumFrequencyIndex;
        private bool _changeLevelBox = false;
        private int _detectLevel = 0;
        private int _xAxixMinimum = 50;
        private int _xAxisMaximum = 900;

        public AudioSpectrumAnalyser(NAudio.Wave.WaveInEvent waveIn, AudioSampleAggregator sampleAggregator, AudioSpectrumUtils spectrumUtils)
        {
            InitializeComponent();

            // initialize chart
            _spectrumSeries = _spectrumChart.Series["spectrumSeries"];
            _spectrumSeries.LegendText = "Frequency Spectrum";
            _spectrumSeries.Points.Clear();
            _spectrumChart.ChartAreas["ChartArea1"].AxisX.Interval = 50;
            _spectrumChart.ChartAreas["ChartArea1"].AxisX.Minimum = _xAxixMinimum;
            _spectrumChart.ChartAreas["ChartArea1"].AxisX.Maximum = _xAxisMaximum;
            _detectLevelSeries = _spectrumChart.Series["detectLevelSeries"];
            _detectLevelSeries.LegendText = "Detect Level";

            _closeButton.Text = "Close";
            _spectrumChart.Text = "Spectrum";
            _detectedFrequencyLabel.Text = "detected Frequence:";
            _detectedFrequencyBox.Text = "0 HZ";
            _detectLevelLabel.Text = "Detect-Level:";
            _detectLevelBox.Text = "0";
            _detectedNoteLabel.Text = "detected Note:";
            _detectedNoteBox.Text = "-";

            _detectLevelBar.Minimum = 0;
            _detectLevelBar.Maximum = 15000;
            _detectLevelBar.Value = 1000;

            // initialize sampling and FFT analyse of audio data
            _spectrumUtils = spectrumUtils;
            _waveIn = waveIn;
            _waveIn.DataAvailable += OnDataAvailable;
            _sampleAggregator = sampleAggregator;
            _fftEventHandler = new EventHandler<FftEventArgs>(FftCalculated);
            _sampleAggregator.FftCalculated += _fftEventHandler;
            _sampleAggregator.PerformFFT = true;
            _minimumFrequencyIndex = _spectrumUtils.ConvertFrequencyToIndexUsingMinimum(55);   // tone A1 
            _maximumFrequencyIndex = _spectrumUtils.ConvertFrequencyToIndexUsingMinimum(880);  // tone a2

            _musicNoteUtils = new MusicNoteUtils();
        }

        private void OnDataAvailable(object sender, NAudio.Wave.WaveInEventArgs args)
        {
            MethodInvoker mi = new MethodInvoker(() => processAudioData(args));
            if (this.InvokeRequired)
            {
                this.Invoke(mi);
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
            int bufferIncrement = _waveIn.WaveFormat.BlockAlign;

            for (int index = 0; index < bytesRecorded; index += bufferIncrement)
            {
                short sample = (short)((args.Buffer[index + 1] << 8) |
                                        args.Buffer[index + 0]);
                float sample32 = sample;

                // perform FFT analysis
                _sampleAggregator.Add(sample32);
            }
        }
        void FftCalculated(object sender, FftEventArgs e)
        {
            float[] frequencyValues = new float[_maximumFrequencyIndex - _minimumFrequencyIndex + 1];
            _spectrumSeries.Points.Clear();
            // convert the complex value into standard value
            for (int i = _minimumFrequencyIndex; i < _maximumFrequencyIndex; i++) // use half of the values cause of mirroring in the FFT
            {
                NAudio.Dsp.Complex c = e.Result[i];
                float value = (float)Math.Sqrt(c.X * c.X + c.Y * c.Y);
                frequencyValues[i - _minimumFrequencyIndex] = value;
                _spectrumSeries.Points.AddXY(_spectrumUtils.ConvertIndexToFrequency(i), value);
            }
            // detect maximum frequency
            int index = _spectrumUtils.DetectIndexOfMaximumFrequency(frequencyValues, _detectLevel);
            if (index < 0)
            {
                // no frequency above level
                _detectedFrequencyBox.Text = "-";
            }
            else
            {
                float frequency = _spectrumUtils.ConvertIndexToFrequency(index + _minimumFrequencyIndex);
                ProcessDetectedFrequency(frequency);
            }
        }

        private void SpectrumAnalyser_FormClosing(object sender, FormClosingEventArgs e)
        {
            _sampleAggregator.PerformFFT = false;
            _sampleAggregator.FftCalculated -= _fftEventHandler;
            _waveIn.DataAvailable -= OnDataAvailable;
        }

        private void _detectLevelBar_ValueChanged(object sender, EventArgs e)
        {
            if (!_changeLevelBox) // avoid updating text-box by bar when insert value is outside of bar area.
            {
                _detectLevelBox.Text = _detectLevelBar.Value.ToString();
            }
        }

        private void _detectLevelBox_TextChanged(object sender, EventArgs e)
        {
            if(_detectLevelBox.Text.Length == 0)
            {
                return;
            }

            _detectLevel = Int32.Parse(_detectLevelBox.Text);
            if(_detectLevel < 0)
            {
                _detectLevel = 0;
            }
            if(_detectLevel < _detectLevelBar.Minimum)
            {
                _changeLevelBox = true;
                _detectLevelBar.Value = _detectLevelBar.Minimum;
                _changeLevelBox = false;
            }
            else if(_detectLevel > _detectLevelBar.Maximum)
            {
                _changeLevelBox = true;
                _detectLevelBar.Value = _detectLevelBar.Maximum;
                _changeLevelBox = false;
            }
            else
            {
                _detectLevelBar.Value = _detectLevel;
            }
            ProcessDefinedDetectLevel(_detectLevel);
        }

        private void _detectLevelBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ProcessDefinedDetectLevel(int level)
        {
            _detectLevelSeries.Points.Clear();
            _detectLevelSeries.Points.AddXY(_xAxixMinimum, level);
            _detectLevelSeries.Points.AddXY(_xAxisMaximum, level);
        }

        private void ProcessDetectedFrequency(float frequency)
        {
            _detectedFrequencyBox.Text = frequency.ToString() + " Hz";
            _detectedNoteBox.Text = _spectrumUtils.ConvertToneToPianoKeyNumber(frequency).ToString();
        }
    }
}
