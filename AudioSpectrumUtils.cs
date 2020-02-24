using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendVoiceCommands
{
    public class AudioSpectrumUtils
    {
        private NAudio.Wave.WaveInEvent _waveIn;
        private int _fftLength;

        public AudioSpectrumUtils(NAudio.Wave.WaveInEvent waveIn, int fftLength)
        {
            _waveIn = waveIn;
            _fftLength = fftLength;
        }

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

        public int ConvertFrequencyToIndexUsingMinimum(int index)
        {
            return Math.Min(ConvertFrequencyToIndex(index), _fftLength - 1);
        }

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

        public int DetectIndexOfMaximumFrequency(float[] values, float level)
        {
            float max = 0f;
            int index = -1;
            for(int i=0; i<values.Length; i++)
            {
                if(values[i] > max)
                {
                    max = values[i];
                    index = i;
                }
            }
            if (max >= level)
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

        public int ConvertToneToPianoKeyNumber(float frequency)
        {
            // calculate piano keyboard tone number
            return (int)(Math.Log(frequency / 440, 2) * 12) + 49;
        }
    }
}
