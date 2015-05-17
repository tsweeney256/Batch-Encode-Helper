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

        private  void MoveListBoxItemsCommon(ListBox lb, int direction, int i)
        {
            int newIndex = lb.SelectedIndices[i] + direction;
            var selected = lb.SelectedItems[i];
            lb.Items.RemoveAt(lb.SelectedIndices[i]);
            lb.Items.Insert(newIndex, selected);
            lb.SetSelected(newIndex, true);
        }

        private void MoveListBoxItems(ListBox lb, int direction)
        {
            if (lb.SelectedItem == null)
            {
                return;
            }

            int frontNewIndex = lb.SelectedIndices[0] + direction;
            int backNewIndex = lb.SelectedIndices[lb.SelectedIndices.Count - 1] + direction;
            if (frontNewIndex < 0 || backNewIndex >= lb.Items.Count)
            {
                return;
            }

            if (direction < 0)
            {
                for (int i = 0; i < lb.SelectedIndices.Count; i++)
                {
                    MoveListBoxItemsCommon(lb, direction, i);
                }
            }
            else
            {
                for (int i = lb.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    MoveListBoxItemsCommon(lb, direction, i);
                }
            }
        }

        private void Button_MoveUp_ListBox_Files_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(ListBox_Files, -1);
        }

        private void Button_MoveDown_ListBox_Files_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(ListBox_Files, 1);
        }
    }
}
