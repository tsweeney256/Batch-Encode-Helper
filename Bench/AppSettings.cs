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

        public AppSettings()
        {
            var doc = new XmlDocument();
            if (!File.Exists(settingsFile))
            {
                Initialize();
            }
            doc.Load(settingsFile);
            int errorCode = loadXml(doc);
            if (errorCode != 0)
            {
                string errorMsg;

                if (errorCode == 1)
                    errorMsg = "Settings file contains errors.";
                else if (errorCode == 2)
                    errorMsg = "Setting file is of the wrong version. Only setting files made with version 1.1.x of Bench are supported.";
                else
                    errorMsg = "Encountered a general error"; //should not be possible

                MessageBox.Show(errorMsg + " A new settings file will be created and the old one will be backed up.",
                    "Error", MessageBoxButtons.OK);
                File.Move(settingsFile, settingsFile + "." + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + " "
                    + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + ".bak");
                Initialize();
                doc.Load(settingsFile);
            }
        }

        public void Save()
        {
            var doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "UTF-8", null));

            var root = doc.CreateElement("root");
            doc.AppendChild(root);

            var versionNode = doc.CreateElement("version");
            versionNode.InnerText = "1";
            root.AppendChild(versionNode);

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

        private int loadXml(XmlDocument doc)
        {
            if (doc.GetElementsByTagName("version").Count == 0)
                return 1; //invalid file
            else if (doc.GetElementsByTagName("version").Item(0).InnerText != "1")
                return 2; //invalid version

            LoadXmlNode(doc.SelectSingleNode("//settings"));

            x264_x86_8bit_location = doc.GetElementsByTagName("x264_x86_8bit_location").Item(0).InnerText;
            x264_x86_10bit_location = doc.GetElementsByTagName("x264_x86_10bit_location").Item(0).InnerText;
            x264_x64_8bit_location = doc.GetElementsByTagName("x264_x64_8bit_location").Item(0).InnerText;
            x264_x64_10bit_location = doc.GetElementsByTagName("x264_x64_10bit_location").Item(0).InnerText;
            MKVMergeLocation = doc.GetElementsByTagName("MKVMergeLocation").Item(0).InnerText;
            NeroAACLocation = doc.GetElementsByTagName("NeroAACLocation").Item(0).InnerText;
            BePipeLocation = doc.GetElementsByTagName("BePipeLocation").Item(0).InnerText;

            return 0;
        }
    }
}
