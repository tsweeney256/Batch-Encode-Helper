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
            this.TabControl_Settings = new System.Windows.Forms.TabControl();
            this.TabControl_Settings_General = new System.Windows.Forms.TabPage();
            this.TabControl_Settings_Locations = new System.Windows.Forms.TabPage();
            this.TabControl_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Settings
            // 
            this.TabControl_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Settings.Controls.Add(this.TabControl_Settings_General);
            this.TabControl_Settings.Controls.Add(this.TabControl_Settings_Locations);
            this.TabControl_Settings.Location = new System.Drawing.Point(13, 13);
            this.TabControl_Settings.Name = "TabControl_Settings";
            this.TabControl_Settings.SelectedIndex = 0;
            this.TabControl_Settings.Size = new System.Drawing.Size(441, 376);
            this.TabControl_Settings.TabIndex = 0;
            // 
            // TabControl_Settings_General
            // 
            this.TabControl_Settings_General.Location = new System.Drawing.Point(4, 22);
            this.TabControl_Settings_General.Name = "TabControl_Settings_General";
            this.TabControl_Settings_General.Padding = new System.Windows.Forms.Padding(3);
            this.TabControl_Settings_General.Size = new System.Drawing.Size(433, 350);
            this.TabControl_Settings_General.TabIndex = 0;
            this.TabControl_Settings_General.Text = "General";
            this.TabControl_Settings_General.UseVisualStyleBackColor = true;
            // 
            // TabControl_Settings_Locations
            // 
            this.TabControl_Settings_Locations.Location = new System.Drawing.Point(4, 22);
            this.TabControl_Settings_Locations.Name = "TabControl_Settings_Locations";
            this.TabControl_Settings_Locations.Padding = new System.Windows.Forms.Padding(3);
            this.TabControl_Settings_Locations.Size = new System.Drawing.Size(433, 350);
            this.TabControl_Settings_Locations.TabIndex = 1;
            this.TabControl_Settings_Locations.Text = "Locations";
            this.TabControl_Settings_Locations.UseVisualStyleBackColor = true;
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 401);
            this.Controls.Add(this.TabControl_Settings);
            this.Name = "Form_Settings";
            this.Text = "Settings";
            this.TabControl_Settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Settings;
        private System.Windows.Forms.TabPage TabControl_Settings_General;
        private System.Windows.Forms.TabPage TabControl_Settings_Locations;
    }
}