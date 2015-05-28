/*Batch Encoder Helper
Copyright (C) 2015 Thomas Sweeney

This file is part of Batch Encoder Helper.
Batch Encoder Helper is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Batch Encoder Helper is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
 
You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.*/

namespace Encoder_Helper_GUI
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ContextMenuStrip_Tabs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuItem_DeleteTab = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipCounter = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage_Audio = new System.Windows.Forms.TabPage();
            this.TabControl_AudioArgSettings = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage_Video = new System.Windows.Forms.TabPage();
            this.numericUpDownCounter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCounter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_BrowseAvisynthTemplate = new System.Windows.Forms.Button();
            this.textBox_AvisynthTemplate = new System.Windows.Forms.TextBox();
            this.TextBox_VideoLanguageCode = new System.Windows.Forms.TextBox();
            this.TextBox_VideoTrackName = new System.Windows.Forms.TextBox();
            this.label_AvisynthTemplate = new System.Windows.Forms.Label();
            this.label_videoLanguageCode = new System.Windows.Forms.Label();
            this.Label_VideoTrackName = new System.Windows.Forms.Label();
            this.TabControl_VideoArgSettings = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabControl_Settings = new System.Windows.Forms.TabControl();
            this.ContextMenuStrip_Tabs.SuspendLayout();
            this.tabPage_Audio.SuspendLayout();
            this.TabControl_AudioArgSettings.SuspendLayout();
            this.tabPage_Video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCounter)).BeginInit();
            this.TabControl_VideoArgSettings.SuspendLayout();
            this.TabControl_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
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
            // toolTipCounter
            // 
            this.toolTipCounter.AutomaticDelay = 500000;
            this.toolTipCounter.ShowAlways = true;
            // 
            // tabPage_Audio
            // 
            this.tabPage_Audio.Controls.Add(this.TabControl_AudioArgSettings);
            this.tabPage_Audio.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Audio.Name = "tabPage_Audio";
            this.tabPage_Audio.Size = new System.Drawing.Size(440, 374);
            this.tabPage_Audio.TabIndex = 2;
            this.tabPage_Audio.Text = "Audio";
            this.tabPage_Audio.UseVisualStyleBackColor = true;
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
            // tabPage_Video
            // 
            this.tabPage_Video.Controls.Add(this.numericUpDownCounter);
            this.tabPage_Video.Controls.Add(this.label2);
            this.tabPage_Video.Controls.Add(this.comboBoxCounter);
            this.tabPage_Video.Controls.Add(this.label3);
            this.tabPage_Video.Controls.Add(this.button_BrowseAvisynthTemplate);
            this.tabPage_Video.Controls.Add(this.textBox_AvisynthTemplate);
            this.tabPage_Video.Controls.Add(this.TextBox_VideoLanguageCode);
            this.tabPage_Video.Controls.Add(this.TextBox_VideoTrackName);
            this.tabPage_Video.Controls.Add(this.label_AvisynthTemplate);
            this.tabPage_Video.Controls.Add(this.label_videoLanguageCode);
            this.tabPage_Video.Controls.Add(this.Label_VideoTrackName);
            this.tabPage_Video.Controls.Add(this.TabControl_VideoArgSettings);
            this.tabPage_Video.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Video.Name = "tabPage_Video";
            this.tabPage_Video.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Video.Size = new System.Drawing.Size(440, 374);
            this.tabPage_Video.TabIndex = 0;
            this.tabPage_Video.Text = "Video";
            this.tabPage_Video.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCounter
            // 
            this.numericUpDownCounter.Location = new System.Drawing.Point(133, 331);
            this.numericUpDownCounter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCounter.Name = "numericUpDownCounter";
            this.numericUpDownCounter.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCounter.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Counter Start Position";
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
            this.comboBoxCounter.Location = new System.Drawing.Point(6, 330);
            this.comboBoxCounter.Name = "comboBoxCounter";
            this.comboBoxCounter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCounter.TabIndex = 12;
            this.comboBoxCounter.SelectedIndexChanged += new System.EventHandler(this.comboBoxCounter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Counter";
            // 
            // button_BrowseAvisynthTemplate
            // 
            this.button_BrowseAvisynthTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_BrowseAvisynthTemplate.Location = new System.Drawing.Point(350, 287);
            this.button_BrowseAvisynthTemplate.Name = "button_BrowseAvisynthTemplate";
            this.button_BrowseAvisynthTemplate.Size = new System.Drawing.Size(75, 23);
            this.button_BrowseAvisynthTemplate.TabIndex = 9;
            this.button_BrowseAvisynthTemplate.Text = "Browse";
            this.button_BrowseAvisynthTemplate.UseVisualStyleBackColor = true;
            this.button_BrowseAvisynthTemplate.Click += new System.EventHandler(this.button_BrowseAvisynthTemplate_Click);
            // 
            // textBox_AvisynthTemplate
            // 
            this.textBox_AvisynthTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_AvisynthTemplate.Location = new System.Drawing.Point(6, 290);
            this.textBox_AvisynthTemplate.Name = "textBox_AvisynthTemplate";
            this.textBox_AvisynthTemplate.Size = new System.Drawing.Size(338, 20);
            this.textBox_AvisynthTemplate.TabIndex = 8;
            // 
            // TextBox_VideoLanguageCode
            // 
            this.TextBox_VideoLanguageCode.Location = new System.Drawing.Point(205, 246);
            this.TextBox_VideoLanguageCode.Name = "TextBox_VideoLanguageCode";
            this.TextBox_VideoLanguageCode.Size = new System.Drawing.Size(180, 20);
            this.TextBox_VideoLanguageCode.TabIndex = 6;
            // 
            // TextBox_VideoTrackName
            // 
            this.TextBox_VideoTrackName.Location = new System.Drawing.Point(6, 246);
            this.TextBox_VideoTrackName.Name = "TextBox_VideoTrackName";
            this.TextBox_VideoTrackName.Size = new System.Drawing.Size(169, 20);
            this.TextBox_VideoTrackName.TabIndex = 4;
            // 
            // label_AvisynthTemplate
            // 
            this.label_AvisynthTemplate.AutoSize = true;
            this.label_AvisynthTemplate.Location = new System.Drawing.Point(6, 273);
            this.label_AvisynthTemplate.Name = "label_AvisynthTemplate";
            this.label_AvisynthTemplate.Size = new System.Drawing.Size(94, 13);
            this.label_AvisynthTemplate.TabIndex = 7;
            this.label_AvisynthTemplate.Text = "Avisynth Template";
            // 
            // label_videoLanguageCode
            // 
            this.label_videoLanguageCode.AutoSize = true;
            this.label_videoLanguageCode.Location = new System.Drawing.Point(202, 230);
            this.label_videoLanguageCode.Name = "label_videoLanguageCode";
            this.label_videoLanguageCode.Size = new System.Drawing.Size(144, 13);
            this.label_videoLanguageCode.TabIndex = 5;
            this.label_videoLanguageCode.Text = "Video Track Language Code";
            // 
            // Label_VideoTrackName
            // 
            this.Label_VideoTrackName.AutoSize = true;
            this.Label_VideoTrackName.Location = new System.Drawing.Point(6, 230);
            this.Label_VideoTrackName.Name = "Label_VideoTrackName";
            this.Label_VideoTrackName.Size = new System.Drawing.Size(96, 13);
            this.Label_VideoTrackName.TabIndex = 3;
            this.Label_VideoTrackName.Text = "Video Track Name";
            // 
            // TabControl_VideoArgSettings
            // 
            this.TabControl_VideoArgSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_VideoArgSettings.Controls.Add(this.tabPage2);
            this.TabControl_VideoArgSettings.Location = new System.Drawing.Point(7, 7);
            this.TabControl_VideoArgSettings.Name = "TabControl_VideoArgSettings";
            this.TabControl_VideoArgSettings.SelectedIndex = 0;
            this.TabControl_VideoArgSettings.Size = new System.Drawing.Size(427, 216);
            this.TabControl_VideoArgSettings.TabIndex = 2;
            this.TabControl_VideoArgSettings.SelectedIndexChanged += new System.EventHandler(this.TabControl_VideoArgSettings_TabIndexChanged);
            this.TabControl_VideoArgSettings.TabIndexChanged += new System.EventHandler(this.TabControl_VideoArgSettings_TabIndexChanged);
            this.TabControl_VideoArgSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabControl_AVSettings_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 190);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "    +";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.TabControl_Settings.Size = new System.Drawing.Size(448, 400);
            this.TabControl_Settings.TabIndex = 1;
            // 
            // SettingsTabCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl_Settings);
            this.Name = "SettingsTabCollection";
            this.Size = new System.Drawing.Size(448, 402);
            this.ContextMenuStrip_Tabs.ResumeLayout(false);
            this.tabPage_Audio.ResumeLayout(false);
            this.TabControl_AudioArgSettings.ResumeLayout(false);
            this.tabPage_Video.ResumeLayout(false);
            this.tabPage_Video.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCounter)).EndInit();
            this.TabControl_VideoArgSettings.ResumeLayout(false);
            this.TabControl_Settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Tabs;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_DeleteTab;
        private System.Windows.Forms.ToolTip toolTipCounter;
        private System.Windows.Forms.TabPage tabPage_Audio;
        private System.Windows.Forms.TabControl TabControl_AudioArgSettings;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage_Video;
        private System.Windows.Forms.NumericUpDown numericUpDownCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_BrowseAvisynthTemplate;
        private System.Windows.Forms.TextBox textBox_AvisynthTemplate;
        private System.Windows.Forms.TextBox TextBox_VideoLanguageCode;
        private System.Windows.Forms.TextBox TextBox_VideoTrackName;
        private System.Windows.Forms.Label label_AvisynthTemplate;
        private System.Windows.Forms.Label label_videoLanguageCode;
        private System.Windows.Forms.Label Label_VideoTrackName;
        private System.Windows.Forms.TabControl TabControl_VideoArgSettings;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl TabControl_Settings;


    }
}
