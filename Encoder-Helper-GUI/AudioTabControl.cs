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
    public partial class AudioTabControl : UserControl
    {
        public decimal NumericUpDown_Quality_Value
        {
            get { return NumericUpDown_Quality.Value; }
            set { NumericUpDown_Quality.Value = value;  }
        }
        public string TextBox_AudioTrackName_Text
        {
            get { return TextBox_AudioTrackName.Text; }
            set { TextBox_AudioTrackName.Text = value; }
        }
        public string TextBox_LanguageCode_Text
        {
            get { return TextBox_LanguageCode.Text; }
            set { TextBox_LanguageCode.Text = value; }
        }

        public AudioTabControl()
        {
            InitializeComponent();
        }

        public void AttachToNewTab(TabControl tc)
        {
            tc.TabPages.Insert(tc.TabCount - 1, tc.TabCount.ToString());
            var lastPage = tc.TabPages[tc.TabCount - 2];
            lastPage.Controls.Add(Label_AudioQuality);
            lastPage.Controls.Add(Label_AudioTrackName);
            lastPage.Controls.Add(Label_LanguageCode);
            lastPage.Controls.Add(NumericUpDown_Quality);
            lastPage.Controls.Add(TextBox_AudioTrackName);
            lastPage.Controls.Add(TextBox_LanguageCode);
            tc.TabPages[tc.TabCount - 2].UseVisualStyleBackColor = true;
            tc.SelectTab(tc.TabCount - 2);
        }

        //hack to get around TabPages.Insert() refusing to work in constructors
        public void AttachToLastTab(TabControl tc)
        {
            tc.TabPages.Add((tc.TabCount + 1).ToString());
            var lastPage = tc.TabPages[tc.TabCount - 1];
            lastPage.Controls.Add(Label_AudioQuality);
            lastPage.Controls.Add(Label_AudioTrackName);
            lastPage.Controls.Add(Label_LanguageCode);
            lastPage.Controls.Add(NumericUpDown_Quality);
            lastPage.Controls.Add(TextBox_AudioTrackName);
            lastPage.Controls.Add(TextBox_LanguageCode);
            tc.TabPages[tc.TabCount - 1].UseVisualStyleBackColor = true;
        }
    }
}
