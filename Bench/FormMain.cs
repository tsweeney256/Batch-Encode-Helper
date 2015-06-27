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

namespace Bench
{
    public partial class FormMain : Form
    {
        private AppSettings appSettings;
        private List<OutputSettings> outputSettings;
        private int[] selectedIndicesToSave;
        private string saveFileName;
        private bool unsavedChanges;
        private bool deletingItems;

        public FormMain()
        {
            InitializeComponent();

            appSettings = new AppSettings();
            initInterface();
        }

        private void initInterface()
        {
            outputSettings = new List<OutputSettings>();
            saveFileName = null;
            settingsTabCollection.OutputSettings = outputSettings;
            settingsTabCollection.ListBox = ListBox_Files;
            settingsTabCollection.LoadSettings(appSettings);
            settingsTabCollection.UnsavedChanges = false;
            deletingItems = false;
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
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string path in paths)
            {
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Adding directories to the listbox is not supported.", "Error");
                    return;
                }
            }
            AddToListBoxCommon(paths);
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
            int selectedIdx = ListBox_Files.SelectedIndex; //We only care about the top one when deciding our next index to select after the deletion

            settingsTabCollection.UnsavedChanges = true;
            unsavedChanges = true;
            deletingItems = true;
            selectedIndicesToSave = null; //all the selected indices will be deleted, so it makes no sense to save them
            for (int i = ListBox_Files.SelectedIndices.Count-1; i >= 0; i--)
            {
                outputSettings.RemoveAt(ListBox_Files.SelectedIndices[i]);
                ListBox_Files.Items.RemoveAt(ListBox_Files.SelectedIndices[i]);
            }
            deletingItems = false;
            if (ListBox_Files.Items.Count < 2)
            {
                Button_MoveDown_ListBox_Files.Enabled = false;
                Button_MoveUp_ListBox_Files.Enabled = false;
            }
            if (ListBox_Files.Items.Count == 0)
            {
                settingsTabCollection.Enabled = false;
                createBatchToolStripMenuItem.Enabled = false;
                Button_TextBox_Files_Remove.Enabled = false;
                settingsTabCollection.LoadSettings(appSettings);
                selectedIndicesToSave = null;
            }
            else if (selectedIdx < ListBox_Files.Items.Count)
            {
                ListBox_Files.SelectedIndex = selectedIdx;
            }
            else
            {
                ListBox_Files.SelectedIndex = selectedIdx - 1;
            }
        }

        private void Button_ListBox_Files_Remove_Click(object sender, EventArgs e)
        {
            ListBoxFilesRemove();
        }

        private void ListBox_Files_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                for (int i = 0; i < ((ListBox)sender).Items.Count; i++)
                {
                    ((ListBox)sender).SetSelected(i, true);
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                ListBoxFilesRemove();
            }
        }

        private void AddToListBoxCommon(string[] filename)
        {
            int indexToSelect = ListBox_Files.Items.Count;

            settingsTabCollection.UnsavedChanges = true;
            unsavedChanges = true;
            foreach (string str in filename)
            {
                if (!ListBoxCheckForDuplicates(ListBox_Files, str))
                {
                    ListBox_Files.Items.Add(str);
                    CreateNewSettings(str);
                }
            }
            if (ListBox_Files.Items.Count > 1)
            {
                if(ListBox_Files.SelectedIndex !=0)
                {
                    //only need to check for move up since the bottom will never be selected after adding ot the list box
                    Button_MoveUp_ListBox_Files.Enabled = true;
                }
                Button_MoveDown_ListBox_Files.Enabled = true;
            }
            if (ListBox_Files.SelectedIndex < 0)
            {
                ListBox_Files.SelectedIndex = indexToSelect;
            }
        }

        private void Button_ListBox_Files_Add_Click(object sender, EventArgs e)
        {
            var dialogResult = listBox_openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                AddToListBoxCommon(listBox_openFileDialog.FileNames);
            }
        }

        private  void MoveListBoxItemsCommon(ListBox lb, int direction, int i)
        {
            int newIndex = lb.SelectedIndices[i] + direction;
            var selected = lb.SelectedItems[i];

            OutputSettings temp = outputSettings[newIndex];
            outputSettings[newIndex] = outputSettings[lb.SelectedIndices[i]];
            outputSettings[lb.SelectedIndices[i]] = temp;

            deletingItems = true;
            lb.Items.RemoveAt(lb.SelectedIndices[i]);
            deletingItems = false;
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

            unsavedChanges = true;
            settingsTabCollection.UnsavedChanges = true;
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
            appSettings = new AppSettings();
        }

        private void ListBox_Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!deletingItems)
            {
                if (settingsTabCollection.UnsavedChanges)
                {
                    SaveSelectedIndices();
                    settingsTabCollection.UnsavedChanges = false;
                    unsavedChanges = true;
                }
                settingsTabCollection.Enabled = true;
                createBatchToolStripMenuItem.Enabled = true;
                if (ListBox_Files.Items.Count > 1)
                {
                    if (ListBox_Files.SelectedIndices.Contains(ListBox_Files.Items.Count-1))
                    {
                        Button_MoveDown_ListBox_Files.Enabled = false;
                    }
                    else
                    {
                        Button_MoveDown_ListBox_Files.Enabled = true;
                    }
                    if (ListBox_Files.SelectedIndices.Contains(0))
                    {
                        Button_MoveUp_ListBox_Files.Enabled = false;
                    }
                    else
                    {
                        Button_MoveUp_ListBox_Files.Enabled = true;
                    }
                }
                Button_TextBox_Files_Remove.Enabled = true;
                settingsTabCollection.LoadSettings(outputSettings[ListBox_Files.SelectedIndex]);
                selectedIndicesToSave = new int[ListBox_Files.SelectedIndices.Count];
                ListBox_Files.SelectedIndices.CopyTo(selectedIndicesToSave, 0);
                ListBox_Files.Focus(); //or else focus will change to settingsTabCollection
            }
        }

        private void CreateNewSettings(string fileName)
        {
            outputSettings.Add(new OutputSettings(appSettings));
            outputSettings.Last().FileName = fileName;
        }

        private void SaveSelectedIndices()
        {
            if (selectedIndicesToSave != null)
            {
                foreach (int index in selectedIndicesToSave)
                {
                    outputSettings[index].FileName = ListBox_Files.Items[index].ToString();

                    int vidTabCount = settingsTabCollection.VideoTabList.Count;
                    outputSettings[index].x264Args = new string[vidTabCount];
                    outputSettings[index].encoder = new int[vidTabCount];
                    outputSettings[index].fileNamePrefix = new string[vidTabCount];
                    outputSettings[index].fileNameSuffix = new string[vidTabCount];
                    outputSettings[index].avisynthTemplate = new string[vidTabCount];
                    for (int i = 0; i < vidTabCount; i++)
                    {
                        outputSettings[index].x264Args[i] = settingsTabCollection.VideoTabList[i].TextBox_x264_Args_Text;
                        outputSettings[index].encoder[i] = settingsTabCollection.VideoTabList[i].ComboBox_Encoder_SelectedIndex;
                        outputSettings[index].fileNamePrefix[i] = settingsTabCollection.VideoTabList[i].FileNamePrefixText;
                        outputSettings[index].fileNameSuffix[i] = settingsTabCollection.VideoTabList[i].FileNameSuffixText;
                        outputSettings[index].avisynthTemplate[i] = settingsTabCollection.VideoTabList[i].TextBox_AvisynthTemplate_Text;
                    }
                    outputSettings[index].fileNameBody = settingsTabCollection.FileNameBodyText;
                    outputSettings[index].videoTrackName = settingsTabCollection.TextBox_VideoTrackName_Text;
                    outputSettings[index].videoLanguageCode = settingsTabCollection.TextBox_VideoLanguageCode_Text;
                    outputSettings[index].counterIndex = settingsTabCollection.ComboBoxCounterSelectedIndex;
                    outputSettings[index].counterValue = settingsTabCollection.NumericUpDownCounterValue;

                    int audioTabCount = settingsTabCollection.AudioTabList.Count;
                    outputSettings[index].quality = new decimal[audioTabCount];
                    outputSettings[index].audioTrackName = new string[audioTabCount];
                    outputSettings[index].audioLanguageCode = new string[audioTabCount];
                    outputSettings[index].audioTrackNumber = new int[audioTabCount];
                    outputSettings[index].noAudio = settingsTabCollection.CheckBoxNoAudio;
                    for (int i = 0; i < audioTabCount; i++)
                    {
                        outputSettings[index].quality[i] = settingsTabCollection.AudioTabList[i].NumericUpDown_Quality_Value;
                        outputSettings[index].audioTrackName[i] = settingsTabCollection.AudioTabList[i].TextBox_AudioTrackName_Text;
                        outputSettings[index].audioLanguageCode[i] = settingsTabCollection.AudioTabList[i].TextBox_LanguageCode_Text;
                        outputSettings[index].audioTrackNumber[i] = settingsTabCollection.AudioTabList[i].NumericUpDownTrackNumber_Value;
                    }
                }
                int idx = outputSettings[selectedIndicesToSave[0]].counterIndex;
                for (int i = 0; i < outputSettings.Count; i++)
                {
                    if (outputSettings[i].counterIndex == idx)
                    {
                        outputSettings[i].counterValue = settingsTabCollection.NumericUpDownCounterValue; ;
                    }
                }
            }
        }

        private void save()
        {
            if (saveFileName == null)
            {
                var result = saveEhFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    saveFileName = saveEhFileDialog.FileName;
                    this.Text = Path.GetFileName(saveFileName) + " - " + this.Text;
                }
            }

            if (saveFileName != null)
            {
                SaveSelectedIndices();
                settingsTabCollection.UnsavedChanges = false;
                unsavedChanges = false;
                using (Stream stream = File.Open(saveFileName, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(stream, "1.0.0");
                    bformatter.Serialize(stream, outputSettings);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = saveEhFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                saveFileName = saveEhFileDialog.FileName;
                this.Text = Path.GetFileName(saveFileName) + " - " + this.Text;
                save();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unsavedChanges || settingsTabCollection.UnsavedChanges)
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
                openBenFile(openEhFileDialog.FileName);
            }
        }

        private void openBenFile(string path)
        {
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                try
                {
                    string version = (string)bformatter.Deserialize(stream);
                    outputSettings = (List<OutputSettings>)bformatter.Deserialize(stream);
                    settingsTabCollection.OutputSettings = outputSettings;
                    saveFileName = path;
                    this.Text = Path.GetFileName(saveFileName) + " - " + this.Text;
                    ListBox_Files.Items.Clear();
                    for (int i = 0; i < outputSettings.Count; i++)
                    {
                        ListBox_Files.Items.Add(outputSettings[i].FileName);
                    }
                    if (ListBox_Files.Items.Count > 0)
                    {
                        if (ListBox_Files.Items.Count < 2)
                        {
                            Button_MoveDown_ListBox_Files.Enabled = false;
                            Button_MoveUp_ListBox_Files.Enabled = false;
                        }
                        ListBox_Files.SelectedIndex = 0;
                    }
                    else
                    {
                        settingsTabCollection.Enabled = false;
                        createBatchToolStripMenuItem.Enabled = false;
                        Button_TextBox_Files_Remove.Enabled = false;
                    }
                    unsavedChanges = false;
                    settingsTabCollection.UnsavedChanges = false;
                }
                catch
                {
                    MessageBox.Show("Not a valid BEH file.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unsavedChanges || settingsTabCollection.UnsavedChanges)
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
            if (unsavedChanges || settingsTabCollection.UnsavedChanges)
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

            unsavedChanges = false;
            settingsTabCollection.UnsavedChanges = false;
            ListBox_Files.Items.Clear();
            initInterface();
            settingsTabCollection.Enabled = false;
            Button_MoveDown_ListBox_Files.Enabled = false;
            Button_MoveUp_ListBox_Files.Enabled = false;
            Button_TextBox_Files_Remove.Enabled = false;

        }

        private bool InputErrorsExist()
        {
            foreach (var settings in outputSettings)
            {
                for (int i = 0; i < settings.x264Args.Length; i++)
                {
                    if (String.IsNullOrWhiteSpace(settings.x264Args[i]))
                    {
                        MessageBox.Show("There are no x264 arguments for tab #" + (i + 1) + " of " + settings.FileName, "Error");
                        return true;
                    }
                    if (String.IsNullOrWhiteSpace(settings.fileNamePrefix[i]) && 
                            String.IsNullOrWhiteSpace(settings.fileNameBody) &&
                            String.IsNullOrWhiteSpace(settings.fileNameSuffix[i]))
                    {
                        MessageBox.Show("There are no output filename for tab #" + (i+1) + " of " + settings.FileName, "Error");
                        return true;
                    }
                    bool x264Exists = false;
                    string x264Version = "";
                    switch (settings.encoder[i])
                    {
                        case 0:
                            x264Exists = String.IsNullOrWhiteSpace(appSettings.x264_x86_8bit_location);
                            x264Version = "x86 8bit";
                            break;
                        case 1:
                            x264Exists = String.IsNullOrWhiteSpace(appSettings.x264_x86_10bit_location);
                            x264Version = "x86 10bit";
                            break;
                        case 2:
                            x264Exists = String.IsNullOrWhiteSpace(appSettings.x264_x64_8bit_location);
                            x264Version = "x64 8bit";
                            break;
                        case 3:
                            x264Exists = String.IsNullOrWhiteSpace(appSettings.x264_x64_10bit_location);
                            x264Version = "x64 10bit";
                            break;
                        default:
                            MessageBox.Show("You did not set which encoder to use." + Environment.NewLine + Environment.NewLine + "Entry: " + settings.FileName + 
                                Environment.NewLine + Environment.NewLine + "Tab#" + (i+1), "Error");
                            return true;
                    }
                    if (x264Exists)
                    {
                        MessageBox.Show("The location for the " + x264Version + " version of x264 is not set, but you are trying to use it." +
                            Environment.NewLine + Environment.NewLine + "You can set it in Options->Settings->Locations.", "Error");
                        return true;
                    }
                }
                if (!settings.noAudio && String.IsNullOrWhiteSpace(appSettings.NeroAACLocation))
                {
                    MessageBox.Show("The location for the Nero AAC encoder is not set, but you are trying to encode audio, which requires it." +
                            Environment.NewLine + Environment.NewLine + "You can set it in Options->Settings->Locations.", "Error");
                    return true;
                }
                if (!settings.noAudio && String.IsNullOrWhiteSpace(appSettings.BePipeLocation))
                {
                    MessageBox.Show("The location for BePipe is not set, but you are trying to encode audio, which requires it." +
                            Environment.NewLine + Environment.NewLine +"You can set it in Options->Settings->Locations.", "Error");
                    return true;
                }
            }
            if (String.IsNullOrWhiteSpace(appSettings.MKVMergeLocation))
            {
                MessageBox.Show("The location for mkvmerge.exe is not set." + Environment.NewLine + Environment.NewLine + 
                    "You can set it in Options->Settings->Locations.", "Error");
                return true;
            }
            return false;
        }

        private bool handleAvisynthTemplates(string[][] inputFile) //just for organizational convenience
        {
            int avisynthCounter = 1;
            bool alreadyCreatedDirectory = false;

            for (int i = 0; i < outputSettings.Count; i++)
            {
                string avisynthFileString;
                for (int j = 0; j < outputSettings[i].avisynthTemplate.Length; j++)
                {
                    if (!String.IsNullOrWhiteSpace(outputSettings[i].avisynthTemplate[j]))
                    {
                        try
                        {
                            avisynthFileString = String.Format(File.ReadAllText(outputSettings[i].avisynthTemplate[j]), "\"" + outputSettings[i].FileName + "\"");
                        }
                        catch (FileNotFoundException)
                        {
                            MessageBox.Show("Specified Avisynth File for the following entry does not exist." + Environment.NewLine +
                                "Entry: " + outputSettings[i].FileName + Environment.NewLine + "Specified Avisynth file: " + outputSettings[i].avisynthTemplate);
                            return false;
                        }
                        string generatedAvsFileShort = "Generated Avisynth Files\\" + avisynthCounter + ".avs";
                        string generatedAvsFileFull = Path.GetDirectoryName(saveBatFileDialog.FileName) + "\\Generated Avisynth Files\\" + avisynthCounter++ + ".avs";
                        if (!alreadyCreatedDirectory)
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(saveBatFileDialog.FileName) + "\\Generated Avisynth Files\\");
                        }
                        inputFile[i][j] = generatedAvsFileShort;
                        try
                        {
                            File.WriteAllText(generatedAvsFileFull, avisynthFileString, System.Text.Encoding.Default);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("There was an error making one of the generated avisynth files: " + e.Message);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void createBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = saveBatFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                int[] fileCount = new int[ListBox_Files.Items.Count];
                int[] counter = new int[26]; //using an int literal here isn't a big deal since I don't see a-z changing anytime soon
                string[][] inputFile = new string[outputSettings.Count][];

                SaveSelectedIndices();
                for (int i = 0; i < outputSettings.Count; i++)
                {
                    inputFile[i] = new string[outputSettings[i].x264Args.Length];
                }
                for(int i=0; i<outputSettings.Count; i++)
                {
                    for (int j = 0; j < outputSettings[i].x264Args.Length; j++)
                    {
                        inputFile[i][j] = outputSettings[i].FileName;
                    }
                }
                if (InputErrorsExist())
                {
                    return;
                }
                if (!handleAvisynthTemplates(inputFile))
                {
                    return;
                }

                for (int i = 0; i < outputSettings.Count; i++)
                {
                    counter[outputSettings[i].counterIndex] = outputSettings[i].counterValue;
                }
                for (int i = 0; i < outputSettings.Count; i++)
                {
                    fileCount[i] = counter[outputSettings[i].counterIndex]++;
                }
                
                sb.Append("mkdir Audio" + Environment.NewLine + "mkdir Videos" + Environment.NewLine + "mkdir Muxed" + Environment.NewLine + Environment.NewLine);
                for (int i = 0; i < outputSettings.Count; i++)
                {
                    bool avs = Path.GetExtension(outputSettings[i].FileName) == ".avs";
                    string filename = String.Format(outputSettings[i].fileNamePrefix[0] + outputSettings[i].fileNameBody + outputSettings[i].fileNameSuffix[0], fileCount[i]);
                    for (int j = 0; j < outputSettings[i].audioLanguageCode.Length; j++) //audiolanguagecode.length is equal to the number of tabs/audio tracks
                    {
                        if (!outputSettings[i].noAudio)
                        {
                            sb.Append("REM Audio " + filename + " Track " + (j + 1) + Environment.NewLine);
                            sb.Append("\"" + appSettings.BePipeLocation + "\" --script \"" + (avs ? "Import" : "LWLibavAudioSource") + "(^" + outputSettings[i].FileName + 
                                "^" + (avs ? "" : ", stream_index=" + outputSettings[i].audioTrackNumber[j]) + ")\" | \"" + appSettings.NeroAACLocation + "\" -q " + 
                                outputSettings[i].quality[j] + " -if - -of \"" + "Audio\\" + filename + " Track " + (j + 1) + ".m4a\"" + Environment.NewLine + Environment.NewLine);
                        }
                    }
                        
                }
                bool checkedAllTabs = false;
                int k = 0;
                bool[] finishedFiles = new bool[outputSettings.Count];
                while (!checkedAllTabs)
                {

                    for (int i = 0; i < outputSettings.Count; i++)
                    {
                        if (k < outputSettings[i].x264Args.Length) //x264args.length is equal to the number of video tabs
                        {
                            string filename = String.Format(outputSettings[i].fileNamePrefix[k] + outputSettings[i].fileNameBody + outputSettings[i].fileNameSuffix[k], fileCount[i]);
                            string x264;
                            switch (outputSettings[i].encoder[k])
                            {
                                case 0:
                                    x264 = appSettings.x264_x86_8bit_location;
                                    break;
                                case 1:
                                    x264 = appSettings.x264_x86_10bit_location;
                                    break;
                                case 2:
                                    x264 = appSettings.x264_x64_8bit_location;
                                    break;
                                case 3:
                                    x264 = appSettings.x264_x64_10bit_location;
                                    break;
                                default:
                                    x264 = null;
                                    break;
                            }
                            string vidLang;
                            if(outputSettings[i].videoLanguageCode == ""){
                                vidLang = "und";
                            }
                            else
                            {
                                vidLang = outputSettings[i].videoLanguageCode;
                            }
                            string audioFilename = String.Format(outputSettings[i].fileNamePrefix[0] + outputSettings[i].fileNameBody + outputSettings[i].fileNameSuffix[0], fileCount[i]);
                            sb.Append("REM Video " + filename + Environment.NewLine);
                            sb.Append("\"" + x264 + "\" --output \"Videos\\" + filename + ".264\" " + outputSettings[i].x264Args[k] + " \"" 
                                + inputFile[i][k] + "\"" + Environment.NewLine + Environment.NewLine);
                            sb.Append("REM Mux " + filename + Environment.NewLine);
                            sb.Append("\"" + appSettings.MKVMergeLocation + "\" -o \"Muxed\\" + filename + ".mkv\" --language 0:" + vidLang + 
                                (!String.IsNullOrWhiteSpace(outputSettings[i].videoTrackName) ? " --track-name 0:\"" + outputSettings[i].videoTrackName + "\"" : "") + 
                                " \"Videos\\" + filename + ".264\"");
                            if (!outputSettings[i].noAudio)
                            {
                                for (int x = 0; x < outputSettings[i].audioLanguageCode.Length; x++)
                                {
                                    string audioLang;
                                    if (outputSettings[i].audioLanguageCode[x] == "")
                                    {
                                        audioLang = "und";
                                    }
                                    else
                                    {
                                        audioLang = outputSettings[i].audioLanguageCode[x];
                                    }
                                    sb.Append(" --language 0:" + audioLang + " --no-chapters" +  
                                        (!String.IsNullOrWhiteSpace(outputSettings[i].videoTrackName) ? " --track-name 0:\"" + outputSettings[i].audioTrackName[x] + "\"" : "") +
                                        " \"Audio\\" + audioFilename + " Track " + (x + 1) + ".m4a\"");
                                }
                            }
                            sb.Append(Environment.NewLine + Environment.NewLine);
                        }
                        else
                        {
                            finishedFiles[i] = true;
                        }
                    }
                    k++;
                    bool allFinished = true;
                    for (int x = 0; x < finishedFiles.Length; x++)
                    {
                        if (finishedFiles[x] == false)
                        {
                            allFinished = false;
                        }
                    }
                    if (allFinished)
                    {
                        checkedAllTabs = true;
                    }
                }

                sb.Append("pause" + Environment.NewLine);
                File.WriteAllText(saveBatFileDialog.FileName, sb.ToString(), System.Text.Encoding.Default);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutBox = new FormAbout();
            aboutBox.ShowDialog();
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            openBenFile(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (paths.Length == 1 && Path.GetExtension(paths[0]) == ".ben" && !Directory.Exists(paths[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
