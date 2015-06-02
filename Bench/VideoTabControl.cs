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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bench
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
        public string FileNameSuffixText
        {
            get { return textBoxSuffix.Text; }
            set { textBoxSuffix.Text = value; }
        }
        public string TextBox_AvisynthTemplate_Text
        {
            get { return textBox_AvisynthTemplate.Text; }
            set { textBox_AvisynthTemplate.Text = value; }
        }
        public bool UnsavedChanges { get; set; }

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
            panelVideoTab.Size = lastPage.Size;
            lastPage.Controls.Add(panelVideoTab);
        }

        private void TextBox_x264_Args_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
        }

        private void ComboBox_Encoder_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
        }

        private void textBoxBody_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
        }

        private void textBoxPrefix_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
        }

        private void textBoxSuffix_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
        }

        private void button_BrowseAvisynthTemplate_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                textBox_AvisynthTemplate.Text = openFileDialog.FileName;
            }
        }

        private void TextBox_x264_Args_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
        }
    }
}
