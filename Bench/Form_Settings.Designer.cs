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
            this.Button_Cancel_Settings = new System.Windows.Forms.Button();
            this.Button_OK_Settings = new System.Windows.Forms.Button();
            this.settingsTabCollection = new Bench.SettingsTabCollection();
            this.SuspendLayout();
            // 
            // Button_Cancel_Settings
            // 
            this.Button_Cancel_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel_Settings.Location = new System.Drawing.Point(374, 459);
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
            this.Button_OK_Settings.Location = new System.Drawing.Point(293, 459);
            this.Button_OK_Settings.Name = "Button_OK_Settings";
            this.Button_OK_Settings.Size = new System.Drawing.Size(75, 23);
            this.Button_OK_Settings.TabIndex = 2;
            this.Button_OK_Settings.Text = "OK";
            this.Button_OK_Settings.UseVisualStyleBackColor = true;
            this.Button_OK_Settings.Click += new System.EventHandler(this.Button_OK_Settings_Click);
            // 
            // settingsTabCollection
            // 
            this.settingsTabCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTabCollection.CheckBoxNoAudio = false;
            this.settingsTabCollection.ComboBoxCounterSelectedIndex = -1;
            this.settingsTabCollection.FileNameBodyText = "";
            this.settingsTabCollection.Location = new System.Drawing.Point(13, 13);
            this.settingsTabCollection.Name = "settingsTabCollection";
            this.settingsTabCollection.NumericUpDownCounterValue = 0;
            this.settingsTabCollection.Size = new System.Drawing.Size(448, 435);
            this.settingsTabCollection.TabIndex = 3;
            this.settingsTabCollection.TextBox_VideoLanguageCode_Text = "";
            this.settingsTabCollection.TextBox_VideoTrackName_Text = "";
            this.settingsTabCollection.UnsavedChanges = false;
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 494);
            this.Controls.Add(this.settingsTabCollection);
            this.Controls.Add(this.Button_OK_Settings);
            this.Controls.Add(this.Button_Cancel_Settings);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(50000, 532);
            this.MinimumSize = new System.Drawing.Size(415, 532);
            this.Name = "Form_Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Cancel_Settings;
        private System.Windows.Forms.Button Button_OK_Settings;
        private SettingsTabCollection settingsTabCollection;
    }
}