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
using System.Diagnostics;

namespace SendVoiceCommands
{
    /// <summary>
    /// Aggragates the audio samples of the NAudio wafeIn.
    /// </summary>
    public class AudioSampleAggregator
    {
        /// <summary>
        /// Arguments that will be forwarded to the FFT event handler.
        /// </summary>
        public class FftEventArgs : EventArgs
        {
            [DebuggerStepThrough]
            public FftEventArgs(NAudio.Dsp.Complex[] result)
            {
                this.Result = result;
            }
            public NAudio.Dsp.Complex[] Result { get; private set; }
        }

        /// <summary>
        /// Property to enable/disable FFT calculation.
        /// </summary>
        public bool PerformFFT { get; set; }

        /// <summary>
        /// Event handler for calculated FFT values.
        /// </summary>
        private event EventHandler<FftEventArgs> _fftCalculatedEventHandler;

        /// <summary>
        /// Buffer that stores the calculated FFT values in Complex format.
        /// </summary>        
        private NAudio.Dsp.Complex[] _fftBuffer;

        /// <summary>
        /// Arguments that will be forwarded to the FFT event-handler.
        /// </summary>
        private FftEventArgs _fftArgs;

        /// <summary>
        /// Current position of storing values in the buffer of calculated FFT values.
        /// </summary>
        private int _fftBufferIndex;

        /// <summary>
        /// Length of the FFT values buffer.
        /// </summary>
        private int _fftBufferLength;

        /// <summary>
        /// FFT argument m - exponent of the log2 nodes.
        /// </summary>
        private int _fftArgumentM;

        /// <summary>
        /// Creates the instance of the class AudioSampleAggregator.
        /// </summary>
        /// <param name="fftLength"></param>
        public AudioSampleAggregator(int fftLength)
        {
            if (!IsPowerOfTwo(fftLength))
            {
                throw new ArgumentException("FFT Length must be a power of two");
            }
            this._fftArgumentM = (int)Math.Log(fftLength, 2.0);
            this._fftBufferLength = fftLength;
            this._fftBuffer = new NAudio.Dsp.Complex[fftLength];
            this._fftArgs = new FftEventArgs(_fftBuffer);
        }

        /// <summary>
        /// Checks if the given value is power of two.
        /// </summary>
        /// <param name="x">The value that is checked.</param>
        /// <returns></returns>
        bool IsPowerOfTwo(int x)
        {
            return (x & (x - 1)) == 0;
        }

        /// <summary>
        /// Aggregates the given audio sample value into the buffer and calculates the FFT over the whole sampled data.
        /// </summary>
        /// <param name="value"></param>
        public void Add(float value)
        {
            if (PerformFFT && _fftCalculatedEventHandler != null)
            {
                // Remember the window function! There are many others as well.
                _fftBuffer[_fftBufferIndex].X = (value); // (float)(value * NAudio.Dsp.FastFourierTransform.HammingWindow(fftPos, fftLength));
                _fftBuffer[_fftBufferIndex].Y = 0; // This is always zero with audio.
                _fftBufferIndex++;
                if (_fftBufferIndex >= _fftBufferLength)
                {
                    _fftBufferIndex = 0;
                    NAudio.Dsp.FastFourierTransform.FFT(true, _fftArgumentM, _fftBuffer);
                    _fftCalculatedEventHandler(this, _fftArgs);
                }
            }
        }

        /// <summary>
        /// Adds an event handler, this event handler is called when FFT data is available.
        /// </summary>
        /// <param name="eventHandle">The corresponding event handler.</param>
        public void addEventHandler(EventHandler<FftEventArgs> eventHandle)
        {
            _fftCalculatedEventHandler += eventHandle;
        }

        /// <summary>
        /// Removes the given event handler from the list of handlers.
        /// </summary>
        /// <param name="eventHandle">The corresponding event handler.</param>
        public void removeEventHandler(EventHandler<FftEventArgs> eventHandle)
        {
            _fftCalculatedEventHandler -= eventHandle;
        }
    }
}
