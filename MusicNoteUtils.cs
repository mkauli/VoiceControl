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
using System.Collections.Generic;

namespace SendVoiceCommands
{
    /// <summary>
    /// Utility/helper class for handling music notes.
    /// </summary>
    public class MusicNoteUtils
    {
        private SortedDictionary<int, SendVoiceCommands.MusicalNote> _musicalNotes;
        private MusicalNoteList _xmlMusicalNotes;

        /// <summary>
        /// Initializes a instance of class MusicNoteUtils.
        /// </summary>
        public MusicNoteUtils()
        {
            using (System.IO.Stream stream = typeof(MusicNoteUtils).Assembly.GetManifestResourceStream("SendVoiceCommands.UML_Model.PianoKeyToFrequency.xml"))
            {
                // read xml data from embedded string an deserializes it into the corresponding XML-Serializer class.
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(MusicalNoteList));
                _xmlMusicalNotes = serializer.Deserialize(stream) as MusicalNoteList;

                // Fill container with the read musical-note definitions.
                _musicalNotes = new SortedDictionary<int, MusicalNote>();
                foreach(SendVoiceCommands.MusicalNote xmlMusicalNote in _xmlMusicalNotes.MusicalNote)
                {
                    _musicalNotes[xmlMusicalNote.PianoKey] = xmlMusicalNote;
                }
            }
        }

        public string GetMusicNoteFromPianoKey(int pianoKey)
        {
            if(!_musicalNotes.ContainsKey(pianoKey))
            {
                return "-";
            }
            return _musicalNotes[pianoKey].NotationGerSimple;
        }
    }
}
