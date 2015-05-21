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

        private int RightClickedArgSettingsTab = -1;
        private TabControl lastTc = null;
        private List<VideoTabCollection> vidTab;
        private List<AudioTabCollection> audioTab;
        private AppSettings settings;

        public Form_Settings()
        {
            InitializeComponent();
            vidTab = new List<VideoTabCollection>();
            TabControl_VideoArgSettings.TabPages.RemoveAt(0); //delete template page 1
            TabControl_VideoArgSettings.TabPages.RemoveAt(0); //delete template "+" page

            audioTab = new List<AudioTabCollection>();
            TabControl_AudioArgSettings.TabPages.RemoveAt(0);
            TabControl_AudioArgSettings.TabPages.RemoveAt(0);

            settings = new AppSettings();
            TextBox_x264_x86_8bit.Text = settings.x264_x86_8bit_location;
            TextBox_x264_x86_10bit.Text = settings.x264_x86_10bit_location;
            TextBox_x264_x64_8bit.Text = settings.x264_x64_8bit_location;
            TextBox_x264_x64_10bit.Text = settings.x264_x64_10bit_location;
            TextBox_MKVMerge.Text = settings.MKVMergeLocation;
            TextBox_NeroAAC.Text = settings.NeroAACLocation;
            TextBox_BePipe.Text = settings.BePipeLocation;
            for (int i = 0; i < settings.x264Args.Length; i++)
            {
                vidTab.Add(new VideoTabCollection());
                TabControl_VideoArgSettings.TabPages.Add((i+1).ToString());
                TabControl_VideoArgSettings.TabPages[TabControl_VideoArgSettings.TabCount-1].UseVisualStyleBackColor = true;
                vidTab[i].AttachToTab(TabControl_VideoArgSettings.TabPages[i]);
                vidTab[i].TextBox_x264_Args.Text = settings.x264Args[i];
                vidTab[i].ComboBox_Encoder.SelectedIndex = settings.encoder[i];
            }
            TextBox_VideoTrackName.Text = settings.videoTrackName;
            TextBox_VideoLanguageCode.Text = settings.videoLanguageCode;
            TabControl_VideoArgSettings.TabPages.Add("    +"); //dumb hack because Insert() refuses to work
            for (int i = 0; i < settings.audioTrackName.Length; i++)
            {
                audioTab.Add(new AudioTabCollection());
                TabControl_AudioArgSettings.TabPages.Add((i+1).ToString());
                TabControl_AudioArgSettings.TabPages[TabControl_AudioArgSettings.TabCount-1].UseVisualStyleBackColor = true;
                audioTab[i].AttachToTab(TabControl_AudioArgSettings.TabPages[i]);
                audioTab[i].NumericUpDown_Quality.Value = settings.quality[i];
                audioTab[i].TextBox_AudioTrackName.Text = settings.audioTrackName[i];
                audioTab[i].TextBox_LanguageCode.Text = settings.audioLanguageCode[i];
            }
            TabControl_AudioArgSettings.TabPages.Add("    +");
        }

        private void Button_Browse_x264_x86_8bit_Click(object sender, EventArgs e)
        {
            var dialogResult = OpenFileDialog_Settings.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_x264_x86_8bit.Text = OpenFileDialog_Settings.FileName;
            }
        }

        private void Button_Browse_x264_x86_10bit_Click(object sender, EventArgs e)
        {
            var dialogResult = OpenFileDialog_Settings.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_x264_x86_10bit.Text = OpenFileDialog_Settings.FileName;
            }
        }

        private void Button_Browse_x264_x64_8bit_Click(object sender, EventArgs e)
        {
            var dialogResult = OpenFileDialog_Settings.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_x264_x64_8bit.Text = OpenFileDialog_Settings.FileName;
            }
        }

        private void Button_Browse_x264_x64_10bit_Click(object sender, EventArgs e)
        {
            var dialogResult = OpenFileDialog_Settings.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_x264_x64_10bit.Text = OpenFileDialog_Settings.FileName;
            }
        }

        private void Button_Browse_MKVMerge_Click(object sender, EventArgs e)
        {
            var dialogResult = OpenFileDialog_Settings.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_MKVMerge.Text = OpenFileDialog_Settings.FileName;
            }
        }

        private void Button_Browse_NeroAAC_Click(object sender, EventArgs e)
        {
            var dialogResult = OpenFileDialog_Settings.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_NeroAAC.Text = OpenFileDialog_Settings.FileName;
            }
        }

        private void Button_Browse_BePipe_Click(object sender, EventArgs e)
        {
            var dialogResult = OpenFileDialog_Settings.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_BePipe.Text = OpenFileDialog_Settings.FileName;
            }
        }

        private void Button_Cancel_Settings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TabControl_AVSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tc = (TabControl)sender;

            if (tc.TabCount == tc.SelectedIndex + 1)
            {
                int numTabs = tc.TabCount;
                tc.TabPages.Insert(numTabs - 1, numTabs.ToString());
                if (TabControl_Settings.SelectedIndex == 0) //Video settings tab
                {
                    vidTab.Add(new VideoTabCollection());
                    vidTab[vidTab.Count - 1].AttachToTab(tc.TabPages[numTabs - 1]);
                }
                else //audio settings tab
                {
                    audioTab.Add(new AudioTabCollection());
                    audioTab[audioTab.Count - 1].AttachToTab(tc.TabPages[numTabs - 1]);
                }
                tc.TabPages[numTabs - 1].UseVisualStyleBackColor = true;
                tc.SelectTab(numTabs - 1);
            }
        }

        private void TabControl_AVSettings_MouseClick(object sender, MouseEventArgs e)
        {
            var tc = (TabControl)sender;

            if (e.Button == MouseButtons.Right && tc.TabCount != 2)
            {
                lastTc = tc;
                for (int i = 0; i < tc.TabCount - 1; i++)
                {
                    var rect = tc.GetTabRect(i);
                    if (rect.Contains(e.Location))
                    {
                        ContextMenuStrip_Tabs.Show(TabControl_VideoArgSettings, e.Location);
                        RightClickedArgSettingsTab = i;
                    }
                }
            }
        }

        private void StripMenuItem_DeleteTab_Click(object sender, EventArgs e)
        {
            for (int i = RightClickedArgSettingsTab + 1; i < lastTc.TabCount - 1; i++)
            {
                lastTc.TabPages[i].Text = i.ToString();
            }
            lastTc.TabPages.RemoveAt(RightClickedArgSettingsTab);
            if (TabControl_Settings.SelectedIndex == 0) //Video settings tab
            {
                vidTab.RemoveAt(RightClickedArgSettingsTab);
            }
            else
            {
                audioTab.RemoveAt(RightClickedArgSettingsTab);
            }
        }

        private void Button_OK_Settings_Click(object sender, EventArgs e)
        {
            settings.x264_x86_8bit_location = TextBox_x264_x86_8bit.Text;
            settings.x264_x86_10bit_location = TextBox_x264_x86_10bit.Text;
            settings.x264_x64_8bit_location = TextBox_x264_x64_8bit.Text;
            settings.x264_x64_10bit_location = TextBox_x264_x64_10bit.Text;
            settings.MKVMergeLocation = TextBox_MKVMerge.Text;
            settings.NeroAACLocation = TextBox_NeroAAC.Text;
            settings.BePipeLocation = TextBox_BePipe.Text;
            settings.x264Args = new string[vidTab.Count];
            settings.encoder = new int[vidTab.Count];
            for (int i = 0; i < vidTab.Count; i++)
            {
                settings.x264Args[i] = vidTab[i].TextBox_x264_Args.Text;
                settings.encoder[i] = vidTab[i].ComboBox_Encoder.SelectedIndex;
            }
            settings.videoTrackName = TextBox_VideoTrackName.Text;
            settings.videoLanguageCode = TextBox_VideoLanguageCode.Text;
            settings.quality = new decimal[audioTab.Count];
            settings.audioTrackName = new string[audioTab.Count];
            settings.audioLanguageCode = new string[audioTab.Count];
            for (int i = 0; i < audioTab.Count; i++)
            {
                settings.quality[i] = audioTab[i].NumericUpDown_Quality.Value;
                settings.audioTrackName[i] = audioTab[i].TextBox_AudioTrackName.Text;
                settings.audioLanguageCode[i] = audioTab[i].TextBox_LanguageCode.Text;
            }

            settings.save();
            this.Close();
        }
    }
}
