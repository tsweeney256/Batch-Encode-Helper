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
        private AppSettings appSettings;
        private List<OutputSettings> outputSettings;
        private int[] selectedIndicesToSave;

        public FormMain()
        {
            InitializeComponent();

            appSettings = new AppSettings();
            outputSettings = new List<OutputSettings>();
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
                    CreateNewSettings(file);
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
                outputSettings.RemoveAt(ListBox_Files.SelectedIndices[i]);
                ListBox_Files.Items.RemoveAt(ListBox_Files.SelectedIndices[i]);
            }
            if (ListBox_Files.SelectedIndices.Count <= 0)
            {
                settingsTabCollection.Enabled = false;
                button_Apply.Enabled = false;
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
                        CreateNewSettings(ListBoxFilesOpenFileDialog.FileNames[i]);
                    }
                }
            }
        }

        private  void MoveListBoxItemsCommon(ListBox lb, int direction, int i)
        {
            int newIndex = lb.SelectedIndices[i] + direction;
            var selected = lb.SelectedItems[i];

            OutputSettings temp = outputSettings[newIndex];
            outputSettings[newIndex] = outputSettings[lb.SelectedIndices[i]];
            outputSettings[lb.SelectedIndices[i]] = temp;

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

        private void OptionsToolStrip_SettingsItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new Form_Settings();
            settingsForm.ShowDialog();
        }

        private void ListBox_Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox_Files.SelectedIndices.Count > 0)
            {
                button_Apply.Enabled = true;
                settingsTabCollection.Enabled = true;
                settingsTabCollection.LoadSettings(outputSettings[ListBox_Files.SelectedIndex]);
                selectedIndicesToSave = new int[ListBox_Files.SelectedIndices.Count];
                ListBox_Files.SelectedIndices.CopyTo(selectedIndicesToSave, 0);
            }
        }

        private void CreateNewSettings(string fileName)
        {
            outputSettings.Add(new OutputSettings(appSettings));
            outputSettings.Last().FileName = fileName;
        }

        private void SaveSelectedIndices()
        {
            foreach (int index in selectedIndicesToSave)
            {
                outputSettings[index].FileName = ListBox_Files.Items[index].ToString();

                int vidTabCount = settingsTabCollection.VideoTabList.Count;
                outputSettings[index].x264Args = new string[vidTabCount];
                outputSettings[index].encoder = new int[vidTabCount];
                for (int i = 0; i < vidTabCount; i++ )
                {
                    outputSettings[index].x264Args[i] = settingsTabCollection.VideoTabList[i].TextBox_x264_Args_Text;
                    outputSettings[index].encoder[i] = settingsTabCollection.VideoTabList[i].ComboBox_Encoder_SelectedIndex;
                }
                outputSettings[index].videoTrackName = settingsTabCollection.TextBox_VideoTrackName_Text;
                outputSettings[index].videoLanguageCode = settingsTabCollection.TextBox_VideoLanguageCode_Text;
                outputSettings[index].avisynthTemplate = settingsTabCollection.TextBox_AvisynthTemplate_Text;

                int audioTabCount = settingsTabCollection.AudioTabList.Count;
                outputSettings[index].quality = new decimal[audioTabCount];
                outputSettings[index].audioTrackName = new string[audioTabCount];
                outputSettings[index].audioLanguageCode = new string[audioTabCount];
                for (int i = 0; i < audioTabCount; i++)
                {
                    outputSettings[index].quality[i] = settingsTabCollection.AudioTabList[i].NumericUpDown_Quality_Value;
                    outputSettings[index].audioTrackName[i] = settingsTabCollection.AudioTabList[i].TextBox_AudioTrackName_Text;
                    outputSettings[index].audioLanguageCode[i] = settingsTabCollection.AudioTabList[i].TextBox_LanguageCode_Text;
                }
            }
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            SaveSelectedIndices();
        }
    }
}
