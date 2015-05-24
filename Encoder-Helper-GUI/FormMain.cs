using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Encoder_Helper_GUI
{
    public partial class FormMain : Form
    {
        private AppSettings appSettings;
        private List<OutputSettings> outputSettings;
        private int[] selectedIndicesToSave;
        private string saveFileName;
        bool unsavedEdits;

        public FormMain()
        {
            InitializeComponent();

            appSettings = new AppSettings();
            outputSettings = new List<OutputSettings>();
            saveFileName = null;
            unsavedEdits = false;
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
                    unsavedEdits = true;
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
                unsavedEdits = true;
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
            var dialogResult = listBox_openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                for (int i = 0; i < listBox_openFileDialog.FileNames.Length; i++)
                {
                    if (!ListBoxCheckForDuplicates(ListBox_Files, listBox_openFileDialog.FileNames[i]))
                    {
                        ListBox_Files.Items.Add(listBox_openFileDialog.FileNames[i]);
                        CreateNewSettings(listBox_openFileDialog.FileNames[i]);
                        unsavedEdits = true;
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

            unsavedEdits = true;
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
            unsavedEdits = true;
        }

        private void save()
        {
            if (saveFileName == null)
            {
                var result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    saveFileName = saveFileDialog.FileName;
                    this.Text = Path.GetFileName(saveFileName) + " - " + this.Text;
                }
            }

            if (saveFileName != null)
            {
                using (Stream stream = File.Open(saveFileName, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(stream, outputSettings);
                }
                unsavedEdits = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                saveFileName = saveFileDialog.FileName;
                this.Text = Path.GetFileName(saveFileName) + " - " + this.Text;
                save();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unsavedEdits)
            {
                var saveResult = MessageBox.Show("Save changes to " + (saveFileName == null ? "Untitled" : Path.GetFileName(saveFileName)) + "?", "", MessageBoxButtons.YesNoCancel);
                if (saveResult != DialogResult.Cancel)
                {
                    if (saveResult == DialogResult.Yes)
                    {
                        save();
                    }
                }
                else
                {
                    return;
                }
            }
            var openResult = openEhFileDialog.ShowDialog();

            if (openResult == DialogResult.OK)
            {
                unsavedEdits = false;
                for (int i = ListBox_Files.Items.Count - 1; i >= 0; i--)
                {
                    ListBox_Files.Items.RemoveAt(i);
                }

                using (Stream stream = File.Open(openEhFileDialog.FileName, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    try
                    {
                        outputSettings = (List<OutputSettings>)bformatter.Deserialize(stream);
                        saveFileName = openEhFileDialog.FileName;
                        this.Text = Path.GetFileName(saveFileName) + " - " + this.Text;
                    }
                    catch
                    {
                        MessageBox.Show("Not a valid BEH file.", "Error", MessageBoxButtons.OK);
                    }
                }

                for (int i = 0; i < outputSettings.Count; i++)
                {
                    ListBox_Files.Items.Add(outputSettings[i].FileName);
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unsavedEdits)
            {
                var result = MessageBox.Show("Save changes to " + (saveFileName == null ? "Untitled" : Path.GetFileName(saveFileName)) + "?", "", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    save();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unsavedEdits)
            {
                var saveResult = MessageBox.Show("Save changes to " + (saveFileName == null ? "Untitled" : Path.GetFileName(saveFileName)) + "?", "", MessageBoxButtons.YesNoCancel);
                if (saveResult != DialogResult.Cancel)
                {
                    if (saveResult == DialogResult.Yes)
                    {
                        save();
                    }
                }
                else
                {
                    return;
                }
            }

            unsavedEdits = false;
            for (int i = ListBox_Files.Items.Count - 1; i >= 0; i--)
            {
                ListBox_Files.Items.RemoveAt(i);
            }
            outputSettings = new List<OutputSettings>();
        }
    }
}
