namespace Bench
{
    partial class FormAbout
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelGpl = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(3);
            this.labelName.Size = new System.Drawing.Size(166, 19);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Bench (Batch ENCoding Helper)";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(12, 28);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Padding = new System.Windows.Forms.Padding(3);
            this.labelVersion.Size = new System.Drawing.Size(75, 19);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "Version 1.0.2";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(12, 47);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Padding = new System.Windows.Forms.Padding(3);
            this.labelCopyright.Size = new System.Drawing.Size(188, 19);
            this.labelCopyright.TabIndex = 3;
            this.labelCopyright.Text = "Copyright (C) 2015 Thomas Sweeney";
            // 
            // labelGpl
            // 
            this.labelGpl.AutoSize = true;
            this.labelGpl.Location = new System.Drawing.Point(15, 70);
            this.labelGpl.Name = "labelGpl";
            this.labelGpl.Size = new System.Drawing.Size(230, 26);
            this.labelGpl.TabIndex = 4;
            this.labelGpl.Text = "This is free software covered under the GPLv3.\r\nSee LICENSE.txt for more details\r" +
    "\n";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(220, 117);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormAbout
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 152);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelGpl);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(323, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(323, 190);
            this.Name = "FormAbout";
            this.Text = "About Bench";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelGpl;
        private System.Windows.Forms.Button buttonOK;

    }
}