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
    partial class VideoTabControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoTabControl));
            this.panelVideoTab = new System.Windows.Forms.Panel();
            this.button_BrowseAvisynthTemplate = new System.Windows.Forms.Button();
            this.textBox_AvisynthTemplate = new System.Windows.Forms.TextBox();
            this.label_AvisynthTemplate = new System.Windows.Forms.Label();
            this.splitContainerPrefixSuffix = new System.Windows.Forms.SplitContainer();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.textBoxSuffix = new System.Windows.Forms.TextBox();
            this.labelSuffix = new System.Windows.Forms.Label();
            this.Label_Encoder = new System.Windows.Forms.Label();
            this.ComboBox_Encoder = new System.Windows.Forms.ComboBox();
            this.Label_x264_Args = new System.Windows.Forms.Label();
            this.TextBox_x264_Args = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelVideoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrefixSuffix)).BeginInit();
            this.splitContainerPrefixSuffix.Panel1.SuspendLayout();
            this.splitContainerPrefixSuffix.Panel2.SuspendLayout();
            this.splitContainerPrefixSuffix.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVideoTab
            // 
            this.panelVideoTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVideoTab.Controls.Add(this.button_BrowseAvisynthTemplate);
            this.panelVideoTab.Controls.Add(this.textBox_AvisynthTemplate);
            this.panelVideoTab.Controls.Add(this.label_AvisynthTemplate);
            this.panelVideoTab.Controls.Add(this.splitContainerPrefixSuffix);
            this.panelVideoTab.Controls.Add(this.Label_Encoder);
            this.panelVideoTab.Controls.Add(this.ComboBox_Encoder);
            this.panelVideoTab.Controls.Add(this.Label_x264_Args);
            this.panelVideoTab.Controls.Add(this.TextBox_x264_Args);
            this.panelVideoTab.Location = new System.Drawing.Point(0, 0);
            this.panelVideoTab.Name = "panelVideoTab";
            this.panelVideoTab.Size = new System.Drawing.Size(408, 247);
            this.panelVideoTab.TabIndex = 0;
            // 
            // button_BrowseAvisynthTemplate
            // 
            this.button_BrowseAvisynthTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_BrowseAvisynthTemplate.Location = new System.Drawing.Point(329, 207);
            this.button_BrowseAvisynthTemplate.Name = "button_BrowseAvisynthTemplate";
            this.button_BrowseAvisynthTemplate.Size = new System.Drawing.Size(75, 23);
            this.button_BrowseAvisynthTemplate.TabIndex = 24;
            this.button_BrowseAvisynthTemplate.Text = "Browse";
            this.button_BrowseAvisynthTemplate.UseVisualStyleBackColor = true;
            this.button_BrowseAvisynthTemplate.Click += new System.EventHandler(this.button_BrowseAvisynthTemplate_Click);
            // 
            // textBox_AvisynthTemplate
            // 
            this.textBox_AvisynthTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_AvisynthTemplate.Location = new System.Drawing.Point(7, 209);
            this.textBox_AvisynthTemplate.Name = "textBox_AvisynthTemplate";
            this.textBox_AvisynthTemplate.Size = new System.Drawing.Size(316, 20);
            this.textBox_AvisynthTemplate.TabIndex = 23;
            this.toolTip.SetToolTip(this.textBox_AvisynthTemplate, resources.GetString("textBox_AvisynthTemplate.ToolTip"));
            this.textBox_AvisynthTemplate.TextChanged += new System.EventHandler(this.textBoxSuffix_TextChanged);
            // 
            // label_AvisynthTemplate
            // 
            this.label_AvisynthTemplate.AutoSize = true;
            this.label_AvisynthTemplate.Location = new System.Drawing.Point(7, 190);
            this.label_AvisynthTemplate.Name = "label_AvisynthTemplate";
            this.label_AvisynthTemplate.Size = new System.Drawing.Size(94, 13);
            this.label_AvisynthTemplate.TabIndex = 22;
            this.label_AvisynthTemplate.Text = "Avisynth Template";
            // 
            // splitContainerPrefixSuffix
            // 
            this.splitContainerPrefixSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerPrefixSuffix.Location = new System.Drawing.Point(4, 144);
            this.splitContainerPrefixSuffix.Name = "splitContainerPrefixSuffix";
            // 
            // splitContainerPrefixSuffix.Panel1
            // 
            this.splitContainerPrefixSuffix.Panel1.Controls.Add(this.textBoxPrefix);
            this.splitContainerPrefixSuffix.Panel1.Controls.Add(this.labelPrefix);
            // 
            // splitContainerPrefixSuffix.Panel2
            // 
            this.splitContainerPrefixSuffix.Panel2.Controls.Add(this.textBoxSuffix);
            this.splitContainerPrefixSuffix.Panel2.Controls.Add(this.labelSuffix);
            this.splitContainerPrefixSuffix.Size = new System.Drawing.Size(404, 42);
            this.splitContainerPrefixSuffix.SplitterDistance = 200;
            this.splitContainerPrefixSuffix.TabIndex = 21;
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrefix.Location = new System.Drawing.Point(3, 19);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(194, 20);
            this.textBoxPrefix.TabIndex = 19;
            this.textBoxPrefix.TextChanged += new System.EventHandler(this.textBoxPrefix_TextChanged);
            // 
            // labelPrefix
            // 
            this.labelPrefix.AutoSize = true;
            this.labelPrefix.Location = new System.Drawing.Point(3, 3);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(113, 13);
            this.labelPrefix.TabIndex = 18;
            this.labelPrefix.Text = "Output Filename Prefix";
            // 
            // textBoxSuffix
            // 
            this.textBoxSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSuffix.Location = new System.Drawing.Point(3, 19);
            this.textBoxSuffix.Name = "textBoxSuffix";
            this.textBoxSuffix.Size = new System.Drawing.Size(193, 20);
            this.textBoxSuffix.TabIndex = 15;
            this.textBoxSuffix.TextChanged += new System.EventHandler(this.textBoxSuffix_TextChanged);
            // 
            // labelSuffix
            // 
            this.labelSuffix.AutoSize = true;
            this.labelSuffix.Location = new System.Drawing.Point(3, 3);
            this.labelSuffix.Name = "labelSuffix";
            this.labelSuffix.Size = new System.Drawing.Size(113, 13);
            this.labelSuffix.TabIndex = 13;
            this.labelSuffix.Text = "Output Filename Suffix";
            // 
            // Label_Encoder
            // 
            this.Label_Encoder.AutoSize = true;
            this.Label_Encoder.Location = new System.Drawing.Point(4, 102);
            this.Label_Encoder.Name = "Label_Encoder";
            this.Label_Encoder.Size = new System.Drawing.Size(47, 13);
            this.Label_Encoder.TabIndex = 17;
            this.Label_Encoder.Text = "Encoder";
            // 
            // ComboBox_Encoder
            // 
            this.ComboBox_Encoder.FormattingEnabled = true;
            this.ComboBox_Encoder.Items.AddRange(new object[] {
            "x264 x86 8bit",
            "x264 x86 10bit",
            "x264 x64 8bit",
            "x264 x64 10bit"});
            this.ComboBox_Encoder.Location = new System.Drawing.Point(7, 118);
            this.ComboBox_Encoder.Name = "ComboBox_Encoder";
            this.ComboBox_Encoder.Size = new System.Drawing.Size(157, 21);
            this.ComboBox_Encoder.TabIndex = 16;
            this.ComboBox_Encoder.Text = "Select Encoder";
            this.ComboBox_Encoder.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Encoder_SelectedIndexChanged);
            // 
            // Label_x264_Args
            // 
            this.Label_x264_Args.AutoSize = true;
            this.Label_x264_Args.Location = new System.Drawing.Point(4, 6);
            this.Label_x264_Args.Name = "Label_x264_Args";
            this.Label_x264_Args.Size = new System.Drawing.Size(83, 13);
            this.Label_x264_Args.TabIndex = 12;
            this.Label_x264_Args.Text = "x264 Arguments";
            // 
            // TextBox_x264_Args
            // 
            this.TextBox_x264_Args.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_x264_Args.Location = new System.Drawing.Point(7, 22);
            this.TextBox_x264_Args.Multiline = true;
            this.TextBox_x264_Args.Name = "TextBox_x264_Args";
            this.TextBox_x264_Args.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_x264_Args.Size = new System.Drawing.Size(397, 77);
            this.TextBox_x264_Args.TabIndex = 14;
            this.toolTip.SetToolTip(this.TextBox_x264_Args, "Arguments to give to x264.\r\nDon\'t give the output or input file as arguments.\r\nTh" +
        "is is done automatically for you.");
            this.TextBox_x264_Args.TextChanged += new System.EventHandler(this.TextBox_x264_Args_TextChanged);
            this.TextBox_x264_Args.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_x264_Args_KeyDown);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // VideoTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelVideoTab);
            this.Name = "VideoTabControl";
            this.Size = new System.Drawing.Size(408, 247);
            this.panelVideoTab.ResumeLayout(false);
            this.panelVideoTab.PerformLayout();
            this.splitContainerPrefixSuffix.Panel1.ResumeLayout(false);
            this.splitContainerPrefixSuffix.Panel1.PerformLayout();
            this.splitContainerPrefixSuffix.Panel2.ResumeLayout(false);
            this.splitContainerPrefixSuffix.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrefixSuffix)).EndInit();
            this.splitContainerPrefixSuffix.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVideoTab;
        private System.Windows.Forms.Label Label_Encoder;
        private System.Windows.Forms.ComboBox ComboBox_Encoder;
        private System.Windows.Forms.Label Label_x264_Args;
        private System.Windows.Forms.TextBox TextBox_x264_Args;
        private System.Windows.Forms.SplitContainer splitContainerPrefixSuffix;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.TextBox textBoxSuffix;
        private System.Windows.Forms.Label labelSuffix;
        private System.Windows.Forms.Button button_BrowseAvisynthTemplate;
        private System.Windows.Forms.TextBox textBox_AvisynthTemplate;
        private System.Windows.Forms.Label label_AvisynthTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip;

    }
}
