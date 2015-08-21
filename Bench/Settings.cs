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

namespace Bench
{
    public class Settings
    {
        public string[] x264Args { get; set; }
        public int[] encoder { get; set; }
        public string[] fileNamePrefix { get; set; }
        public string fileNameBody { get; set; }
        public string[] fileNameSuffix { get; set; }
        public string videoTrackName { get; set; }
        public string videoLanguageCode { get; set; }
        public string[] avisynthTemplate { get; set; }
        public decimal[] quality { get; set; }
        public string[] audioTrackName { get; set; }
        public string[] audioLanguageCode { get; set; }
        public int counterIndex { get; set; }
        public int counterValue { get; set; }
        public bool noAudio { get; set; }
        public int[] audioTrackNumber { get; set; }

        public Settings() { }

        public Settings(Settings settings)
        {
            x264Args = (string[])settings.x264Args.Clone();
            encoder = (int[])settings.encoder.Clone();
            fileNamePrefix = (string[])settings.fileNamePrefix.Clone();
            fileNameBody = settings.fileNameBody;
            fileNameSuffix = (string[])settings.fileNameSuffix.Clone();
            videoTrackName = settings.videoTrackName;
            videoLanguageCode = settings.videoLanguageCode;
            avisynthTemplate = (string[])settings.avisynthTemplate.Clone();
            quality = (decimal[])settings.quality.Clone();
            audioTrackName = (string[])settings.audioTrackName.Clone();
            audioLanguageCode = (string[])settings.audioLanguageCode.Clone();
            counterIndex = settings.counterIndex;
            counterValue = settings.counterValue;
            noAudio = settings.noAudio;
            audioTrackNumber = (int[])settings.audioTrackNumber.Clone();
        }

        public virtual void Initialize()
        {
            AllocateVidTabs(1);
            AllocateAudioTabs(1);
            audioTrackNumber[0] = 1; //because the updown box can't be less than 1
            counterValue = 1;
        }

        public virtual void AllocateVidTabs(int numTabs)
        {
            x264Args = new string[numTabs];
            encoder = new int[numTabs];
            fileNamePrefix = new string[numTabs];
            fileNameSuffix = new string[numTabs];
            avisynthTemplate = new string[numTabs];
        }

        public virtual void AllocateAudioTabs(int numTabs)
        {
            quality = new decimal[numTabs];
            audioTrackName = new string[numTabs];
            audioLanguageCode = new string[numTabs];
            audioTrackNumber = new int[numTabs];
        }

        public static Settings getIntersection(Settings[] settingsArray)
        {
            Settings intersection = new Settings(settingsArray[0]);
            int minVidTab = int.MaxValue;
            int minAudioTab = int.MaxValue;

            for (int i = 0; i < settingsArray.Length; i++)
            {
                if(settingsArray[i].x264Args.Length < minVidTab){
                    minVidTab = settingsArray[i].x264Args.Length;
                }
                if(settingsArray[i].audioTrackName.Length < minAudioTab){
                    minAudioTab = settingsArray[i].audioTrackName.Length;
                }
            }
            intersection.AllocateVidTabs(minVidTab);
            intersection.AllocateAudioTabs(minAudioTab);

            for (int i = 1; i < settingsArray.Length; i++)
            {
                if (settingsArray[i].fileNameBody != intersection.fileNameBody)
                {
                    intersection.fileNameBody = "";
                }
                if (settingsArray[i].videoTrackName != intersection.videoTrackName)
                {
                    intersection.videoTrackName = "";
                }
                if (settingsArray[i].videoLanguageCode != intersection.videoLanguageCode)
                {
                    intersection.videoLanguageCode = "";
                }
                if (settingsArray[i].counterIndex != intersection.counterIndex)
                {
                    intersection.counterIndex = -1;
                }
                if (settingsArray[i].counterValue != intersection.counterValue)
                {
                    intersection.counterValue = -1;
                }
                if (settingsArray[i].noAudio != intersection.noAudio)
                {
                    intersection.noAudio = false; //this needs to be changed to support the intermediate state
                }
                for (int j = 1; j < minVidTab; j++)
                {
                    if (settingsArray[i].x264Args[j] != intersection.x264Args[0])
                    {
                        intersection.x264Args[0] = "";
                    }
                    if (settingsArray[i].encoder[j] != intersection.encoder[0])
                    {
                        intersection.encoder[0] = -1;
                    }
                    if (settingsArray[i].fileNamePrefix[j] != intersection.fileNamePrefix[0])
                    {
                        intersection.fileNamePrefix[0] = "";
                    }
                    if (settingsArray[i].fileNameSuffix[j] != intersection.fileNameSuffix[0])
                    {
                        intersection.fileNameSuffix[0] = "";
                    }
                    if (settingsArray[i].avisynthTemplate[j] != intersection.avisynthTemplate[0])
                    {
                        intersection.avisynthTemplate[0] = "";
                    }
                }
                for (int j = 1; j < minAudioTab; j++)
                {
                    if (settingsArray[i].quality[j] != intersection.quality[0])
                    {
                        intersection.quality[0] = -1;
                    }
                    if (settingsArray[i].audioTrackName[j] != intersection.audioTrackName[0])
                    {
                        intersection.audioTrackName[0] = "";
                    }
                    if (settingsArray[i].audioLanguageCode[j] != intersection.audioLanguageCode[0])
                    {
                        intersection.audioLanguageCode[0] = "";
                    }
                    if (settingsArray[i].audioTrackNumber[j] != intersection.audioTrackNumber[0])
                    {
                        intersection.audioTrackNumber[0] = -1;
                    }
                }
            }

            return intersection;
        }

