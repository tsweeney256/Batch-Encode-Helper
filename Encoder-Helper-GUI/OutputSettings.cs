/*Batch Encoder Helper
Copyright (C) 2015 Thomas Sweeney

This file is part of Batch Encoder Helper.
Batch Encoder Helper is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Batch Encoder Helper is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
 
You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder_Helper_GUI
{
    [Serializable]
    public class OutputSettings : Settings
    {
        public string FileName { get; set; }

        public OutputSettings() { }
        public OutputSettings(Settings settings) : base(settings) { }
    }
}
