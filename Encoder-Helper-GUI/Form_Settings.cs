using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder_Helper_GUI
{
    public partial class Form_Settings : Form
    {
        private AppSettings settings;
        private LocationTabControl locationTabControl;
        private List<VideoTabControl> vidTab;
        private List<AudioTabControl> audioTab;
        private Size Size_TextBox_x264Args;
        private Size sizeTextBoxPrefix;
        private Size sizeTextBoxBody;
        private Size sizeTextBoxSuffix;
        private int splitterDistance;

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
            Size_TextBox_x264Args = settingsTabCollection.VideoTabList[0].TextBox_x264_Args_Size;
            sizeTextBoxPrefix = settingsTabCollection.VideoTabList[0].TextBoxPrefixSize;
            sizeTextBoxBody = settingsTabCollection.VideoTabList[0].TextBoxBodySize;
            sizeTextBoxSuffix = settingsTabCollection.VideoTabList[0].TextBoxSuffixSize;
            splitterDistance = settingsTabCollection.VideoTabList[0].SplitterDistance;

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

        private void Form_Settings_Shown(object sender, EventArgs e)
        {
            //dumb hack because ShowDialog() keeps screwing up the size of the textboxes
            for (int i = 0; i < settingsTabCollection.VideoTabList.Count; i++)
            {
                settingsTabCollection.VideoTabList[i].TextBox_x264_Args_Size = Size_TextBox_x264Args;
                //settingsTabCollection.VideoTabList[i].TextBoxPrefixSize = sizeTextBoxPrefix;
                settingsTabCollection.VideoTabList[i].TextBoxBodySize = sizeTextBoxBody;
                settingsTabCollection.VideoTabList[i].TextBoxSuffixSize = new Size(sizeTextBoxSuffix.Width - 107, sizeTextBoxSuffix.Height);
                settingsTabCollection.VideoTabList[i].SplitterDistance = splitterDistance;
            }
        }
    }
}
