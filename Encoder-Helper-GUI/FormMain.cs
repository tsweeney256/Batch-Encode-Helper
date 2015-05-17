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

        private bool ListBoxCheckForDuplicates(ListBox lb, string str)
        {
            foreach (var item in lb.Items)
            {
                string itemStr = item.ToString();
                if (String.Equals(str, itemStr))
                {
                    return true;
                }
            }
            return false;
        }

        private void ListBoxFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!ListBoxCheckForDuplicates(ListBoxFiles, file))
                {
                    ListBoxFiles.Items.Add(file);
                }
            }
        }

        private void ListBoxFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void ListBoxFilesRemove()
        {
            for (int i = ListBoxFiles.SelectedIndices.Count-1; i >= 0; i--)
            {
                ListBoxFiles.Items.RemoveAt(ListBoxFiles.SelectedIndices[i]);
            }
        }

        private void ButtonListBoxFilesRemove_Click(object sender, EventArgs e)
        {
            ListBoxFilesRemove();
        }

        private void ListBoxFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ListBoxFilesRemove();
            }
        }

        private void ButtonListBoxFilesAdd_Click(object sender, EventArgs e)
        {
            var dialogResult = ListBoxFilesOpenFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                for (int i = 0; i < ListBoxFilesOpenFileDialog.FileNames.Length; i++)
                {
                    if (!ListBoxCheckForDuplicates(ListBoxFiles, ListBoxFilesOpenFileDialog.FileNames[i]))
                    {
                        ListBoxFiles.Items.Add(ListBoxFilesOpenFileDialog.FileNames[i]);
                    }
                }
            }
        }
    }
}