        protected XmlElement CreateXmlNode(XmlDocument doc)
        {

            var root = doc.CreateElement("settings");

            var counterNode = doc.CreateElement("counterIndex");
            counterNode.InnerText = counterIndex.ToString();
            root.AppendChild(counterNode);

            var counterValNode = doc.CreateElement("counterVal");
            counterValNode.InnerText = counterValue.ToString();
            counterNode.AppendChild(counterValNode);

            var vidNode = doc.CreateElement("vid");
            root.AppendChild(vidNode);

            var fileNameBodyNode = doc.CreateElement("fileNameBody");
            fileNameBodyNode.InnerText = fileNameBody;
            vidNode.AppendChild(fileNameBodyNode);

            var videoTrackNameNode = doc.CreateElement("videoTrackName");
            videoTrackNameNode.InnerText = videoTrackName;
            vidNode.AppendChild(videoTrackNameNode);

            var videoLanguageCodeNode = doc.CreateElement("videoLanguageCode");
            videoLanguageCodeNode.InnerText = videoLanguageCode;
            vidNode.AppendChild(videoLanguageCodeNode);

            for (int i = 0; i < x264Args.Length; i++)
            {
                var vidTab = doc.CreateElement("vidTab");
                vidNode.AppendChild(vidTab);

                var encoderNode = doc.CreateElement("encoder");
                encoderNode.InnerText = encoder[i].ToString();
                vidTab.AppendChild(encoderNode);

                var fileNamePrefixNode = doc.CreateElement("fileNamePrefix");
                fileNamePrefixNode.InnerText = fileNamePrefix[i];
                vidTab.AppendChild(fileNamePrefixNode);

                var fileNameSuffixNode = doc.CreateElement("fileNameSuffix");
                fileNameSuffixNode.InnerText = fileNameSuffix[i];
                vidTab.AppendChild(fileNameSuffixNode);

                var avisynthTemplateNode = doc.CreateElement("avisynthTemplate");
                avisynthTemplateNode.InnerText = avisynthTemplate[i];
                vidTab.AppendChild(avisynthTemplateNode);
            }

            var audioNode = doc.CreateElement("audio");
            root.AppendChild(audioNode);

            var noAudioNode = doc.CreateElement("noAudio");
            noAudioNode.InnerText = noAudio.ToString();
            audioNode.AppendChild(noAudioNode);

            for (int i = 0; i < audioTrackName.Length; i++)
            {
                var audioTab = doc.CreateElement("audioTab");
                audioNode.AppendChild(audioTab);

                var qualityNode = doc.CreateElement("quality");
                qualityNode.InnerText = quality[i].ToString();
                audioTab.AppendChild(qualityNode);

                var audioTrackNameNode = doc.CreateElement("audioTrackName");
                audioTrackNameNode.InnerText = audioTrackName[i];
                audioTab.AppendChild(audioTrackNameNode);

                var audioLanguageCodeNode = doc.CreateElement("audioLanguageCode");
                audioLanguageCodeNode.InnerText = audioLanguageCode[i];
                audioTab.AppendChild(audioLanguageCodeNode);

                var audioTrackNumberNode = doc.CreateElement("audioTrackNumber");
                audioTrackNumberNode.InnerText = audioTrackNumber[i].ToString();
                audioTab.AppendChild(audioTrackNumberNode);
            }

            return root;
        }
    }
}
