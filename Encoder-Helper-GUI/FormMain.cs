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

        private void ListBox_Files_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!ListBoxCheckForDuplicates(ListBox_Files, file))
                {
                    ListBox_Files.Items.Add(file);
                }
            }
        }

        private void ListBox_Files_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void ListBoxFilesRemove()
        {
            for (int i = ListBox_Files.SelectedIndices.Count-1; i >= 0; i--)
            {
                ListBox_Files.Items.RemoveAt(ListBox_Files.SelectedIndices[i]);
            }
        }

        private void Button_ListBox_Files_Remove_Click(object sender, EventArgs e)
        {
            ListBoxFilesRemove();
        }

        private void ListBox_Files_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ListBoxFilesRemove();
            }
        }

        private void Button_ListBox_Files_Add_Click(object sender, EventArgs e)
        {
            var dialogResult = ListBoxFilesOpenFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                for (int i = 0; i < ListBoxFilesOpenFileDialog.FileNames.Length; i++)
                {
                    if (!ListBoxCheckForDuplicates(ListBox_Files, ListBoxFilesOpenFileDialog.FileNames[i]))
                    {
                        ListBox_Files.Items.Add(ListBoxFilesOpenFileDialog.FileNames[i]);
                    }
                }
            }
        }
    }
}
