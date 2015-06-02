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

namespace Bench
{
    partial class AudioTabControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_LanguageCode = new System.Windows.Forms.TextBox();
            this.Label_LanguageCode = new System.Windows.Forms.Label();
            this.TextBox_AudioTrackName = new System.Windows.Forms.TextBox();
            this.Label_AudioTrackName = new System.Windows.Forms.Label();
            this.NumericUpDown_Quality = new System.Windows.Forms.NumericUpDown();
            this.Label_AudioQuality = new System.Windows.Forms.Label();
            this.numericUpDownTrackNumber = new System.Windows.Forms.NumericUpDown();
            this.labelTrackNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Quality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrackNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_LanguageCode
            // 
            this.TextBox_LanguageCode.Location = new System.Drawing.Point(202, 59);
            this.TextBox_LanguageCode.Name = "TextBox_LanguageCode";
            this.TextBox_LanguageCode.Size = new System.Drawing.Size(180, 20);
            this.TextBox_LanguageCode.TabIndex = 16;
            this.TextBox_LanguageCode.TextChanged += new System.EventHandler(this.TextBox_LanguageCode_TextChanged);
            // 
            // Label_LanguageCode
            // 
            this.Label_LanguageCode.AutoSize = true;
            this.Label_LanguageCode.Location = new System.Drawing.Point(199, 42);
            this.Label_LanguageCode.Name = "Label_LanguageCode";
            this.Label_LanguageCode.Size = new System.Drawing.Size(144, 13);
            this.Label_LanguageCode.TabIndex = 15;
            this.Label_LanguageCode.Text = "Audio Track Language Code";
            // 
            // TextBox_AudioTrackName
            // 
            this.TextBox_AudioTrackName.Location = new System.Drawing.Point(3, 59);
            this.TextBox_AudioTrackName.Name = "TextBox_AudioTrackName";
            this.TextBox_AudioTrackName.Size = new System.Drawing.Size(169, 20);
            this.TextBox_AudioTrackName.TabIndex = 14;
            this.TextBox_AudioTrackName.TextChanged += new System.EventHandler(this.TextBox_AudioTrackName_TextChanged);
            // 
            // Label_AudioTrackName
            // 
            this.Label_AudioTrackName.AutoSize = true;
            this.Label_AudioTrackName.Location = new System.Drawing.Point(3, 42);
            this.Label_AudioTrackName.Name = "Label_AudioTrackName";
            this.Label_AudioTrackName.Size = new System.Drawing.Size(96, 13);
            this.Label_AudioTrackName.TabIndex = 13;
            this.Label_AudioTrackName.Text = "Audio Track Name";
            // 
            // NumericUpDown_Quality
            // 
            this.NumericUpDown_Quality.DecimalPlaces = 2;
            this.NumericUpDown_Quality.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.NumericUpDown_Quality.Location = new System.Drawing.Point(3, 19);
            this.NumericUpDown_Quality.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_Quality.Name = "NumericUpDown_Quality";
            this.NumericUpDown_Quality.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDown_Quality.TabIndex = 12;
            this.NumericUpDown_Quality.ValueChanged += new System.EventHandler(this.NumericUpDown_Quality_ValueChanged);
            // 
            // Label_AudioQuality
            // 
            this.Label_AudioQuality.AutoSize = true;
            this.Label_AudioQuality.Location = new System.Drawing.Point(3, 3);
            this.Label_AudioQuality.Name = "Label_AudioQuality";
            this.Label_AudioQuality.Size = new System.Drawing.Size(39, 13);
            this.Label_AudioQuality.TabIndex = 11;
            this.Label_AudioQuality.Text = "Quality";
            // 
            // numericUpDownTrackNumber
            // 
            this.numericUpDownTrackNumber.Location = new System.Drawing.Point(202, 19);
            this.numericUpDownTrackNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTrackNumber.Name = "numericUpDownTrackNumber";
            this.numericUpDownTrackNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTrackNumber.TabIndex = 17;
            this.numericUpDownTrackNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTrackNumber.ValueChanged += new System.EventHandler(this.numericUpDownTrackNumber_ValueChanged);
            // 
            // labelTrackNumber
            // 
            this.labelTrackNumber.AutoSize = true;
            this.labelTrackNumber.Location = new System.Drawing.Point(202, 3);
            this.labelTrackNumber.Name = "labelTrackNumber";
            this.labelTrackNumber.Size = new System.Drawing.Size(112, 13);
            this.labelTrackNumber.TabIndex = 18;
            this.labelTrackNumber.Text = "Source Track Number";
            // 
            // AudioTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTrackNumber);
            this.Controls.Add(this.numericUpDownTrackNumber);
            this.Controls.Add(this.TextBox_LanguageCode);
            this.Controls.Add(this.Label_LanguageCode);
            this.Controls.Add(this.TextBox_AudioTrackName);
            this.Controls.Add(this.Label_AudioTrackName);
            this.Controls.Add(this.NumericUpDown_Quality);
            this.Controls.Add(this.Label_AudioQuality);
            this.Name = "AudioTabControl";
            this.Size = new System.Drawing.Size(392, 98);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Quality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrackNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_LanguageCode;
        private System.Windows.Forms.Label Label_LanguageCode;
        private System.Windows.Forms.TextBox TextBox_AudioTrackName;
        private System.Windows.Forms.Label Label_AudioTrackName;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Quality;
        private System.Windows.Forms.Label Label_AudioQuality;
        private System.Windows.Forms.NumericUpDown numericUpDownTrackNumber;
        private System.Windows.Forms.Label labelTrackNumber;
    }
}
