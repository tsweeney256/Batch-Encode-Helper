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
        //To allow for a hack to workaround ShowDialog() screwing up the size of my textbox
        public Size TextBox_x264_Args_Size
        {
            get { return TextBox_x264_Args.Size; }
            set { TextBox_x264_Args.Size = value; }
        }

        public VideoTabControl()
        {
            InitializeComponent();
        }

        public void AttachToNewTab(TabControl tc)
        {
            tc.TabPages.Insert(tc.TabCount - 1, tc.TabCount.ToString());
            var lastPage = tc.TabPages[tc.TabCount - 2];
            lastPage.Controls.Add(Label_x264_Args);
            lastPage.Controls.Add(Label_Encoder);
            lastPage.Controls.Add(TextBox_x264_Args);
            lastPage.Controls.Add(ComboBox_Encoder);
            tc.TabPages[tc.TabCount - 2].UseVisualStyleBackColor = true;
            tc.SelectTab(tc.TabCount - 2);
        }

        //hack to get around TabPages.Insert() refusing to work in constructors
        public void AttachToLastTab(TabControl tc)
        {
            tc.TabPages.Add((tc.TabCount + 1).ToString());
            var lastPage = tc.TabPages[tc.TabCount - 1];
            lastPage.Controls.Add(Label_x264_Args);
            lastPage.Controls.Add(Label_Encoder);
            lastPage.Controls.Add(TextBox_x264_Args);
            lastPage.Controls.Add(ComboBox_Encoder);
            tc.TabPages[tc.TabCount - 1].UseVisualStyleBackColor = true;
        }
    }
}
