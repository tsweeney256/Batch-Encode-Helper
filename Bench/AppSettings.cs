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
using System.Xml;

namespace Bench
{
    public class AppSettings : Settings
    {
        public string x264_x86_8bit_location { get; set; }
        public string x264_x86_10bit_location { get; set; }
        public string x264_x64_8bit_location { get; set; }
        public string x264_x64_10bit_location { get; set; }
        public string MKVMergeLocation { get; set; }
        public string NeroAACLocation { get; set; }
        public string BePipeLocation { get; set; }

        private const string settingsFile = "settings.xml";
        private string version;

        public AppSettings()
        {
            var doc = new XmlDocument();
            if (!File.Exists(settingsFile))
            {
                Initialize();
            }
            try
            {
                doc.Load(settingsFile);
            }
            catch
            {
                var result = MessageBox.Show("Settings file contains errors. A new settings file will be created and the old one will be backed up.",
                    "Error", MessageBoxButtons.OK);
                File.Move(settingsFile, settingsFile + "." + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + " "
                     + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + ".bak");
                Initialize();
                doc.Load(settingsFile);
            }

            counterIndex = Convert.ToInt32(doc.GetElementsByTagName("counterIndex").Item(0).InnerText);
            counterValue = Convert.ToInt32(doc.GetElementsByTagName("counterVal").Item(0).InnerText);
            fileNameBody = doc.GetElementsByTagName("fileNameBody").Item(0).InnerText;
            videoTrackName = doc.GetElementsByTagName("videoTrackName").Item(0).InnerText;
            videoLanguageCode = doc.GetElementsByTagName("videoLanguageCode").Item(0).InnerText;

            int vidTabCount = doc.GetElementsByTagName("x264Args").Count;
            x264Args = new string[vidTabCount];
            var x264ArgsList = doc.GetElementsByTagName("x264Args");
            encoder = new int[vidTabCount];
            var encoderList = doc.GetElementsByTagName("encoder");
            fileNamePrefix = new string[vidTabCount];
            var fileNamePrefixList = doc.GetElementsByTagName("fileNamePrefix");
            fileNameSuffix = new string[vidTabCount];
            var fileNameSuffixList = doc.GetElementsByTagName("fileNameSuffix");
            avisynthTemplate = new string[vidTabCount];
            var avisynthTemplateList = doc.GetElementsByTagName("avisynthTemplate");
            for (int i = 0; i < vidTabCount; i++)
            {
                x264Args[i] = x264ArgsList.Item(i).InnerText;
                encoder[i] = Convert.ToInt32(encoderList.Item(i).InnerText);
                fileNamePrefix[i] = fileNamePrefixList.Item(i).InnerText;
                fileNameSuffix[i] = fileNameSuffixList.Item(i).InnerText;
                avisynthTemplate[i] = avisynthTemplateList.Item(i).InnerText;
            }

            noAudio = Convert.ToBoolean(doc.GetElementsByTagName("noAudio").Item(0).InnerText);

            int audioTabCount = doc.GetElementsByTagName("audioTrackName").Count;
            quality = new decimal[audioTabCount];
            var qualityList = doc.GetElementsByTagName("quality");
            audioTrackName = new string[audioTabCount];
            var audioTrackNameList = doc.GetElementsByTagName("audioTrackName");
            audioLanguageCode = new string[audioTabCount];
            var audioLanguageCodeList = doc.GetElementsByTagName("audioLanguageCode");
            audioTrackNumber = new int[audioTabCount];
            var audioTrackNumberList = doc.GetElementsByTagName("audioTrackNumber");

            for (int i = 0; i < audioTabCount; i++)
            {
                quality[i] = Convert.ToDecimal(qualityList.Item(i).InnerText);
                audioTrackName[i] = audioTrackNameList.Item(i).InnerText;
                audioLanguageCode[i] = audioLanguageCodeList.Item(i).InnerText;
                audioTrackNumber[i] = Convert.ToInt32(audioTrackNumberList.Item(i).InnerText);
            }

            x264_x86_8bit_location = doc.GetElementsByTagName("x264_x86_8bit_location").Item(0).InnerText;
            x264_x86_10bit_location = doc.GetElementsByTagName("x264_x86_10bit_location").Item(0).InnerText;
            x264_x64_8bit_location = doc.GetElementsByTagName("x264_x64_8bit_location").Item(0).InnerText;
            x264_x64_10bit_location = doc.GetElementsByTagName("x264_x64_10bit_location").Item(0).InnerText;
            MKVMergeLocation = doc.GetElementsByTagName("MKVMergeLocation").Item(0).InnerText;
            NeroAACLocation = doc.GetElementsByTagName("NeroAACLocation").Item(0).InnerText;
            BePipeLocation = doc.GetElementsByTagName("BePipeLocation").Item(0).InnerText;


            /*x264Args = settings.x264Args;
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
            noAudio = settings.noAudio;
            audioTrackNumber = settings.audioTrackNumber;
            x264_x86_8bit_location = settings.x264_x86_8bit_location;
            x264_x86_10bit_location = settings.x264_x86_10bit_location;
            x264_x64_8bit_location = settings.x264_x64_8bit_location;
            x264_x64_10bit_location = settings.x264_x64_10bit_location;
            MKVMergeLocation = settings.MKVMergeLocation;
            NeroAACLocation = settings.NeroAACLocation;
            BePipeLocation = settings.BePipeLocation;*/
        }

        public void Save()
        {
            var doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "UTF-8", null));

            var root = doc.CreateElement("root");
            doc.AppendChild(root);

            var settingsNode = CreateXmlNode(doc);
            root.AppendChild(settingsNode);

            var x264_x86_8bit_locationNode = doc.CreateElement("x264_x86_8bit_location");
            x264_x86_8bit_locationNode.InnerText = x264_x86_8bit_location;
            root.AppendChild(x264_x86_8bit_locationNode);

            var x264_x86_10bit_locationNode = doc.CreateElement("x264_x86_10bit_location");
            x264_x86_10bit_locationNode.InnerText = x264_x86_10bit_location;
            root.AppendChild(x264_x86_10bit_locationNode);

            var x264_x64_8bit_locationNode = doc.CreateElement("x264_x64_8bit_location");
            x264_x64_8bit_locationNode.InnerText = x264_x64_8bit_location;
            root.AppendChild(x264_x64_8bit_locationNode);

            var x264_x64_10bit_locationNode = doc.CreateElement("x264_x64_10bit_location");
            x264_x64_10bit_locationNode.InnerText = x264_x64_10bit_location;
            root.AppendChild(x264_x64_10bit_locationNode);

            var MKVMergeLocationNode = doc.CreateElement("MKVMergeLocation");
            MKVMergeLocationNode.InnerText = MKVMergeLocation;
            root.AppendChild(MKVMergeLocationNode);

            var NeroAACLocationNode = doc.CreateElement("NeroAACLocation");
            NeroAACLocationNode.InnerText = NeroAACLocation;
            root.AppendChild(NeroAACLocationNode);

            var BePipeLocationNode = doc.CreateElement("BePipeLocation");
            BePipeLocationNode.InnerText = BePipeLocation;
            root.AppendChild(BePipeLocationNode);

            doc.Save(settingsFile);
        }

        public override void Initialize()
        {
            base.Initialize();
            Save();
        }
    }
}
