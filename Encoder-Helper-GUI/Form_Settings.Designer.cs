namespace Encoder_Helper_GUI
{
    partial class Form_Settings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabControl_Settings = new System.Windows.Forms.TabControl();
            this.TabControl_Settings_Video = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Label_VideoTrackName = new System.Windows.Forms.Label();
            this.TabControl_VideoArgSettings = new System.Windows.Forms.TabControl();
            this.TabPage_VideoSettingsTemplate = new System.Windows.Forms.TabPage();
            this.Label_Encoder = new System.Windows.Forms.Label();
            this.ComboBox_Encoder = new System.Windows.Forms.ComboBox();
            this.Label_x264_Args = new System.Windows.Forms.Label();
            this.TextBox_x264_Args = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TabControl_AudioArgSettings = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TextBox_LanguageCode = new System.Windows.Forms.TextBox();
            this.Label_LanguageCode = new System.Windows.Forms.Label();
            this.TextBox_AudioTrackName = new System.Windows.Forms.TextBox();
            this.Label_AudioTrackName = new System.Windows.Forms.Label();
            this.NumericUpDown_Quality = new System.Windows.Forms.NumericUpDown();
            this.Label_AudioQuality = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.TabControl_Settings_Locations = new System.Windows.Forms.TabPage();
            this.Button_Browse_BePipe = new System.Windows.Forms.Button();
            this.TextBox_BePipe = new System.Windows.Forms.TextBox();
            this.Label_BePipe = new System.Windows.Forms.Label();
            this.Button_Browse_NeroAAC = new System.Windows.Forms.Button();
            this.TextBox_NeroAAC = new System.Windows.Forms.TextBox();
            this.Label_NeroAAC = new System.Windows.Forms.Label();
            this.Button_Browse_MKVMerge = new System.Windows.Forms.Button();
            this.TextBox_MKVMerge = new System.Windows.Forms.TextBox();
            this.Label_MKVMergeLocation = new System.Windows.Forms.Label();
            this.Button_Browse_x264_x64_10bit = new System.Windows.Forms.Button();
            this.TextBox_x264_x64_10bit = new System.Windows.Forms.TextBox();
            this.Label_x264_x64_10bit_Location = new System.Windows.Forms.Label();
            this.Button_Browse_x264_x64_8bit = new System.Windows.Forms.Button();
            this.TextBox_x264_x64_8bit = new System.Windows.Forms.TextBox();
            this.Label_x264_x64_8bit_Location = new System.Windows.Forms.Label();
            this.Button_Browse_x264_x86_10bit = new System.Windows.Forms.Button();
            this.TextBox_x264_x86_10bit = new System.Windows.Forms.TextBox();
            this.Label_x264_x86_10bit_Location = new System.Windows.Forms.Label();
            this.Button_Browse_x264_x86_8bit = new System.Windows.Forms.Button();
            this.TextBox_x264_x86_8bit = new System.Windows.Forms.TextBox();
            this.Label_x264_x86_8bit_Location = new System.Windows.Forms.Label();
            this.OpenFileDialog_Settings = new System.Windows.Forms.OpenFileDialog();
            this.Button_Cancel_Settings = new System.Windows.Forms.Button();
            this.Button_OK_Settings = new System.Windows.Forms.Button();
            this.ContextMenuStrip_Tabs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuItem_DeleteTab = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl_Settings.SuspendLayout();
            this.TabControl_Settings_Video.SuspendLayout();
            this.TabControl_VideoArgSettings.SuspendLayout();
            this.TabPage_VideoSettingsTemplate.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.TabControl_AudioArgSettings.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Quality)).BeginInit();
            this.TabControl_Settings_Locations.SuspendLayout();
            this.ContextMenuStrip_Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Settings
            // 
            this.TabControl_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Settings.Controls.Add(this.TabControl_Settings_Video);
            this.TabControl_Settings.Controls.Add(this.tabPage3);
            this.TabControl_Settings.Controls.Add(this.TabControl_Settings_Locations);
            this.TabControl_Settings.Location = new System.Drawing.Point(13, 13);
            this.TabControl_Settings.Name = "TabControl_Settings";
            this.TabControl_Settings.SelectedIndex = 0;
            this.TabControl_Settings.Size = new System.Drawing.Size(441, 347);
            this.TabControl_Settings.TabIndex = 0;
            // 
            // TabControl_Settings_Video
            // 
            this.TabControl_Settings_Video.Controls.Add(this.textBox3);
            this.TabControl_Settings_Video.Controls.Add(this.label1);
            this.TabControl_Settings_Video.Controls.Add(this.textBox2);
            this.TabControl_Settings_Video.Controls.Add(this.Label_VideoTrackName);
            this.TabControl_Settings_Video.Controls.Add(this.TabControl_VideoArgSettings);
            this.TabControl_Settings_Video.Location = new System.Drawing.Point(4, 22);
            this.TabControl_Settings_Video.Name = "TabControl_Settings_Video";
            this.TabControl_Settings_Video.Padding = new System.Windows.Forms.Padding(3);
            this.TabControl_Settings_Video.Size = new System.Drawing.Size(433, 321);
            this.TabControl_Settings_Video.TabIndex = 0;
            this.TabControl_Settings_Video.Text = "Video Defaults";
            this.TabControl_Settings_Video.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Video Track Language Code";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Label_VideoTrackName
            // 
            this.Label_VideoTrackName.AutoSize = true;
            this.Label_VideoTrackName.Location = new System.Drawing.Point(8, 194);
            this.Label_VideoTrackName.Name = "Label_VideoTrackName";
            this.Label_VideoTrackName.Size = new System.Drawing.Size(96, 13);
            this.Label_VideoTrackName.TabIndex = 3;
            this.Label_VideoTrackName.Text = "Video Track Name";
            // 
            // TabControl_VideoArgSettings
            // 
            this.TabControl_VideoArgSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_VideoArgSettings.Controls.Add(this.TabPage_VideoSettingsTemplate);
            this.TabControl_VideoArgSettings.Controls.Add(this.tabPage2);
            this.TabControl_VideoArgSettings.Location = new System.Drawing.Point(7, 7);
            this.TabControl_VideoArgSettings.Name = "TabControl_VideoArgSettings";
            this.TabControl_VideoArgSettings.SelectedIndex = 0;
            this.TabControl_VideoArgSettings.Size = new System.Drawing.Size(420, 175);
            this.TabControl_VideoArgSettings.TabIndex = 2;
            this.TabControl_VideoArgSettings.SelectedIndexChanged += new System.EventHandler(this.TabControl_AVSettings_SelectedIndexChanged);
            this.TabControl_VideoArgSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabControl_AVSettings_MouseClick);
            // 
            // TabPage_VideoSettingsTemplate
            // 
            this.TabPage_VideoSettingsTemplate.Controls.Add(this.Label_Encoder);
            this.TabPage_VideoSettingsTemplate.Controls.Add(this.ComboBox_Encoder);
            this.TabPage_VideoSettingsTemplate.Controls.Add(this.Label_x264_Args);
            this.TabPage_VideoSettingsTemplate.Controls.Add(this.TextBox_x264_Args);
            this.TabPage_VideoSettingsTemplate.Location = new System.Drawing.Point(4, 22);
            this.TabPage_VideoSettingsTemplate.Name = "TabPage_VideoSettingsTemplate";
            this.TabPage_VideoSettingsTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_VideoSettingsTemplate.Size = new System.Drawing.Size(412, 149);
            this.TabPage_VideoSettingsTemplate.TabIndex = 0;
            this.TabPage_VideoSettingsTemplate.Text = "1";
            this.TabPage_VideoSettingsTemplate.UseVisualStyleBackColor = true;
            // 
            // Label_Encoder
            // 
            this.Label_Encoder.AutoSize = true;
            this.Label_Encoder.Location = new System.Drawing.Point(6, 100);
            this.Label_Encoder.Name = "Label_Encoder";
            this.Label_Encoder.Size = new System.Drawing.Size(47, 13);
            this.Label_Encoder.TabIndex = 3;
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
            this.ComboBox_Encoder.Location = new System.Drawing.Point(9, 116);
            this.ComboBox_Encoder.Name = "ComboBox_Encoder";
            this.ComboBox_Encoder.Size = new System.Drawing.Size(157, 21);
            this.ComboBox_Encoder.TabIndex = 2;
            this.ComboBox_Encoder.Text = "Select Encoder";
            // 
            // Label_x264_Args
            // 
            this.Label_x264_Args.AutoSize = true;
            this.Label_x264_Args.Location = new System.Drawing.Point(6, 3);
            this.Label_x264_Args.Name = "Label_x264_Args";
            this.Label_x264_Args.Size = new System.Drawing.Size(83, 13);
            this.Label_x264_Args.TabIndex = 0;
            this.Label_x264_Args.Text = "x264 Arguments";
            // 
            // TextBox_x264_Args
            // 
            this.TextBox_x264_Args.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_x264_Args.Location = new System.Drawing.Point(9, 20);
            this.TextBox_x264_Args.Multiline = true;
            this.TextBox_x264_Args.Name = "TextBox_x264_Args";
            this.TextBox_x264_Args.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_x264_Args.Size = new System.Drawing.Size(397, 77);
            this.TextBox_x264_Args.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "    +";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TabControl_AudioArgSettings);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(433, 321);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Audio Defaults";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TabControl_AudioArgSettings
            // 
            this.TabControl_AudioArgSettings.Controls.Add(this.tabPage4);
            this.TabControl_AudioArgSettings.Controls.Add(this.tabPage5);
            this.TabControl_AudioArgSettings.Location = new System.Drawing.Point(7, 7);
            this.TabControl_AudioArgSettings.Name = "TabControl_AudioArgSettings";
            this.TabControl_AudioArgSettings.SelectedIndex = 0;
            this.TabControl_AudioArgSettings.Size = new System.Drawing.Size(420, 121);
            this.TabControl_AudioArgSettings.TabIndex = 0;
            this.TabControl_AudioArgSettings.SelectedIndexChanged += new System.EventHandler(this.TabControl_AVSettings_SelectedIndexChanged);
            this.TabControl_AudioArgSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabControl_AVSettings_MouseClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TextBox_LanguageCode);
            this.tabPage4.Controls.Add(this.Label_LanguageCode);
            this.tabPage4.Controls.Add(this.TextBox_AudioTrackName);
            this.tabPage4.Controls.Add(this.Label_AudioTrackName);
            this.tabPage4.Controls.Add(this.NumericUpDown_Quality);
            this.tabPage4.Controls.Add(this.Label_AudioQuality);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(412, 95);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "1";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TextBox_LanguageCode
            // 
            this.TextBox_LanguageCode.Location = new System.Drawing.Point(205, 60);
            this.TextBox_LanguageCode.Name = "TextBox_LanguageCode";
            this.TextBox_LanguageCode.Size = new System.Drawing.Size(180, 20);
            this.TextBox_LanguageCode.TabIndex = 10;
            // 
            // Label_LanguageCode
            // 
            this.Label_LanguageCode.AutoSize = true;
            this.Label_LanguageCode.Location = new System.Drawing.Point(202, 43);
            this.Label_LanguageCode.Name = "Label_LanguageCode";
            this.Label_LanguageCode.Size = new System.Drawing.Size(144, 13);
            this.Label_LanguageCode.TabIndex = 9;
            this.Label_LanguageCode.Text = "Audio Track Language Code";
            // 
            // TextBox_AudioTrackName
            // 
            this.TextBox_AudioTrackName.Location = new System.Drawing.Point(6, 60);
            this.TextBox_AudioTrackName.Name = "TextBox_AudioTrackName";
            this.TextBox_AudioTrackName.Size = new System.Drawing.Size(169, 20);
            this.TextBox_AudioTrackName.TabIndex = 8;
            // 
            // Label_AudioTrackName
            // 
            this.Label_AudioTrackName.AutoSize = true;
            this.Label_AudioTrackName.Location = new System.Drawing.Point(6, 43);
            this.Label_AudioTrackName.Name = "Label_AudioTrackName";
            this.Label_AudioTrackName.Size = new System.Drawing.Size(96, 13);
            this.Label_AudioTrackName.TabIndex = 7;
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
            this.NumericUpDown_Quality.Location = new System.Drawing.Point(6, 20);
            this.NumericUpDown_Quality.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_Quality.Name = "NumericUpDown_Quality";
            this.NumericUpDown_Quality.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDown_Quality.TabIndex = 1;
            // 
            // Label_AudioQuality
            // 
            this.Label_AudioQuality.AutoSize = true;
            this.Label_AudioQuality.Location = new System.Drawing.Point(3, 3);
            this.Label_AudioQuality.Name = "Label_AudioQuality";
            this.Label_AudioQuality.Size = new System.Drawing.Size(39, 13);
            this.Label_AudioQuality.TabIndex = 0;
            this.Label_AudioQuality.Text = "Quality";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(412, 95);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "    +";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // TabControl_Settings_Locations
            // 
            this.TabControl_Settings_Locations.Controls.Add(this.Button_Browse_BePipe);
            this.TabControl_Settings_Locations.Controls.Add(this.TextBox_BePipe);
            this.TabControl_Settings_Locations.Controls.Add(this.Label_BePipe);
            this.TabControl_Settings_Locations.Controls.Add(this.Button_Browse_NeroAAC);
            this.TabControl_Settings_Locations.Controls.Add(this.TextBox_NeroAAC);
            this.TabControl_Settings_Locations.Controls.Add(this.Label_NeroAAC);
            this.TabControl_Settings_Locations.Controls.Add(this.Button_Browse_MKVMerge);
            this.TabControl_Settings_Locations.Controls.Add(this.TextBox_MKVMerge);
            this.TabControl_Settings_Locations.Controls.Add(this.Label_MKVMergeLocation);
            this.TabControl_Settings_Locations.Controls.Add(this.Button_Browse_x264_x64_10bit);
            this.TabControl_Settings_Locations.Controls.Add(this.TextBox_x264_x64_10bit);
            this.TabControl_Settings_Locations.Controls.Add(this.Label_x264_x64_10bit_Location);
            this.TabControl_Settings_Locations.Controls.Add(this.Button_Browse_x264_x64_8bit);
            this.TabControl_Settings_Locations.Controls.Add(this.TextBox_x264_x64_8bit);
            this.TabControl_Settings_Locations.Controls.Add(this.Label_x264_x64_8bit_Location);
            this.TabControl_Settings_Locations.Controls.Add(this.Button_Browse_x264_x86_10bit);
            this.TabControl_Settings_Locations.Controls.Add(this.TextBox_x264_x86_10bit);
            this.TabControl_Settings_Locations.Controls.Add(this.Label_x264_x86_10bit_Location);
            this.TabControl_Settings_Locations.Controls.Add(this.Button_Browse_x264_x86_8bit);
            this.TabControl_Settings_Locations.Controls.Add(this.TextBox_x264_x86_8bit);
            this.TabControl_Settings_Locations.Controls.Add(this.Label_x264_x86_8bit_Location);
            this.TabControl_Settings_Locations.Location = new System.Drawing.Point(4, 22);
            this.TabControl_Settings_Locations.Name = "TabControl_Settings_Locations";
            this.TabControl_Settings_Locations.Padding = new System.Windows.Forms.Padding(3);
            this.TabControl_Settings_Locations.Size = new System.Drawing.Size(433, 321);
            this.TabControl_Settings_Locations.TabIndex = 1;
            this.TabControl_Settings_Locations.Text = "Locations";
            this.TabControl_Settings_Locations.UseVisualStyleBackColor = true;
            // 
            // Button_Browse_BePipe
            // 
            this.Button_Browse_BePipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Browse_BePipe.Location = new System.Drawing.Point(352, 258);
            this.Button_Browse_BePipe.Name = "Button_Browse_BePipe";
            this.Button_Browse_BePipe.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_BePipe.TabIndex = 20;
            this.Button_Browse_BePipe.Text = "Browse";
            this.Button_Browse_BePipe.UseVisualStyleBackColor = true;
            this.Button_Browse_BePipe.Click += new System.EventHandler(this.Button_Browse_BePipe_Click);
            // 
            // TextBox_BePipe
            // 
            this.TextBox_BePipe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_BePipe.Location = new System.Drawing.Point(10, 261);
            this.TextBox_BePipe.Name = "TextBox_BePipe";
            this.TextBox_BePipe.Size = new System.Drawing.Size(336, 20);
            this.TextBox_BePipe.TabIndex = 19;
            // 
            // Label_BePipe
            // 
            this.Label_BePipe.AutoSize = true;
            this.Label_BePipe.Location = new System.Drawing.Point(7, 244);
            this.Label_BePipe.Name = "Label_BePipe";
            this.Label_BePipe.Size = new System.Drawing.Size(85, 13);
            this.Label_BePipe.TabIndex = 18;
            this.Label_BePipe.Text = "BePipe Location";
            // 
            // Button_Browse_NeroAAC
            // 
            this.Button_Browse_NeroAAC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Browse_NeroAAC.Location = new System.Drawing.Point(352, 218);
            this.Button_Browse_NeroAAC.Name = "Button_Browse_NeroAAC";
            this.Button_Browse_NeroAAC.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_NeroAAC.TabIndex = 17;
            this.Button_Browse_NeroAAC.Text = "Browse";
            this.Button_Browse_NeroAAC.UseVisualStyleBackColor = true;
            this.Button_Browse_NeroAAC.Click += new System.EventHandler(this.Button_Browse_NeroAAC_Click);
            // 
            // TextBox_NeroAAC
            // 
            this.TextBox_NeroAAC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_NeroAAC.Location = new System.Drawing.Point(10, 221);
            this.TextBox_NeroAAC.Name = "TextBox_NeroAAC";
            this.TextBox_NeroAAC.Size = new System.Drawing.Size(336, 20);
            this.TextBox_NeroAAC.TabIndex = 16;
            // 
            // Label_NeroAAC
            // 
            this.Label_NeroAAC.AutoSize = true;
            this.Label_NeroAAC.Location = new System.Drawing.Point(7, 204);
            this.Label_NeroAAC.Name = "Label_NeroAAC";
            this.Label_NeroAAC.Size = new System.Drawing.Size(141, 13);
            this.Label_NeroAAC.TabIndex = 15;
            this.Label_NeroAAC.Text = "Nero AAC Encoder Location";
            // 
            // Button_Browse_MKVMerge
            // 
            this.Button_Browse_MKVMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Browse_MKVMerge.Location = new System.Drawing.Point(352, 178);
            this.Button_Browse_MKVMerge.Name = "Button_Browse_MKVMerge";
            this.Button_Browse_MKVMerge.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_MKVMerge.TabIndex = 14;
            this.Button_Browse_MKVMerge.Text = "Browse";
            this.Button_Browse_MKVMerge.UseVisualStyleBackColor = true;
            this.Button_Browse_MKVMerge.Click += new System.EventHandler(this.Button_Browse_MKVMerge_Click);
            // 
            // TextBox_MKVMerge
            // 
            this.TextBox_MKVMerge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_MKVMerge.Location = new System.Drawing.Point(10, 181);
            this.TextBox_MKVMerge.Name = "TextBox_MKVMerge";
            this.TextBox_MKVMerge.Size = new System.Drawing.Size(336, 20);
            this.TextBox_MKVMerge.TabIndex = 13;
            // 
            // Label_MKVMergeLocation
            // 
            this.Label_MKVMergeLocation.AutoSize = true;
            this.Label_MKVMergeLocation.Location = new System.Drawing.Point(7, 164);
            this.Label_MKVMergeLocation.Name = "Label_MKVMergeLocation";
            this.Label_MKVMergeLocation.Size = new System.Drawing.Size(104, 13);
            this.Label_MKVMergeLocation.TabIndex = 12;
            this.Label_MKVMergeLocation.Text = "MKVMerge Location";
            // 
            // Button_Browse_x264_x64_10bit
            // 
            this.Button_Browse_x264_x64_10bit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Browse_x264_x64_10bit.Location = new System.Drawing.Point(352, 139);
            this.Button_Browse_x264_x64_10bit.Name = "Button_Browse_x264_x64_10bit";
            this.Button_Browse_x264_x64_10bit.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_x264_x64_10bit.TabIndex = 11;
            this.Button_Browse_x264_x64_10bit.Text = "Browse";
            this.Button_Browse_x264_x64_10bit.UseVisualStyleBackColor = true;
            this.Button_Browse_x264_x64_10bit.Click += new System.EventHandler(this.Button_Browse_x264_x64_10bit_Click);
            // 
            // TextBox_x264_x64_10bit
            // 
            this.TextBox_x264_x64_10bit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_x264_x64_10bit.Location = new System.Drawing.Point(10, 141);
            this.TextBox_x264_x64_10bit.Name = "TextBox_x264_x64_10bit";
            this.TextBox_x264_x64_10bit.Size = new System.Drawing.Size(336, 20);
            this.TextBox_x264_x64_10bit.TabIndex = 10;
            // 
            // Label_x264_x64_10bit_Location
            // 
            this.Label_x264_x64_10bit_Location.AutoSize = true;
            this.Label_x264_x64_10bit_Location.Location = new System.Drawing.Point(7, 125);
            this.Label_x264_x64_10bit_Location.Name = "Label_x264_x64_10bit_Location";
            this.Label_x264_x64_10bit_Location.Size = new System.Drawing.Size(120, 13);
            this.Label_x264_x64_10bit_Location.TabIndex = 9;
            this.Label_x264_x64_10bit_Location.Text = "x264 x64 10bit Location";
            // 
            // Button_Browse_x264_x64_8bit
            // 
            this.Button_Browse_x264_x64_8bit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Browse_x264_x64_8bit.Location = new System.Drawing.Point(352, 99);
            this.Button_Browse_x264_x64_8bit.Name = "Button_Browse_x264_x64_8bit";
            this.Button_Browse_x264_x64_8bit.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_x264_x64_8bit.TabIndex = 8;
            this.Button_Browse_x264_x64_8bit.Text = "Browse";
            this.Button_Browse_x264_x64_8bit.UseVisualStyleBackColor = true;
            this.Button_Browse_x264_x64_8bit.Click += new System.EventHandler(this.Button_Browse_x264_x64_8bit_Click);
            // 
            // TextBox_x264_x64_8bit
            // 
            this.TextBox_x264_x64_8bit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_x264_x64_8bit.Location = new System.Drawing.Point(10, 102);
            this.TextBox_x264_x64_8bit.Name = "TextBox_x264_x64_8bit";
            this.TextBox_x264_x64_8bit.Size = new System.Drawing.Size(336, 20);
            this.TextBox_x264_x64_8bit.TabIndex = 7;
            // 
            // Label_x264_x64_8bit_Location
            // 
            this.Label_x264_x64_8bit_Location.AutoSize = true;
            this.Label_x264_x64_8bit_Location.Location = new System.Drawing.Point(7, 86);
            this.Label_x264_x64_8bit_Location.Name = "Label_x264_x64_8bit_Location";
            this.Label_x264_x64_8bit_Location.Size = new System.Drawing.Size(114, 13);
            this.Label_x264_x64_8bit_Location.TabIndex = 6;
            this.Label_x264_x64_8bit_Location.Text = "x264 x64 8bit Location";
            // 
            // Button_Browse_x264_x86_10bit
            // 
            this.Button_Browse_x264_x86_10bit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Browse_x264_x86_10bit.Location = new System.Drawing.Point(352, 60);
            this.Button_Browse_x264_x86_10bit.Name = "Button_Browse_x264_x86_10bit";
            this.Button_Browse_x264_x86_10bit.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_x264_x86_10bit.TabIndex = 5;
            this.Button_Browse_x264_x86_10bit.Text = "Browse";
            this.Button_Browse_x264_x86_10bit.UseVisualStyleBackColor = true;
            this.Button_Browse_x264_x86_10bit.Click += new System.EventHandler(this.Button_Browse_x264_x86_10bit_Click);
            // 
            // TextBox_x264_x86_10bit
            // 
            this.TextBox_x264_x86_10bit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_x264_x86_10bit.Location = new System.Drawing.Point(10, 63);
            this.TextBox_x264_x86_10bit.Name = "TextBox_x264_x86_10bit";
            this.TextBox_x264_x86_10bit.Size = new System.Drawing.Size(336, 20);
            this.TextBox_x264_x86_10bit.TabIndex = 4;
            // 
            // Label_x264_x86_10bit_Location
            // 
            this.Label_x264_x86_10bit_Location.AutoSize = true;
            this.Label_x264_x86_10bit_Location.Location = new System.Drawing.Point(7, 47);
            this.Label_x264_x86_10bit_Location.Name = "Label_x264_x86_10bit_Location";
            this.Label_x264_x86_10bit_Location.Size = new System.Drawing.Size(120, 13);
            this.Label_x264_x86_10bit_Location.TabIndex = 3;
            this.Label_x264_x86_10bit_Location.Text = "x264 x86 10bit Location";
            // 
            // Button_Browse_x264_x86_8bit
            // 
            this.Button_Browse_x264_x86_8bit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Browse_x264_x86_8bit.Location = new System.Drawing.Point(352, 21);
            this.Button_Browse_x264_x86_8bit.Name = "Button_Browse_x264_x86_8bit";
            this.Button_Browse_x264_x86_8bit.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_x264_x86_8bit.TabIndex = 2;
            this.Button_Browse_x264_x86_8bit.Text = "Browse";
            this.Button_Browse_x264_x86_8bit.UseVisualStyleBackColor = true;
            this.Button_Browse_x264_x86_8bit.Click += new System.EventHandler(this.Button_Browse_x264_x86_8bit_Click);
            // 
            // TextBox_x264_x86_8bit
            // 
            this.TextBox_x264_x86_8bit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_x264_x86_8bit.Location = new System.Drawing.Point(10, 24);
            this.TextBox_x264_x86_8bit.Name = "TextBox_x264_x86_8bit";
            this.TextBox_x264_x86_8bit.Size = new System.Drawing.Size(336, 20);
            this.TextBox_x264_x86_8bit.TabIndex = 1;
            // 
            // Label_x264_x86_8bit_Location
            // 
            this.Label_x264_x86_8bit_Location.AutoSize = true;
            this.Label_x264_x86_8bit_Location.Location = new System.Drawing.Point(7, 8);
            this.Label_x264_x86_8bit_Location.Name = "Label_x264_x86_8bit_Location";
            this.Label_x264_x86_8bit_Location.Size = new System.Drawing.Size(114, 13);
            this.Label_x264_x86_8bit_Location.TabIndex = 0;
            this.Label_x264_x86_8bit_Location.Text = "x264 x86 8bit Location";
            // 
            // OpenFileDialog_Settings
            // 
            this.OpenFileDialog_Settings.FileName = "openFileDialog1";
            // 
            // Button_Cancel_Settings
            // 
            this.Button_Cancel_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel_Settings.Location = new System.Drawing.Point(374, 366);
            this.Button_Cancel_Settings.Name = "Button_Cancel_Settings";
            this.Button_Cancel_Settings.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel_Settings.TabIndex = 1;
            this.Button_Cancel_Settings.Text = "Cancel";
            this.Button_Cancel_Settings.UseVisualStyleBackColor = true;
            this.Button_Cancel_Settings.Click += new System.EventHandler(this.Button_Cancel_Settings_Click);
            // 
            // Button_OK_Settings
            // 
            this.Button_OK_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK_Settings.Location = new System.Drawing.Point(293, 366);
            this.Button_OK_Settings.Name = "Button_OK_Settings";
            this.Button_OK_Settings.Size = new System.Drawing.Size(75, 23);
            this.Button_OK_Settings.TabIndex = 2;
            this.Button_OK_Settings.Text = "OK";
            this.Button_OK_Settings.UseVisualStyleBackColor = true;
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
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 401);
            this.Controls.Add(this.Button_OK_Settings);
            this.Controls.Add(this.Button_Cancel_Settings);
            this.Controls.Add(this.TabControl_Settings);
            this.Name = "Form_Settings";
            this.Text = "Settings";
            this.TabControl_Settings.ResumeLayout(false);
            this.TabControl_Settings_Video.ResumeLayout(false);
            this.TabControl_Settings_Video.PerformLayout();
            this.TabControl_VideoArgSettings.ResumeLayout(false);
            this.TabPage_VideoSettingsTemplate.ResumeLayout(false);
            this.TabPage_VideoSettingsTemplate.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.TabControl_AudioArgSettings.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Quality)).EndInit();
            this.TabControl_Settings_Locations.ResumeLayout(false);
            this.TabControl_Settings_Locations.PerformLayout();
            this.ContextMenuStrip_Tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Settings;
        private System.Windows.Forms.TabPage TabControl_Settings_Video;
        private System.Windows.Forms.TabPage TabControl_Settings_Locations;
        private System.Windows.Forms.Button Button_Browse_x264_x86_8bit;
        private System.Windows.Forms.TextBox TextBox_x264_x86_8bit;
        private System.Windows.Forms.Label Label_x264_x86_8bit_Location;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_Settings;
        private System.Windows.Forms.Button Button_Cancel_Settings;
        private System.Windows.Forms.Button Button_OK_Settings;
        private System.Windows.Forms.Button Button_Browse_x264_x64_10bit;
        private System.Windows.Forms.TextBox TextBox_x264_x64_10bit;
        private System.Windows.Forms.Label Label_x264_x64_10bit_Location;
        private System.Windows.Forms.Button Button_Browse_x264_x64_8bit;
        private System.Windows.Forms.TextBox TextBox_x264_x64_8bit;
        private System.Windows.Forms.Label Label_x264_x64_8bit_Location;
        private System.Windows.Forms.Button Button_Browse_x264_x86_10bit;
        private System.Windows.Forms.TextBox TextBox_x264_x86_10bit;
        private System.Windows.Forms.Label Label_x264_x86_10bit_Location;
        private System.Windows.Forms.Button Button_Browse_NeroAAC;
        private System.Windows.Forms.TextBox TextBox_NeroAAC;
        private System.Windows.Forms.Label Label_NeroAAC;
        private System.Windows.Forms.Button Button_Browse_MKVMerge;
        private System.Windows.Forms.TextBox TextBox_MKVMerge;
        private System.Windows.Forms.Label Label_MKVMergeLocation;
        private System.Windows.Forms.Button Button_Browse_BePipe;
        private System.Windows.Forms.TextBox TextBox_BePipe;
        private System.Windows.Forms.Label Label_BePipe;
        private System.Windows.Forms.TextBox TextBox_x264_Args;
        private System.Windows.Forms.Label Label_x264_Args;
        private System.Windows.Forms.TabControl TabControl_VideoArgSettings;
        private System.Windows.Forms.TabPage TabPage_VideoSettingsTemplate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Tabs;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_DeleteTab;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Label_VideoTrackName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl TabControl_AudioArgSettings;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label Label_Encoder;
        private System.Windows.Forms.ComboBox ComboBox_Encoder;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Quality;
        private System.Windows.Forms.Label Label_AudioQuality;
        private System.Windows.Forms.TextBox TextBox_LanguageCode;
        private System.Windows.Forms.Label Label_LanguageCode;
        private System.Windows.Forms.TextBox TextBox_AudioTrackName;
        private System.Windows.Forms.Label Label_AudioTrackName;
    }
}