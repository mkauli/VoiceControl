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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendVoiceCommands
{
    public class ProcessItem
    {
        public string title;
        public System.Diagnostics.Process process;
        public string applicationName;

        override public string ToString()
        {
            return title;
        }
    };

    public class EventTrigger
    {
        public void Trigger(MusicalNoteEvent musicalNoteEvent, ProcessItem processItem)
        {
            if(processItem != null)
            {

            }
        }
    }
}
