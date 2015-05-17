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
            this.ListBoxFiles = new System.Windows.Forms.ListBox();
            this.ButtonTextBoxFilesRemove = new System.Windows.Forms.Button();
            this.ListBoxFilesOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ButtonTextBoxFilesAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxFiles
            // 
            this.ListBoxFiles.AllowDrop = true;
            this.ListBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxFiles.FormattingEnabled = true;
            this.ListBoxFiles.Location = new System.Drawing.Point(12, 41);
            this.ListBoxFiles.Name = "ListBoxFiles";
            this.ListBoxFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxFiles.Size = new System.Drawing.Size(599, 342);
            this.ListBoxFiles.TabIndex = 0;
            this.ListBoxFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBoxFiles_DragDrop);
            this.ListBoxFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBoxFiles_DragEnter);
            this.ListBoxFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxFiles_KeyDown);
            // 
            // ButtonTextBoxFilesRemove
            // 
            this.ButtonTextBoxFilesRemove.Location = new System.Drawing.Point(93, 12);
            this.ButtonTextBoxFilesRemove.Name = "ButtonTextBoxFilesRemove";
            this.ButtonTextBoxFilesRemove.Size = new System.Drawing.Size(75, 23);
            this.ButtonTextBoxFilesRemove.TabIndex = 1;
            this.ButtonTextBoxFilesRemove.Text = "Remove";
            this.ButtonTextBoxFilesRemove.UseVisualStyleBackColor = true;
            this.ButtonTextBoxFilesRemove.Click += new System.EventHandler(this.ButtonTextBoxFilesRemove_Click);
            // 
            // ListBoxFilesOpenFileDialog
            // 
            this.ListBoxFilesOpenFileDialog.FileName = "openFileDialog1";
            this.ListBoxFilesOpenFileDialog.Multiselect = true;
            // 
            // ButtonTextBoxFilesAdd
            // 
            this.ButtonTextBoxFilesAdd.Location = new System.Drawing.Point(12, 12);
            this.ButtonTextBoxFilesAdd.Name = "ButtonTextBoxFilesAdd";
            this.ButtonTextBoxFilesAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonTextBoxFilesAdd.TabIndex = 2;
            this.ButtonTextBoxFilesAdd.Text = "Add";
            this.ButtonTextBoxFilesAdd.UseVisualStyleBackColor = true;
            this.ButtonTextBoxFilesAdd.Click += new System.EventHandler(this.ButtonTextBoxFilesAdd_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 390);
            this.Controls.Add(this.ButtonTextBoxFilesAdd);
            this.Controls.Add(this.ButtonTextBoxFilesRemove);
            this.Controls.Add(this.ListBoxFiles);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxFiles;
        private System.Windows.Forms.Button ButtonTextBoxFilesRemove;
        private System.Windows.Forms.OpenFileDialog ListBoxFilesOpenFileDialog;
        private System.Windows.Forms.Button ButtonTextBoxFilesAdd;
    }
}

