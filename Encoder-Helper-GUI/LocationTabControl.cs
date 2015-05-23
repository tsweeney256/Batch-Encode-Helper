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
    public partial class LocationTabControl : UserControl
    {
        public string TextBox_x264_x86_8bit_Text
        {
            get { return TextBox_x264_x86_8bit.Text; }
            set { TextBox_x264_x86_8bit.Text = value; }
        }
        public string TextBox_x264_x86_10bit_Text
        {
            get { return TextBox_x264_x86_10bit.Text; }
            set { TextBox_x264_x86_10bit.Text = value; }
        }
        public string TextBox_x264_x64_8bit_Text
        {
            get { return TextBox_x264_x64_8bit.Text; }
            set { TextBox_x264_x64_8bit.Text = value; }
        }
        public string TextBox_x264_x64_10bit_Text
        {
            get { return TextBox_x264_x64_10bit.Text; }
            set { TextBox_x264_x64_10bit.Text = value; }
        }
        public string TextBox_MKVMerge_Text
        {
            get { return TextBox_MKVMerge.Text; }
            set { TextBox_MKVMerge.Text = value; }
        }
        public string TextBox_NeroAAC_Text
        {
            get { return TextBox_NeroAAC.Text; }
            set { TextBox_NeroAAC.Text = value; }
        }
        public string TextBox_BePipe_Text
        {
            get { return TextBox_BePipe.Text; }
            set { TextBox_BePipe.Text = value; }
        }

        public LocationTabControl()
        {
            InitializeComponent();
        }

        private void Button_Browse_x264_x86_8bit_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_x264_x86_8bit.Text = openFileDialog.FileName;
            }
        }

        private void Button_Browse_x264_x86_10bit_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_x264_x86_10bit.Text = openFileDialog.FileName;
            }
        }

        private void Button_Browse_x264_x64_8bit_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_x264_x64_8bit.Text = openFileDialog.FileName;
            }
        }

        private void Button_Browse_x264_x64_10bit_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_x264_x64_10bit.Text = openFileDialog.FileName;
            }
        }

        private void Button_Browse_MKVMerge_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_MKVMerge.Text = openFileDialog.FileName;
            }
        }

        private void Button_Browse_NeroAAC_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_NeroAAC.Text = openFileDialog.FileName;
            }
        }

        private void Button_Browse_BePipe_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TextBox_BePipe.Text = openFileDialog.FileName;
            }
        }
    }
}
