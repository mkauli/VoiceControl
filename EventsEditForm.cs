﻿/**
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
    public partial class EventsEditForm : Form
    {
        public struct EventKey
        {
            public bool Control;
            public bool Alt;
            public bool Shift;
            public int Value;

            public override string ToString()
            {
                string s = "";
                if (Control) s += "[Ctrl]";
                if (Alt) s += "[Alt]";
                if (Shift) s += "[Shift]";

                switch(Value)
                {
                    case 0:
                        break;
                    case 8: // backspace
                        s += "[Back]";
                        break;
                    case 13: // enter
                        s += "[Enter]";
                        break;
                    case 27: // esc
                        s += "[Esc]";
                        break;
                    case 32: // space
                        s += "[Space]";
                        break;
                    case 37: // left arrow
                        s += "[Left]";
                        break;
                    case 38: // up arrow
                        s += "[Up]";
                        break;
                    case 39: // right arrow
                        s += "[Right]";
                        break;
                    case 40: // down arrow
                        s += "[Down]";
                        break;
                    default:
                        s += (char)Value;
                        break;
                }

                return s;
            }
        }

        private AudioSampleAggregator _sampleAggregator;
        private EventHandler<AudioSampleAggregator.FftEventArgs> _fftEventHandler;
        private AudioSpectrumUtils _spectrumUtils;
        private MusicNoteUtils _musicNoteUtils;
        private MusicalNoteEvent _musicalNoteEvent;
        private EventTrigger _eventTrigger;
        private ProcessItem _processItem;
        private int _minimumFrequencyIndex;
        private int _maximumFrequencyIndex;
        private Series _spectrumSeries;
        private Series _detectLevelSeries;
        private short _detectLevel = 0;
        private int _xAxixMinimum = 50;
        private int _xAxisMaximum = 900;
        private bool _changeLevelBox = false;
        private EventKey _eventKey;
        private short _pianoKey;
        private short _halftoneTolerance;

        public EventsEditForm(string title, AudioSampleAggregator sampleAggregator, AudioSpectrumUtils spectrumUtils, short detectLevel, MusicalNoteEvent musicalNoteEvent, EventTrigger eventTrigger, ProcessItem processItem)
        {
            InitializeComponent();

            _spectrumSeries = _spectrumChart.Series["spectrumSeries"];
            _spectrumSeries.LegendText = "Frequency Spectrum";
            _spectrumSeries.Points.Clear();
            _spectrumChart.ChartAreas["ChartArea1"].AxisX.Interval = 50;
            _spectrumChart.ChartAreas["ChartArea1"].AxisX.Minimum = _xAxixMinimum;
            _spectrumChart.ChartAreas["ChartArea1"].AxisX.Maximum = _xAxisMaximum;
            _detectLevelSeries = _spectrumChart.Series["detectLevelSeries"];
            _detectLevelSeries.LegendText = "Detect Level";

            if (title != null)
            {
                Text += " [" + title + "]";
            }

            _detectLevel = detectLevel;
            _detectLevelBar.Minimum = 0;
            _detectLevelBar.Maximum = 15000;
            _detectLevelBar.Value = _detectLevel;

            _sampleAggregator = sampleAggregator;
            _fftEventHandler = new EventHandler<AudioSampleAggregator.FftEventArgs>(FftCalculated);
            _sampleAggregator.addEventHandler(_fftEventHandler);
            _sampleAggregator.PerformFFT = true;
            _spectrumUtils = spectrumUtils;
            _minimumFrequencyIndex = _spectrumUtils.ConvertFrequencyToIndexUsingMinimum(55);   // tone A1 
            _maximumFrequencyIndex = _spectrumUtils.ConvertFrequencyToIndexUsingMinimum(880);  // tone a2

            _musicNoteUtils = new MusicNoteUtils();
            _eventTrigger = eventTrigger;
            _musicalNoteEvent = musicalNoteEvent;
            _processItem = processItem;

            _eventKey = new EventKey();

            if(musicalNoteEvent != null)
            {
                _nameBox.Text = musicalNoteEvent.Name;
                _eventKey.Alt = musicalNoteEvent.KeyAlt;
                _eventKey.Control = musicalNoteEvent.KeyControl;
                _eventKey.Shift = musicalNoteEvent.KeyShift;
                _eventKey.Value = musicalNoteEvent.KeyValue;
                _eventBox.Text = _eventKey.ToString();
                _pianoKey = musicalNoteEvent.PianoKey;
                _musicalNoteBox.Text = _musicNoteUtils.GetMusicNoteFromPianoKey(_pianoKey);
                _halftoneTolerance = musicalNoteEvent.HalfToneTolerance;
                _toleranceUpDown.Value = _halftoneTolerance;

            }
        }

        public short GetDetectLevel()
        {
            return _detectLevel;
        }

        public string GetEventName()
        {
            return _nameBox.Text;
        }

        public EventKey GetEventKey()
        {
            return _eventKey;
        }

        public short GetPianoKey()
        {
            return _pianoKey;
        }

        public short GetHalfToneTolerance()
        {
            return _halftoneTolerance;
        }

        private void EventsEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _sampleAggregator.PerformFFT = false;
            _sampleAggregator.removeEventHandler(_fftEventHandler);
        }

        private void _detectLevelBar_ValueChanged(object sender, EventArgs e)
        {
            if (!_changeLevelBox) // avoid updating text-box by bar when insert value is outside of bar area.
            {
                _detectLevelBox.Text = _detectLevelBar.Value.ToString();
            }
        }

        private void _detectLevelBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void _detectLevelBox_TextChanged(object sender, EventArgs e)
        {
            if (_detectLevelBox.Text.Length == 0)
            {
                return;
            }

            _detectLevel = Int16.Parse(_detectLevelBox.Text);
            if (_detectLevel < 0)
            {
                _detectLevel = 0;
            }
            if (_detectLevel < _detectLevelBar.Minimum)
            {
                _changeLevelBox = true;
                _detectLevelBar.Value = _detectLevelBar.Minimum;
                _changeLevelBox = false;
            }
            else if (_detectLevel > _detectLevelBar.Maximum)
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

        void FftCalculated(object sender, AudioSampleAggregator.FftEventArgs e)
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

        private void ProcessDetectedFrequency(float frequency)
        {
            _pianoKey = _spectrumUtils.ConvertToneToPianoKeyNumber(frequency);
            _detectedFrequencyBox.Text = frequency.ToString() + " Hz";
            _detectedNoteBox.Text = _musicNoteUtils.GetMusicNoteFromPianoKey(_pianoKey);
            _musicalNoteBox.Text = _detectedNoteBox.Text;
            _musicalNoteEvent.PianoKey = _pianoKey;
            // calculate difference to music note frequency
            float musicNoteFrequency = _spectrumUtils.ConvertPianoKeyNumberToFrequency(_pianoKey);
            float difference = musicNoteFrequency - frequency;
            _differenceBox.Text = difference.ToString() + " Hz";
            if (difference < 0f)
            {
                // calculate % distance to next lower note
                float nextMusicNoteFrequency = _spectrumUtils.ConvertPianoKeyNumberToFrequency(_pianoKey - 1);
                float distance = difference / (nextMusicNoteFrequency - musicNoteFrequency);
                _differenceSlider.Pan = distance;
            }
            else
            {
                // calculate % distance to next upper note
                float nextMusicNoteFrequency = _spectrumUtils.ConvertPianoKeyNumberToFrequency(_pianoKey + 1);
                float distance = difference / (nextMusicNoteFrequency - musicNoteFrequency);
                _differenceSlider.Pan = distance;
            }
        }

        private void ProcessDefinedDetectLevel(short level)
        {
            _detectLevelSeries.Points.Clear();
            _detectLevelSeries.Points.AddXY(_xAxixMinimum, level);
            _detectLevelSeries.Points.AddXY(_xAxisMaximum, level);
        }

        private void _eventBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;

            _eventKey.Control = e.Control;
            _eventKey.Shift = e.Shift;
            _eventKey.Alt = e.Alt;
            _eventKey.Value = 0;
            switch (e.KeyValue)
            {
                case 16:
                case 17:
                case 18:
                    break;

                default:
                    _eventKey.Value = e.KeyValue;
                    // remove shifted characters
                    if((_eventKey.Value >= 'A') && (_eventKey.Value <= 'Z'))
                    {
                        _eventKey.Value = 'a' + (_eventKey.Value - 'A');
                    }
                    break;
            }
            _eventBox.Text = _eventKey.ToString();
            _musicalNoteEvent.KeyAlt = _eventKey.Alt;
            _musicalNoteEvent.KeyControl = _eventKey.Control;
            _musicalNoteEvent.KeyShift = _eventKey.Shift;
            _musicalNoteEvent.KeyValue = _eventKey.Value;
        }

        private void _nameBox_TextChanged(object sender, EventArgs e)
        {
            if(_nameBox.Text.Length == 0)
            {
                _okButton.Enabled = false;
            }
            else
            {
                _okButton.Enabled = true;
            }
        }

        private void _toleranceUpDown_ValueChanged(object sender, EventArgs e)
        {
            _halftoneTolerance = (short)_toleranceUpDown.Value;
            _musicalNoteEvent.HalfToneTolerance = _halftoneTolerance;
        }

        private void _testEventButton_Click(object sender, EventArgs e)
        {
            _eventTrigger.Trigger(_musicalNoteEvent, _processItem);
        }
    }
}
