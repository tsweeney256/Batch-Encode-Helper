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
        public bool UnsavedChanges { get; set; }

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

        private void NumericUpDown_Quality_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
        }

        private void TextBox_AudioTrackName_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
        }

        private void TextBox_LanguageCode_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
        }
    }
}
