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

namespace SendVoiceCommands
{
    /// <summary>
    /// Class with utility/helper functions used for the audio spectrum calulation.
    /// </summary>
    public class AudioSpectrumUtils
    {
        /// <summary>
        /// The used NAudio wave-input source..
        /// </summary>
        private NAudio.Wave.WaveInEvent _waveIn;

        /// <summary>
        /// Length of the FFT values buffer.
        /// </summary>
        private int _fftLength;

        /// <summary>
        /// Creates an instance of the class AudioSpectrumUtils.
        /// </summary>
        /// <param name="waveIn">The used NAudio wave-input source.</param>
        /// <param name="fftLength"></param>
        public AudioSpectrumUtils(NAudio.Wave.WaveInEvent waveIn, int fftLength)
        {
            _waveIn = waveIn;
            _fftLength = fftLength;
        }

        /// <summary>
        /// Converts the given frequency value to the buffer index of the calculated FFT values.
        /// </summary>
        /// <param name="frequency">This frequency will be converted.</param>
        /// <returns></returns>
        public int ConvertFrequencyToIndex(int frequency)
        {
            double maxFrequency;
            if (_waveIn != null)
            {
                maxFrequency = _waveIn.WaveFormat.SampleRate / 2.0d;
            }
            else
            {
                maxFrequency = 22050; // Assume a default 44.1 kHz sample rate.
            }
            return (int)((frequency / maxFrequency) * (_fftLength / 2));
        }

        /// <summary>
        /// Converts the given buffer index of the calculated FFT values into the corresponding frequency. Using the length as minimum value in the case that the buffer
        /// length is creater.
        /// </summary>
        /// <param name="index">The index of the buffer that holds the calculated FFT values.</param>
        /// <returns></returns>
        public int ConvertFrequencyToIndexUsingMinimum(int index)
        {
            return Math.Min(ConvertFrequencyToIndex(index), _fftLength - 1);
        }

        /// <summary>
        /// Converts the given buffer index of the calculated FFT values into the corresponding frequency.
        /// </summary>
        /// <param name="index">The index of the buffer that holds the calculated FFT values.</param>
        /// <returns></returns>
        public float ConvertIndexToFrequency(int index)
        {
            double maxFrequency;
            if (_waveIn != null)
            {
                maxFrequency = _waveIn.WaveFormat.SampleRate / 2.0d;
            }
            else
            {
                maxFrequency = 22050; // Assume a default 44.1 kHz sample rate.
            }
            return (float)((index * maxFrequency) / (_fftLength / 2));
        }

        /// <summary>
        /// Scans throught the list of FFT values and gets the index of the value with the maximum. If no value is above the given maximum level, then no index is returned.
        /// </summary>
        /// <param name="values">List of FFT values.</param>
        /// <param name="maximumLevel">Only returns the index if the calculated maximum is above this level.</param>
        /// <returns></returns>
        public int DetectIndexOfMaximumFrequency(float[] values, float maximumLevel)
        {
            float max = 0f;
            int index = -1;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                    index = i;
                }
            }
            if (max >= maximumLevel)
            {
                // frequency detected
                return index;
            }
            else
            {
                // no frequency detected
                return -1;
            }
        }

        /// <summary>
        /// Converts the given frequency into the corresponding piano key.
        /// </summary>
        /// <param name="frequency">This frequency will be used.</param>
        /// <returns></returns>
        public int ConvertToneToPianoKeyNumber(float frequency)
        {
            // calculate piano keyboard tone number
            return (int)(Math.Log(frequency / 440, 2) * 12) + 49;
        }

        /// <summary>
        /// Converts the given piano key to the corresponding frequency
        /// </summary>
        /// <param name="musicNote">This music-note will be used.</param>
        /// <returns></returns>
        public float ConvertPianoKeyNumberToFrequency(int musicNote)
        {
            // calculate piano keyboard tone number
            //Math.Log(440, 2) + ((x - 49) / 12) = Math.Log(frequency, 2);
            double frequency = 55d * (Math.Pow(2, ((double)musicNote - 13d) / 12d));
            return (float)frequency;
        }
    }
}
