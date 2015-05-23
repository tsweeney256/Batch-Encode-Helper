namespace Encoder_Helper_GUI
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
            this.Label_Encoder = new System.Windows.Forms.Label();
            this.ComboBox_Encoder = new System.Windows.Forms.ComboBox();
            this.Label_x264_Args = new System.Windows.Forms.Label();
            this.TextBox_x264_Args = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label_Encoder
            // 
            this.Label_Encoder.AutoSize = true;
            this.Label_Encoder.Location = new System.Drawing.Point(3, 99);
            this.Label_Encoder.Name = "Label_Encoder";
            this.Label_Encoder.Size = new System.Drawing.Size(47, 13);
            this.Label_Encoder.TabIndex = 7;
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
            this.ComboBox_Encoder.Location = new System.Drawing.Point(6, 115);
            this.ComboBox_Encoder.Name = "ComboBox_Encoder";
            this.ComboBox_Encoder.Size = new System.Drawing.Size(157, 21);
            this.ComboBox_Encoder.TabIndex = 6;
            this.ComboBox_Encoder.Text = "Select Encoder";
            // 
            // Label_x264_Args
            // 
            this.Label_x264_Args.AutoSize = true;
            this.Label_x264_Args.Location = new System.Drawing.Point(3, 3);
            this.Label_x264_Args.Name = "Label_x264_Args";
            this.Label_x264_Args.Size = new System.Drawing.Size(83, 13);
            this.Label_x264_Args.TabIndex = 4;
            this.Label_x264_Args.Text = "x264 Arguments";
            // 
            // TextBox_x264_Args
            // 
            this.TextBox_x264_Args.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_x264_Args.Location = new System.Drawing.Point(6, 19);
            this.TextBox_x264_Args.Multiline = true;
            this.TextBox_x264_Args.Name = "TextBox_x264_Args";
            this.TextBox_x264_Args.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_x264_Args.Size = new System.Drawing.Size(397, 77);
            this.TextBox_x264_Args.TabIndex = 5;
            // 
            // VideoTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_Encoder);
            this.Controls.Add(this.ComboBox_Encoder);
            this.Controls.Add(this.Label_x264_Args);
            this.Controls.Add(this.TextBox_x264_Args);
            this.Name = "VideoTabControl";
            this.Size = new System.Drawing.Size(408, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Encoder;
        private System.Windows.Forms.ComboBox ComboBox_Encoder;
        private System.Windows.Forms.Label Label_x264_Args;
        private System.Windows.Forms.TextBox TextBox_x264_Args;
    }
}
