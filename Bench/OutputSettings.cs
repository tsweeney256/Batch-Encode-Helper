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
using System.Xml;
using System.IO;

namespace Bench
{
    public class OutputSettings : Settings
    {
        public string FileName { get; set; }

        public OutputSettings() { }
        public OutputSettings(Settings settings) : base(settings) { }

        public override int LoadXmlNode(XmlNode SettingNode)
        {
            int result = base.LoadXmlNode(SettingNode);
            if (result != 0)
                return result;
            FileName = SettingNode.SelectSingleNode(".//file").InnerText;
            return 0;
        }
    }

    public class OutputSettingsList : List<OutputSettings>
    {
        public OutputSettingsList() { }

        public void Save(string path)
        {
            var doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "UTF-8", null));

            var root = doc.CreateElement("root");
            doc.AppendChild(root);

            var versionNode = doc.CreateElement("version");
            versionNode.InnerText = "1";
            root.AppendChild(versionNode);

            foreach (var setting in this)
            {
                var inputNode = doc.CreateElement("input");
                root.AppendChild(inputNode);

                var fileNode = doc.CreateElement("file");
                fileNode.InnerText = setting.FileName;
                inputNode.AppendChild(fileNode);

                var settingsNode = setting.CreateXmlNode(doc);
                inputNode.AppendChild(settingsNode);
            }
            doc.Save(path);
        }

        public int Load(string path)
        {
            this.Clear();
            var doc = new XmlDocument();
            if (!File.Exists(path))
                return 3; //file does not exist
            doc.Load(path);

            if (doc.GetElementsByTagName("version").Count == 0)
                return 1; //invalid file
            else if (doc.GetElementsByTagName("version").Item(0).InnerText != "1")
                return 2; //invalid version

            var settingNodes = doc.SelectNodes("//input");
            int size = settingNodes.Count;
            for (int i = 0; i < size; i++)
            {
                var outputSettings = new OutputSettings();
                outputSettings.LoadXmlNode(settingNodes.Item(i));
                this.Add(outputSettings);
            }

            return 0;
        }
    }
}
