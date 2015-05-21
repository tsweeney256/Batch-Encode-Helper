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

        public Form_Settings()
        {
            InitializeComponent();
            vidTab = new List<VideoTabCollection>();
            vidTab.Add(new VideoTabCollection());
            TabControl_VideoArgSettings.TabPages.RemoveAt(0);
            //TabControl_VideoArgSettings.TabPages.Insert(0, new TabPage()); //I have no idea why this isn't working
            vidTab[0].AttachToTab(TabControl_VideoArgSettings.TabPages[0]);
            TabControl_VideoArgSettings.TabPages[0].Text = "1";
            TabControl_VideoArgSettings.TabPages.Add("    +"); //dumb hack because Insert() refuses to work

            audioTab = new List<AudioTabCollection>();
            audioTab.Add(new AudioTabCollection());
            TabControl_AudioArgSettings.TabPages.RemoveAt(0);
            audioTab[0].AttachToTab(TabControl_AudioArgSettings.TabPages[0]);
            TabControl_AudioArgSettings.TabPages[0].Text = "1";
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
    }
}
