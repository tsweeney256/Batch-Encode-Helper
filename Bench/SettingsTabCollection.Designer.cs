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
    partial class SettingsTabCollection
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
            this.components = new System.ComponentModel.Container();
            this.ContextMenuStrip_Tabs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuItem_DeleteTab = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxNoAudio = new System.Windows.Forms.CheckBox();
            this.TabControl_AudioArgSettings = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBoxCounter = new System.Windows.Forms.ComboBox();
            this.TabControl_VideoArgSettings = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage_Audio = new System.Windows.Forms.TabPage();
            this.tabPage_Video = new System.Windows.Forms.TabPage();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.labelBody = new System.Windows.Forms.Label();
            this.numericUpDownCounter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_VideoLanguageCode = new System.Windows.Forms.TextBox();
            this.TextBox_VideoTrackName = new System.Windows.Forms.TextBox();
            this.label_videoLanguageCode = new System.Windows.Forms.Label();
            this.Label_VideoTrackName = new System.Windows.Forms.Label();
            this.TabControl_Settings = new System.Windows.Forms.TabControl();
            this.ContextMenuStrip_Tabs.SuspendLayout();
            this.TabControl_AudioArgSettings.SuspendLayout();
            this.TabControl_VideoArgSettings.SuspendLayout();
            this.tabPage_Audio.SuspendLayout();
            this.tabPage_Video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCounter)).BeginInit();
            this.TabControl_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuStrip_Tabs
            // 
            this.ContextMenuStrip_Tabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItem_DeleteTab});
            this.ContextMenuStrip_Tabs.Name = "ContextMenuStrip_Tabs";
            this.ContextMenuStrip_Tabs.Size = new System.Drawing.Size(131, 26);
            // 
            // StripMenuItem_DeleteTab
            // 
            this.StripMenuItem_DeleteTab.Name = "StripMenuItem_DeleteTab";
            this.StripMenuItem_DeleteTab.Size = new System.Drawing.Size(130, 22);
            this.StripMenuItem_DeleteTab.Text = "Delete Tab";
            this.StripMenuItem_DeleteTab.Click += new System.EventHandler(this.StripMenuItem_DeleteTab_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 500000;
            this.toolTip.ShowAlways = true;
            // 
            // checkBoxNoAudio
            // 
            this.checkBoxNoAudio.AutoSize = true;
            this.checkBoxNoAudio.Location = new System.Drawing.Point(11, 135);
            this.checkBoxNoAudio.Name = "checkBoxNoAudio";
            this.checkBoxNoAudio.Size = new System.Drawing.Size(70, 17);
            this.checkBoxNoAudio.TabIndex = 1;
            this.checkBoxNoAudio.Text = "No Audio";
            this.toolTip.SetToolTip(this.checkBoxNoAudio, "Will make your video have no audio.");
            this.checkBoxNoAudio.UseVisualStyleBackColor = true;
            this.checkBoxNoAudio.CheckedChanged += new System.EventHandler(this.checkBoxNoAudio_CheckedChanged);
            // 
            // TabControl_AudioArgSettings
            // 
            this.TabControl_AudioArgSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_AudioArgSettings.Controls.Add(this.tabPage5);
            this.TabControl_AudioArgSettings.Location = new System.Drawing.Point(7, 7);
            this.TabControl_AudioArgSettings.Name = "TabControl_AudioArgSettings";
            this.TabControl_AudioArgSettings.SelectedIndex = 0;
            this.TabControl_AudioArgSettings.Size = new System.Drawing.Size(423, 121);
            this.TabControl_AudioArgSettings.TabIndex = 0;
            this.toolTip.SetToolTip(this.TabControl_AudioArgSettings, "Add tabs for your video to have more audio tracks.");
            this.TabControl_AudioArgSettings.SelectedIndexChanged += new System.EventHandler(this.TabControl_AudioArgSettings_SelectedIndexChanged);
            this.TabControl_AudioArgSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabControl_AVSettings_MouseClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(415, 95);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "    +";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // comboBoxCounter
            // 
            this.comboBoxCounter.FormattingEnabled = true;
            this.comboBoxCounter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxCounter.Location = new System.Drawing.Point(6, 372);
            this.comboBoxCounter.Name = "comboBoxCounter";
            this.comboBoxCounter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCounter.TabIndex = 12;
            this.toolTip.SetToolTip(this.comboBoxCounter, "Use {0}, {0:D1}, {0:D2}, etc. in your filename for it to have a counter.");
            this.comboBoxCounter.SelectedIndexChanged += new System.EventHandler(this.comboBoxCounter_SelectedIndexChanged);
            // 
            // TabControl_VideoArgSettings
            // 
            this.TabControl_VideoArgSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_VideoArgSettings.Controls.Add(this.tabPage2);
            this.TabControl_VideoArgSettings.Location = new System.Drawing.Point(7, 7);
            this.TabControl_VideoArgSettings.Name = "TabControl_VideoArgSettings";
            this.TabControl_VideoArgSettings.SelectedIndex = 0;
            this.TabControl_VideoArgSettings.Size = new System.Drawing.Size(427, 266);
            this.TabControl_VideoArgSettings.TabIndex = 2;
            this.toolTip.SetToolTip(this.TabControl_VideoArgSettings, "Add tabs to encode a video with the same input, but with different settings.");
            this.TabControl_VideoArgSettings.SelectedIndexChanged += new System.EventHandler(this.TabControl_VideoArgSettings_TabIndexChanged);
            this.TabControl_VideoArgSettings.TabIndexChanged += new System.EventHandler(this.TabControl_VideoArgSettings_TabIndexChanged);
            this.TabControl_VideoArgSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabControl_AVSettings_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "    +";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage_Audio
            // 
            this.tabPage_Audio.Controls.Add(this.checkBoxNoAudio);
            this.tabPage_Audio.Controls.Add(this.TabControl_AudioArgSettings);
            this.tabPage_Audio.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Audio.Name = "tabPage_Audio";
            this.tabPage_Audio.Size = new System.Drawing.Size(440, 407);
            this.tabPage_Audio.TabIndex = 2;
            this.tabPage_Audio.Text = "Audio";
            this.tabPage_Audio.UseVisualStyleBackColor = true;
            // 
            // tabPage_Video
            // 
            this.tabPage_Video.Controls.Add(this.textBoxBody);
            this.tabPage_Video.Controls.Add(this.labelBody);
            this.tabPage_Video.Controls.Add(this.numericUpDownCounter);
            this.tabPage_Video.Controls.Add(this.label2);
            this.tabPage_Video.Controls.Add(this.comboBoxCounter);
            this.tabPage_Video.Controls.Add(this.label3);
            this.tabPage_Video.Controls.Add(this.TextBox_VideoLanguageCode);
            this.tabPage_Video.Controls.Add(this.TextBox_VideoTrackName);
            this.tabPage_Video.Controls.Add(this.label_videoLanguageCode);
            this.tabPage_Video.Controls.Add(this.Label_VideoTrackName);
            this.tabPage_Video.Controls.Add(this.TabControl_VideoArgSettings);
            this.tabPage_Video.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Video.Name = "tabPage_Video";
            this.tabPage_Video.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Video.Size = new System.Drawing.Size(440, 407);
            this.tabPage_Video.TabIndex = 0;
            this.tabPage_Video.Text = "Video";
            this.tabPage_Video.UseVisualStyleBackColor = true;
            // 
            // textBoxBody
            // 
            this.textBoxBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBody.Location = new System.Drawing.Point(6, 292);
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(428, 20);
            this.textBoxBody.TabIndex = 16;
            this.textBoxBody.TextChanged += new System.EventHandler(this.textBoxBody_TextChanged);
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(6, 276);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(76, 13);
            this.labelBody.TabIndex = 15;
            this.labelBody.Text = "Filename Body";
            // 
            // numericUpDownCounter
            // 
            this.numericUpDownCounter.Location = new System.Drawing.Point(135, 372);
            this.numericUpDownCounter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCounter.Name = "numericUpDownCounter";
            this.numericUpDownCounter.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCounter.TabIndex = 14;
            this.numericUpDownCounter.ValueChanged += new System.EventHandler(this.numericUpDownCounter_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Counter Start Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Counter";
            // 
            // TextBox_VideoLanguageCode
            // 
            this.TextBox_VideoLanguageCode.Location = new System.Drawing.Point(181, 331);
            this.TextBox_VideoLanguageCode.Name = "TextBox_VideoLanguageCode";
            this.TextBox_VideoLanguageCode.Size = new System.Drawing.Size(180, 20);
            this.TextBox_VideoLanguageCode.TabIndex = 6;
            this.toolTip.SetToolTip(this.TextBox_VideoLanguageCode, "ISO 639-2 language code");
            this.TextBox_VideoLanguageCode.TextChanged += new System.EventHandler(this.TextBox_VideoLanguageCode_TextChanged);
            // 
            // TextBox_VideoTrackName
            // 
            this.TextBox_VideoTrackName.Location = new System.Drawing.Point(6, 331);
            this.TextBox_VideoTrackName.Name = "TextBox_VideoTrackName";
            this.TextBox_VideoTrackName.Size = new System.Drawing.Size(169, 20);
            this.TextBox_VideoTrackName.TabIndex = 4;
            this.TextBox_VideoTrackName.TextChanged += new System.EventHandler(this.TextBox_VideoTrackName_TextChanged);
            // 
            // label_videoLanguageCode
            // 
            this.label_videoLanguageCode.AutoSize = true;
            this.label_videoLanguageCode.Location = new System.Drawing.Point(178, 315);
            this.label_videoLanguageCode.Name = "label_videoLanguageCode";
            this.label_videoLanguageCode.Size = new System.Drawing.Size(144, 13);
            this.label_videoLanguageCode.TabIndex = 5;
            this.label_videoLanguageCode.Text = "Video Track Language Code";
            // 
            // Label_VideoTrackName
            // 
            this.Label_VideoTrackName.AutoSize = true;
            this.Label_VideoTrackName.Location = new System.Drawing.Point(6, 315);
            this.Label_VideoTrackName.Name = "Label_VideoTrackName";
            this.Label_VideoTrackName.Size = new System.Drawing.Size(96, 13);
            this.Label_VideoTrackName.TabIndex = 3;
            this.Label_VideoTrackName.Text = "Video Track Name";
            // 
            // TabControl_Settings
            // 
            this.TabControl_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Settings.Controls.Add(this.tabPage_Video);
            this.TabControl_Settings.Controls.Add(this.tabPage_Audio);
            this.TabControl_Settings.Location = new System.Drawing.Point(0, 3);
            this.TabControl_Settings.Name = "TabControl_Settings";
            this.TabControl_Settings.SelectedIndex = 0;
            this.TabControl_Settings.Size = new System.Drawing.Size(448, 433);
            this.TabControl_Settings.TabIndex = 1;
            // 
            // SettingsTabCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl_Settings);
            this.Name = "SettingsTabCollection";
            this.Size = new System.Drawing.Size(448, 435);
            this.ContextMenuStrip_Tabs.ResumeLayout(false);
            this.TabControl_AudioArgSettings.ResumeLayout(false);
            this.TabControl_VideoArgSettings.ResumeLayout(false);
            this.tabPage_Audio.ResumeLayout(false);
            this.tabPage_Audio.PerformLayout();
            this.tabPage_Video.ResumeLayout(false);
            this.tabPage_Video.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCounter)).EndInit();
            this.TabControl_Settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Tabs;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_DeleteTab;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tabPage_Audio;
        private System.Windows.Forms.TabControl TabControl_AudioArgSettings;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage_Video;
        private System.Windows.Forms.NumericUpDown numericUpDownCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_VideoLanguageCode;
        private System.Windows.Forms.TextBox TextBox_VideoTrackName;
        private System.Windows.Forms.Label label_videoLanguageCode;
        private System.Windows.Forms.Label Label_VideoTrackName;
        private System.Windows.Forms.TabControl TabControl_VideoArgSettings;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl TabControl_Settings;
        private System.Windows.Forms.CheckBox checkBoxNoAudio;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Label labelBody;


    }
}
