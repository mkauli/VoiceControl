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
        /// <summary>
        /// Represents the mapping information of one music note
        /// </summary>
        class MusicNote
        {
            public int pianoKey;
            public string musicNoteName;
        }

        private SortedDictionary<int, MusicNote> _musicNotes;

        /// <summary>
        /// Initializes a instance of class MusicNoteUtils.
        /// </summary>
        public MusicNoteUtils()
        {
            using (System.IO.Stream stream = typeof(MusicNoteUtils).Assembly.GetManifestResourceStream("SendVoiceCommands.PianoKeyToFrequency.xml"))
            {
                _musicNotes = new SortedDictionary<int,MusicNote>();

                // read piano-key to frequency mapping file
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.Load(stream);

                System.Xml.XmlNamespaceManager manager = new System.Xml.XmlNamespaceManager(doc.NameTable);
                manager.AddNamespace("ns1", "http://www.exampleURI.com/Schema1");

                System.Xml.XmlNode rootNode = doc.DocumentElement.SelectSingleNode("/ns1:MusicNoteList", manager);
                foreach(System.Xml.XmlNode node in rootNode)
                {
                    MusicNote musicNote = new MusicNote();

                    musicNote.pianoKey = Int32.Parse(node.SelectSingleNode("PianoKey")?.InnerText);
                    musicNote.musicNoteName = node.SelectSingleNode("NotationGerSimple")?.InnerText;
                    _musicNotes[musicNote.pianoKey] = musicNote;
                }
            }
        }

        public string GetMusicNoteFromPianoKey(int pianoKey)
        {
            if(!_musicNotes.ContainsKey(pianoKey))
            {
                return "-";
            }
            return _musicNotes[pianoKey].musicNoteName;
        }
    }
}
