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
using System.Windows.Forms;
using System.IO;

namespace Bench
{
    [Serializable]
    public class AppSettings : Settings
    {
        public string x264_x86_8bit_location { get; set; }
        public string x264_x86_10bit_location { get; set; }
        public string x264_x64_8bit_location { get; set; }
        public string x264_x64_10bit_location { get; set; }
        public string MKVMergeLocation { get; set; }
        public string NeroAACLocation { get; set; }
        public string BePipeLocation { get; set; }

        private const string settingsFile = "settings.bin";

        public AppSettings()
        {
            AppSettings settings;
            if (!File.Exists(settingsFile))
            {
                Initialize();
            }
            try
            {
                using (Stream stream = File.Open(settingsFile, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    settings = (AppSettings)bformatter.Deserialize(stream);
                }
            }
            catch
            {
                var result = MessageBox.Show("Settings file contains errors. A new settings file will be created and the old one will be backed up.",
                    "Error", MessageBoxButtons.OK);
                File.Move(settingsFile, settingsFile + "." + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + " "
                     + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + ".bak");
                Initialize();
                using (Stream stream = File.Open(settingsFile, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    settings = (AppSettings)bformatter.Deserialize(stream);
                }
            }
            x264Args = settings.x264Args;
            encoder = settings.encoder;
            fileNamePrefix = settings.fileNamePrefix;
            fileNameBody = settings.fileNameBody;
            fileNameSuffix = settings.fileNameSuffix;
            videoTrackName = settings.videoTrackName;
            videoLanguageCode = settings.videoLanguageCode;
            avisynthTemplate = settings.avisynthTemplate;
            counterIndex = settings.counterIndex;
            counterValue = settings.counterValue;
            quality = settings.quality;
            audioTrackName = settings.audioTrackName;
            audioLanguageCode = settings.audioLanguageCode;
            x264_x86_8bit_location = settings.x264_x86_8bit_location;
            x264_x86_10bit_location = settings.x264_x86_10bit_location;
            x264_x64_8bit_location = settings.x264_x64_8bit_location;
            x264_x64_10bit_location = settings.x264_x64_10bit_location;
            MKVMergeLocation = settings.MKVMergeLocation;
            NeroAACLocation = settings.NeroAACLocation;
            BePipeLocation = settings.BePipeLocation;
        }

        public void Save()
        {
            using(Stream stream = File.Open(settingsFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bformatter.Serialize(stream, this);
            }
        }

        public override void Initialize()
        {
            base.Initialize();
            Save();
        }
    }
}
