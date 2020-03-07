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
using System.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SendVoiceCommands
{
    /// <summary>
    /// Main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private NAudio.Wave.WaveInEvent waveIn;

        // NAudio fft wants powers of two!
        private static int fftLength = 2048; // 8192; 

        // There might be a sample aggregator in NAudio somewhere but I made a variation for my needs
        private AudioSampleAggregator _sampleAggregator = new AudioSampleAggregator(fftLength);

        private AudioSpectrumUtils _spectrumUtils;

        private short _detectLevel = 0;

        /// <summary>
        /// Stores the application properties in a XML file.
        /// </summary>
        private ApplicationProperties _applicationProperties;

        /// <summary>
        /// Name of the profile/setting xml-file.
        /// </summary>
        private string _profileFilename;

        /// <summary>
        /// This instance processes the event trigger.
        /// </summary>
        private EventTrigger _eventTrigger;

        /// <summary>
        /// The selected process that should receive the musical event.
        /// </summary>
        private ProcessItem _processItem = null;

        private string _language = SendVoiceCommands.Properties.Settings.Default.Language;

        public MainForm()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(_language);
            InitializeComponent();

            switch(_language)
            {
                case "de-DE":
                    _languageBox.SelectedIndex = 0;
                    break;
                case "en-US":
                    _languageBox.SelectedIndex = 1;
                    break;
                default:
                    _languageBox.SelectedIndex = 0;
                    _language = "de-DE";
                    SendVoiceCommands.Properties.Settings.Default.Language = _language;
                    SendVoiceCommands.Properties.Settings.Default.Save();
                    break;
            }

            refreshProcessList();

            waveIn = new NAudio.Wave.WaveInEvent();
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.StartRecording();

            _spectrumUtils = new AudioSpectrumUtils(waveIn, fftLength);
            _applicationProperties = new ApplicationProperties();
            _applicationProperties.EventList = new MusicalNoteEvent[1];
            _applicationProperties.Settings = new CommonSettings();

            // load application settings
            string storedProfileFilename = SendVoiceCommands.Properties.Settings.Default.LastProfileFilename;
            if (System.IO.File.Exists(storedProfileFilename))
            {
                _profileFilename = storedProfileFilename;
                _loadProfileBox.Text = _profileFilename;
            }

            _eventTrigger = new EventTrigger();
        }

        private void closeButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshProcessList()
        {
            _processesBox.Items.Clear();
            EnableGame( false );
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
                item.applicationName = process.ProcessName;

                _processesBox.Items.Add(item);
            }
        }

        private void _processesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_processesBox.SelectedItem != null)
            {
                EnableGame( true );
            }
            else
            {
                EnableGame( false );
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
                _sampleAggregator.Add(sample32);
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
            AudioSpectrumAnalyser dialog = new AudioSpectrumAnalyser(waveIn, _sampleAggregator, _spectrumUtils, _detectLevel);
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                _detectLevel = dialog.GetDetectLevel();
                _applicationProperties.Settings.FrequenceDetectLevel = _detectLevel;
                SaveProfile();
            }
        }

        private void EnableGame(bool enable)
        {
            _processItem = _processesBox.SelectedItem as ProcessItem;
            if (_processItem != null)
            {
                _applicationProperties.Settings.ApplicationName = _processItem.applicationName;
                SaveProfile();
            }
        }

        private void SendEventToApplication()
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

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void _loadProfileButton_Click(object sender, EventArgs e)
        {
            if(_loadProfileDialog.ShowDialog() == DialogResult.OK)
            {
                _loadProfileBox.Text = _loadProfileDialog.FileName;
            }
        }

        private void _loadProfileBox_TextChanged(object sender, EventArgs e)
        {
            if(System.IO.File.Exists(_loadProfileBox.Text))
            {
                EnableProfileEdit(true);
            }
            else
            {
                EnableProfileEdit(false);
            }
        }

        private void EnableProfileEdit(bool status)
        {
            _spectrumButton.Enabled = status;
            _processesBox.Enabled = status;
            _refreshButton.Enabled = status;
            _eventsCreateButton.Enabled = status;
            _eventsDeleteButton.Enabled = status;
            _eventsListBox.Enabled = status;
            _eventsEditButton.Enabled = false;

            if(status)
            {
                // store setting
                if (_profileFilename != _loadProfileBox.Text)
                {
                    _profileFilename = _loadProfileBox.Text;
                    SendVoiceCommands.Properties.Settings.Default.LastProfileFilename = _profileFilename;
                    SendVoiceCommands.Properties.Settings.Default.Save();
                }
                LoadProfile();
            }
            else
            {
                _profileFilename = "";
            }
        }

        private void _createNewProfileButton_Click(object sender, EventArgs e)
        {
            if(_saveProfileDialog.ShowDialog() == DialogResult.OK)
            {
                _loadProfileBox.Text = _saveProfileDialog.FileName;
                ResetSettings();
                SaveProfile();
            }
        }

        private void SaveProfile()
        {
            if (_profileFilename != "")
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ApplicationProperties));
                System.IO.TextWriter writer = new System.IO.StreamWriter(_profileFilename);
                serializer.Serialize(writer, _applicationProperties);
                writer.Close();
            }
        }

        private void LoadProfile()
        {
            if (_profileFilename != "")
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ApplicationProperties));
                System.IO.TextReader reader = new System.IO.StreamReader(_profileFilename);
                _applicationProperties = serializer.Deserialize(reader) as ApplicationProperties;
                reader.Close();
                UpdateGui();
            }
        }

        private void UpdateGui()
        {
            refreshProcessList();
            foreach( object itemObject in _processesBox.Items )
            {
                ProcessItem item = itemObject as ProcessItem;
                if(item.applicationName == _applicationProperties.Settings.ApplicationName)
                {
                    _processesBox.SelectedItem = itemObject;
                    break;
                }
            }
            _detectLevel = _applicationProperties.Settings.FrequenceDetectLevel;
            RefreshEventsList();
        }

        private void ResetSettings()
        {
            _detectLevel = 1000;
            _applicationProperties.Settings.FrequenceDetectLevel = _detectLevel;
            _processesBox.Items.Clear();
            _processesBox.SelectedItem = null;
            _processesBox.Text = "";
            _applicationProperties.Settings.ApplicationName = "";
            _applicationProperties.EventList = new MusicalNoteEvent[0];
            RefreshEventsList();
        }

        private void _eventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_eventsListBox.SelectedItem != null)
            {
                _eventsEditButton.Enabled = true;
            }
            else
            {
                _eventsEditButton.Enabled = false;
            }
        }

        private void _eventsCreateButton_Click(object sender, EventArgs e)
        {
            EventsEditForm dialog = new EventsEditForm(null, _sampleAggregator, _spectrumUtils, _detectLevel, null, _eventTrigger, _processItem);
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                HandleEventDialogData(dialog, null);
            }
        }

        private void _eventsEditButton_Click(object sender, EventArgs e)
        {
            if (_eventsListBox.SelectedItem != null)
            {
                MusicalNoteEvent musicalNoteEvent = _eventsListBox.SelectedItem as MusicalNoteEvent;
                EventsEditForm dialog = new EventsEditForm(musicalNoteEvent.Name, _sampleAggregator, _spectrumUtils, _detectLevel, musicalNoteEvent, _eventTrigger, _processItem);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    HandleEventDialogData(dialog, musicalNoteEvent);
                }
            }
        }

        private void HandleEventDialogData(EventsEditForm dialog, MusicalNoteEvent musicalNoteEvent)
        {
            // handle set detection level
            _detectLevel = dialog.GetDetectLevel();
            _applicationProperties.Settings.FrequenceDetectLevel = _detectLevel;

            // handle key setting
            EventsEditForm.EventKey eventKey = dialog.GetEventKey();

            MusicalNoteEvent currentMusicalNote = null;

            if (musicalNoteEvent == null)
            {
                // create the Event
                int currentEventListLength = _applicationProperties.EventList.Length;
                MusicalNoteEvent[] newEventList = _applicationProperties.EventList.Clone() as MusicalNoteEvent[];
                Array.Resize(ref newEventList, currentEventListLength + 1);

                currentMusicalNote = new MusicalNoteEvent();
                newEventList[currentEventListLength] = currentMusicalNote;
                _applicationProperties.EventList = newEventList.Clone() as MusicalNoteEvent[];
            }
            else
            {
                currentMusicalNote = musicalNoteEvent;
            }

            currentMusicalNote.Name = dialog.GetEventName();
            currentMusicalNote.KeyAlt = eventKey.Alt;
            currentMusicalNote.KeyControl = eventKey.Control;
            currentMusicalNote.KeyShift = eventKey.Shift;
            currentMusicalNote.KeyValue = eventKey.Value;
            currentMusicalNote.PianoKey = dialog.GetPianoKey();
            currentMusicalNote.HalfToneTolerance = dialog.GetHalfToneTolerance();

            RefreshEventsList();
            SaveProfile();
        }

        private void RefreshEventsList()
        {
            _eventsListBox.Items.Clear();
            _eventsListBox.Text = "";
            _eventsListBox.SelectedItem = null;

            foreach(MusicalNoteEvent musicalNote in _applicationProperties.EventList)
            {
                _eventsListBox.Items.Add(musicalNote);
            }
        }

        private void _eventsDeleteButton_Click(object sender, EventArgs e)
        {
            if (_eventsListBox.SelectedItem != null)
            {
                // remove index from array
                List<MusicalNoteEvent> tmp = new List<MusicalNoteEvent>(_applicationProperties.EventList);
                tmp.RemoveAt(_eventsListBox.SelectedIndex);
                _applicationProperties.EventList = tmp.ToArray();
                RefreshEventsList();
                SaveProfile();
            }
        }

        private void _languageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (_languageBox.SelectedIndex)
            {
                case 0:
                    _language = "de-DE";
                    break;
                case 1:
                    _language = "en-US";
                    break;
                default:
                    _language = "de-DE";
                    break;
            }

            // store new language
            SendVoiceCommands.Properties.Settings.Default.Language = _language;
            SendVoiceCommands.Properties.Settings.Default.Save();

            // change language at runtime
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(_language);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            // store persistent properties
            string profileFileName = _loadProfileBox.Text;
            System.Drawing.Size formSize = Size;
            // reset resources
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            // restore persistent properties
            _loadProfileBox.Text = profileFileName;
            Size = formSize;
        }
        private void applyResources(System.ComponentModel.ComponentResourceManager resources, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name);
                applyResources(resources, ctl.Controls);
            }
        }
    }
}