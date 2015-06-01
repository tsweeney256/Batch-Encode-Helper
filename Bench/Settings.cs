/*Bench
Copyright (C) 2015 Thomas Sweeney

This file is part of Bench.
Bench is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Bench is distributed in the hope that it will be useful,
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

namespace Bench
{
    [Serializable]
    public class Settings
    {
        public string[] x264Args { get; set; }
        public int[] encoder { get; set; }
        public string[] fileNamePrefix { get; set; }
        public string[] fileNameBody { get; set; }
        public string[] fileNameSuffix { get; set; }
        public string videoTrackName { get; set; }
        public string videoLanguageCode { get; set; }
        public string avisynthTemplate { get; set; }
        public decimal[] quality { get; set; }
        public string[] audioTrackName { get; set; }
        public string[] audioLanguageCode { get; set; }
        public int counterIndex { get; set; }
        public int counterValue { get; set; }
        public bool noAudio { get; set; }

        public Settings() { }

        public Settings(Settings settings)
        {
            x264Args = (string[])settings.x264Args.Clone();
            encoder = (int[])settings.encoder.Clone();
            fileNamePrefix = (string[])settings.fileNamePrefix.Clone();
            fileNameBody = (string[])settings.fileNameBody.Clone();
            fileNameSuffix = (string[])settings.fileNameSuffix.Clone();
            videoTrackName = settings.videoTrackName;
            videoLanguageCode = settings.videoLanguageCode;
            avisynthTemplate = settings.avisynthTemplate;
            quality = (decimal[])settings.quality.Clone();
            audioTrackName = (string[])settings.audioTrackName.Clone();
            audioLanguageCode = (string[])settings.audioLanguageCode.Clone();
            counterIndex = settings.counterIndex;
            counterValue = settings.counterValue;
            noAudio = settings.noAudio;
        }

        public virtual void Initialize()
        {
            x264Args = new string[1];
            encoder = new int[1];
            fileNamePrefix = new string[1];
            fileNameBody = new string[1];
            fileNameSuffix = new string[1];
            quality = new decimal[1];
            audioTrackName = new string[1];
            audioLanguageCode = new string[1];
            counterValue = 1;
        }
    }
}
