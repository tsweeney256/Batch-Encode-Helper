using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder_Helper_GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ListBoxFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                ListBoxFiles.Items.Add(file);
            }
        }

        private void ListBoxFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void TextBoxFilesRemove()
        {
            for (int i = ListBoxFiles.SelectedIndices.Count-1; i >= 0; i--)
            {
                ListBoxFiles.Items.RemoveAt(ListBoxFiles.SelectedIndices[i]);
            }
        }

        private void ButtonTextBoxFilesRemove_Click(object sender, EventArgs e)
        {
            TextBoxFilesRemove();
        }

        private void ListBoxFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                TextBoxFilesRemove();
            }
        }
    }
}
