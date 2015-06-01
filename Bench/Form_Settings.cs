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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bench
{
    public partial class Form_Settings : Form
    {
        private AppSettings settings;
        private LocationTabControl locationTabControl;
        private List<VideoTabControl> vidTab;
        private List<AudioTabControl> audioTab;

        public Form_Settings()
        {
            InitializeComponent();

            settings = new AppSettings();
            settingsTabCollection.LoadSettings(settings);
            settingsTabCollection.TabCollectionControl.TabPages[0].Text = "Video Defaults";
            settingsTabCollection.TabCollectionControl.TabPages[1].Text = "Audio Defaults";
            locationTabControl = new LocationTabControl();
            vidTab = settingsTabCollection.VideoTabList;
            audioTab = settingsTabCollection.AudioTabList;

            this.Controls.Add(settingsTabCollection);
            settingsTabCollection.TabCollectionControl.TabPages.Add("Locations");
            settingsTabCollection.TabCollectionControl.TabPages[settingsTabCollection.TabCollectionControl.TabCount - 1].UseVisualStyleBackColor = true;
            settingsTabCollection.TabCollectionControl.TabPages[settingsTabCollection.TabCollectionControl.TabCount - 1].Controls.Add(locationTabControl);
            locationTabControl.TextBox_x264_x86_8bit_Text = settings.x264_x86_8bit_location;
            locationTabControl.TextBox_x264_x86_10bit_Text = settings.x264_x86_10bit_location;
            locationTabControl.TextBox_x264_x64_8bit_Text = settings.x264_x64_8bit_location;
            locationTabControl.TextBox_x264_x64_10bit_Text = settings.x264_x64_10bit_location;
            locationTabControl.TextBox_MKVMerge_Text = settings.MKVMergeLocation;
            locationTabControl.TextBox_NeroAAC_Text = settings.NeroAACLocation;
            locationTabControl.TextBox_BePipe_Text = settings.BePipeLocation;
        }

        private void Button_Cancel_Settings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_OK_Settings_Click(object sender, EventArgs e)
        {
            settings.x264_x86_8bit_location = locationTabControl.TextBox_x264_x86_8bit_Text;
            settings.x264_x86_10bit_location = locationTabControl.TextBox_x264_x86_10bit_Text;
            settings.x264_x64_8bit_location = locationTabControl.TextBox_x264_x64_8bit_Text;
            settings.x264_x64_10bit_location = locationTabControl.TextBox_x264_x64_10bit_Text;
            settings.MKVMergeLocation = locationTabControl.TextBox_MKVMerge_Text;
            settings.NeroAACLocation = locationTabControl.TextBox_NeroAAC_Text;
            settings.BePipeLocation = locationTabControl.TextBox_BePipe_Text;
            settings.x264Args = new string[vidTab.Count];
            settings.encoder = new int[vidTab.Count];
            settings.fileNamePrefix = new string[vidTab.Count];
            settings.fileNameBody = new string[vidTab.Count];
            settings.fileNameSuffix = new string[vidTab.Count];
            settings.counterIndex = settingsTabCollection.ComboBoxCounterSelectedIndex;
            settings.counterValue = settingsTabCollection.NumericUpDownCounterValue;
            for (int i = 0; i < vidTab.Count; i++)
            {
                settings.x264Args[i] = vidTab[i].TextBox_x264_Args_Text;
                settings.encoder[i] = vidTab[i].ComboBox_Encoder_SelectedIndex;
                settings.fileNamePrefix[i] = vidTab[i].FileNamePrefixText;
                settings.fileNameBody[i] = vidTab[i].FileNameBodyText;
                settings.fileNameSuffix[i] = vidTab[i].FileNameSuffixText;
            }
            settings.videoTrackName = settingsTabCollection.TextBox_VideoTrackName_Text;
            settings.videoLanguageCode = settingsTabCollection.TextBox_VideoLanguageCode_Text;
            settings.avisynthTemplate = settingsTabCollection.TextBox_AvisynthTemplate_Text;
            settings.quality = new decimal[audioTab.Count];
            settings.audioTrackName = new string[audioTab.Count];
            settings.audioLanguageCode = new string[audioTab.Count];
            for (int i = 0; i < audioTab.Count; i++)
            {
                settings.quality[i] = audioTab[i].NumericUpDown_Quality_Value;
                settings.audioTrackName[i] = audioTab[i].TextBox_AudioTrackName_Text;
                settings.audioLanguageCode[i] = audioTab[i].TextBox_LanguageCode_Text;
            }

            settings.Save();
            this.Close();
        }
    }
}
