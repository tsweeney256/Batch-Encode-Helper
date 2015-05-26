namespace Encoder_Helper_GUI
{
    partial class FormMain
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
            this.ListBox_Files = new System.Windows.Forms.ListBox();
            this.Button_TextBox_Files_Remove = new System.Windows.Forms.Button();
            this.listBox_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Button_TextBox_Files_Add = new System.Windows.Forms.Button();
            this.Button_MoveUp_ListBox_Files = new System.Windows.Forms.Button();
            this.Button_MoveDown_ListBox_Files = new System.Windows.Forms.Button();
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStrip_SettingsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Apply = new System.Windows.Forms.Button();
            this.saveEhFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openEhFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveBatFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.settingsTabCollection = new Encoder_Helper_GUI.SettingsTabCollectionMain();
            this.MenuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox_Files
            // 
            this.ListBox_Files.AllowDrop = true;
            this.ListBox_Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_Files.FormattingEnabled = true;
            this.ListBox_Files.Location = new System.Drawing.Point(12, 62);
            this.ListBox_Files.Name = "ListBox_Files";
            this.ListBox_Files.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox_Files.Size = new System.Drawing.Size(599, 121);
            this.ListBox_Files.TabIndex = 0;
            this.ListBox_Files.SelectedIndexChanged += new System.EventHandler(this.ListBox_Files_SelectedIndexChanged);
            this.ListBox_Files.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_Files_DragDrop);
            this.ListBox_Files.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_Files_DragEnter);
            this.ListBox_Files.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBox_Files_KeyDown);
            // 
            // Button_TextBox_Files_Remove
            // 
            this.Button_TextBox_Files_Remove.Location = new System.Drawing.Point(93, 27);
            this.Button_TextBox_Files_Remove.Name = "Button_TextBox_Files_Remove";
            this.Button_TextBox_Files_Remove.Size = new System.Drawing.Size(75, 23);
            this.Button_TextBox_Files_Remove.TabIndex = 1;
            this.Button_TextBox_Files_Remove.Text = "Remove";
            this.Button_TextBox_Files_Remove.UseVisualStyleBackColor = true;
            this.Button_TextBox_Files_Remove.Click += new System.EventHandler(this.Button_ListBox_Files_Remove_Click);
            // 
            // listBox_openFileDialog
            // 
            this.listBox_openFileDialog.Multiselect = true;
            // 
            // Button_TextBox_Files_Add
            // 
            this.Button_TextBox_Files_Add.Location = new System.Drawing.Point(12, 27);
            this.Button_TextBox_Files_Add.Name = "Button_TextBox_Files_Add";
            this.Button_TextBox_Files_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_TextBox_Files_Add.TabIndex = 2;
            this.Button_TextBox_Files_Add.Text = "Add";
            this.Button_TextBox_Files_Add.UseVisualStyleBackColor = true;
            this.Button_TextBox_Files_Add.Click += new System.EventHandler(this.Button_ListBox_Files_Add_Click);
            // 
            // Button_MoveUp_ListBox_Files
            // 
            this.Button_MoveUp_ListBox_Files.Location = new System.Drawing.Point(175, 27);
            this.Button_MoveUp_ListBox_Files.Name = "Button_MoveUp_ListBox_Files";
            this.Button_MoveUp_ListBox_Files.Size = new System.Drawing.Size(75, 23);
            this.Button_MoveUp_ListBox_Files.TabIndex = 3;
            this.Button_MoveUp_ListBox_Files.Text = "Move Up";
            this.Button_MoveUp_ListBox_Files.UseVisualStyleBackColor = true;
            this.Button_MoveUp_ListBox_Files.Click += new System.EventHandler(this.Button_MoveUp_ListBox_Files_Click);
            // 
            // Button_MoveDown_ListBox_Files
            // 
            this.Button_MoveDown_ListBox_Files.Location = new System.Drawing.Point(257, 27);
            this.Button_MoveDown_ListBox_Files.Name = "Button_MoveDown_ListBox_Files";
            this.Button_MoveDown_ListBox_Files.Size = new System.Drawing.Size(75, 23);
            this.Button_MoveDown_ListBox_Files.TabIndex = 4;
            this.Button_MoveDown_ListBox_Files.Text = "Move Down";
            this.Button_MoveDown_ListBox_Files.UseVisualStyleBackColor = true;
            this.Button_MoveDown_ListBox_Files.Click += new System.EventHandler(this.Button_MoveDown_ListBox_Files_Click);
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.OptionsToolStrip,
            this.helpToolStripMenuItem});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(623, 24);
            this.MenuStrip_Main.TabIndex = 5;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.createBatchToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // createBatchToolStripMenuItem
            // 
            this.createBatchToolStripMenuItem.Name = "createBatchToolStripMenuItem";
            this.createBatchToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.createBatchToolStripMenuItem.Text = "Create Batch";
            this.createBatchToolStripMenuItem.Click += new System.EventHandler(this.createBatchToolStripMenuItem_Click);
            // 
            // OptionsToolStrip
            // 
            this.OptionsToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsToolStrip_SettingsItem});
            this.OptionsToolStrip.Name = "OptionsToolStrip";
            this.OptionsToolStrip.Size = new System.Drawing.Size(61, 20);
            this.OptionsToolStrip.Text = "Options";
            // 
            // OptionsToolStrip_SettingsItem
            // 
            this.OptionsToolStrip_SettingsItem.Name = "OptionsToolStrip_SettingsItem";
            this.OptionsToolStrip_SettingsItem.Size = new System.Drawing.Size(116, 22);
            this.OptionsToolStrip_SettingsItem.Text = "Settings";
            this.OptionsToolStrip_SettingsItem.Click += new System.EventHandler(this.OptionsToolStrip_SettingsItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // button_Apply
            // 
            this.button_Apply.Enabled = false;
            this.button_Apply.Location = new System.Drawing.Point(338, 27);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 23);
            this.button_Apply.TabIndex = 7;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // saveEhFileDialog
            // 
            this.saveEhFileDialog.DefaultExt = "eh";
            // 
            // openEhFileDialog
            // 
            this.openEhFileDialog.Filter = "EH File|*.eh";
            // 
            // saveBatFileDialog
            // 
            this.saveBatFileDialog.DefaultExt = "bat";
            // 
            // settingsTabCollection
            // 
            this.settingsTabCollection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTabCollection.ComboBoxCounterSelectedIndex = -1;
            this.settingsTabCollection.Location = new System.Drawing.Point(12, 189);
            this.settingsTabCollection.Name = "settingsTabCollection";
            this.settingsTabCollection.NumericUpDownCounterValue = 0;
            this.settingsTabCollection.OutputSettings = null;
            this.settingsTabCollection.Size = new System.Drawing.Size(599, 392);
            this.settingsTabCollection.TabIndex = 0;
            this.settingsTabCollection.TextBox_AvisynthTemplate_Text = "";
            this.settingsTabCollection.TextBox_VideoLanguageCode_Text = "";
            this.settingsTabCollection.TextBox_VideoTrackName_Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 589);
            this.Controls.Add(this.settingsTabCollection);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.Button_MoveDown_ListBox_Files);
            this.Controls.Add(this.Button_MoveUp_ListBox_Files);
            this.Controls.Add(this.Button_TextBox_Files_Add);
            this.Controls.Add(this.Button_TextBox_Files_Remove);
            this.Controls.Add(this.ListBox_Files);
            this.Controls.Add(this.MenuStrip_Main);
            this.MainMenuStrip = this.MenuStrip_Main;
            this.Name = "FormMain";
            this.Text = "BD Encoder Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Files;
        private System.Windows.Forms.Button Button_TextBox_Files_Remove;
        private System.Windows.Forms.OpenFileDialog listBox_openFileDialog;
        private System.Windows.Forms.Button Button_TextBox_Files_Add;
        private System.Windows.Forms.Button Button_MoveUp_ListBox_Files;
        private System.Windows.Forms.Button Button_MoveDown_ListBox_Files;
        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStrip_SettingsItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveEhFileDialog;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openEhFileDialog;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBatchToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveBatFileDialog;
        private SettingsTabCollectionMain settingsTabCollection;
    }
}

