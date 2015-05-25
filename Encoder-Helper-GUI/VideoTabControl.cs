using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder_Helper_GUI
{
    public partial class VideoTabControl : UserControl
    {
        public string TextBox_x264_Args_Text {
            get { return TextBox_x264_Args.Text; }
            set { TextBox_x264_Args.Text = value; }
        }
        public int ComboBox_Encoder_SelectedIndex
        {
            get { return ComboBox_Encoder.SelectedIndex; }
            set { ComboBox_Encoder.SelectedIndex = value;  }
        }
        public string FileNamePrefixText
        {
            get { return textBoxPrefix.Text; }
            set { textBoxPrefix.Text = value; }
        }
        public string FileNameBodyText
        {
            get { return textBoxBody.Text; }
            set { textBoxBody.Text = value; }
        }
        public string FileNameSuffixText
        {
            get { return textBoxSuffix.Text; }
            set { textBoxSuffix.Text = value; }
        }
        //To allow for a hack to workaround ShowDialog() screwing up the size of my textboxes
        public Size TextBox_x264_Args_Size
        {
            get { return TextBox_x264_Args.Size; }
            set { TextBox_x264_Args.Size = value; }
        }
        public Size TextBoxPrefixSize
        {
            get { return textBoxPrefix.Size; }
            set { textBoxPrefix.Size = value; }
        }
        public Size TextBoxBodySize
        {
            get { return textBoxBody.Size; }
            set { textBoxBody.Size = value; }
        }
        public Size TextBoxSuffixSize
        {
            get { return textBoxSuffix.Size; }
            set { textBoxSuffix.Size = value; }
        }
        public int SplitterDistance
        {
            get { return splitContainerPrefixSuffix.SplitterDistance; }
            set { splitContainerPrefixSuffix.SplitterDistance = value; }
        }
        public Size PanelVideoTabSize
        {
            get { return panelVideoTab.Size; }
            set { panelVideoTab.Size = value; }
        }

        public VideoTabControl()
        {
            InitializeComponent();
        }

        public void AttachToNewTab(TabControl tc)
        {
            tc.TabPages.Insert(tc.TabCount - 1, tc.TabCount.ToString());
            var lastPage = tc.TabPages[tc.TabCount - 2];
            attachCommon(lastPage);
            tc.TabPages[tc.TabCount - 2].UseVisualStyleBackColor = true;
            tc.SelectTab(tc.TabCount - 2);
        }

        //hack to get around TabPages.Insert() refusing to work in constructors
        public void AttachToLastTab(TabControl tc)
        {
            tc.TabPages.Add((tc.TabCount + 1).ToString());
            var lastPage = tc.TabPages[tc.TabCount - 1];
            attachCommon(lastPage);
            tc.TabPages[tc.TabCount - 1].UseVisualStyleBackColor = true;
        }

        private void attachCommon(TabPage lastPage)
        {
            //lastPage.Controls.Add(Label_x264_Args);
            //lastPage.Controls.Add(Label_Encoder);
            //lastPage.Controls.Add(TextBox_x264_Args);
            //lastPage.Controls.Add(ComboBox_Encoder);
            //lastPage.Controls.Add(labelPrefix);
            //lastPage.Controls.Add(labelBody);
            //lastPage.Controls.Add(labelSuffix);
            //lastPage.Controls.Add(textBoxPrefix);
            //lastPage.Controls.Add(textBoxBody);
            //lastPage.Controls.Add(textBoxSuffix);
            lastPage.Controls.Add(panelVideoTab);
        }
    }
}
