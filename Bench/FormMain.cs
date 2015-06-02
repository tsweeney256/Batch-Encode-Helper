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
        bool unsavedChanges;

        public FormMain()
        {
            InitializeComponent();

            appSettings = new AppSettings();
            outputSettings = new List<OutputSettings>();
            saveFileName = null;
            settingsTabCollection.OutputSettings = outputSettings;
            settingsTabCollection.ListBox = ListBox_Files;
            settingsTabCollection.LoadSettings(appSettings);
            settingsTabCollection.Enabled = false;
            settingsTabCollection.UnsavedChanges = false;
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
            AddToListBoxCommon(files);
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
            for (int i = ListBox_Files.SelectedIndices.Count-1; i >= 0; i--)
            {
                outputSettings.RemoveAt(ListBox_Files.SelectedIndices[i]);
                ListBox_Files.Items.RemoveAt(ListBox_Files.SelectedIndices[i]);
            }
            if (ListBox_Files.Items.Count == 0)
            {
                settingsTabCollection.Enabled = false;
                settingsTabCollection.LoadSettings(appSettings);
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
            if (ListBox_Files.SelectedIndices.Count == 1)
            {
                if (settingsTabCollection.UnsavedChanges)
                {
                    SaveSelectedIndices();
                    settingsTabCollection.UnsavedChanges = false;
                    unsavedChanges = true;
                }
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
                    outputSettings[index].noAudio = settingsTabCollection.CheckBoxNoAudio;
                    for (int i = 0; i < audioTabCount; i++)
                    {
                        outputSettings[index].quality[i] = settingsTabCollection.AudioTabList[i].NumericUpDown_Quality_Value;
                        outputSettings[index].audioTrackName[i] = settingsTabCollection.AudioTabList[i].TextBox_AudioTrackName_Text;
                        outputSettings[index].audioLanguageCode[i] = settingsTabCollection.AudioTabList[i].TextBox_LanguageCode_Text;
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
                settingsTabCollection.UnsavedChanges = false;
                unsavedChanges = false;
                using (Stream stream = File.Open(saveFileName, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
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
                using (Stream stream = File.Open(openEhFileDialog.FileName, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    try
                    {
                        outputSettings = (List<OutputSettings>)bformatter.Deserialize(stream);
                        settingsTabCollection.OutputSettings = outputSettings;
                        saveFileName = openEhFileDialog.FileName;
                        this.Text = Path.GetFileName(saveFileName) + " - " + this.Text;
                        for (int i = ListBox_Files.Items.Count - 1; i >= 0; i--)
                        {
                            ListBox_Files.Items.RemoveAt(i);
                        }
                        for (int i = 0; i < outputSettings.Count; i++)
                        {
                            ListBox_Files.Items.Add(outputSettings[i].FileName);
                        }
                        if (ListBox_Files.Items.Count > 0)
                        {
                            ListBox_Files.SelectedIndex = 0;
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
            for (int i = ListBox_Files.Items.Count - 1; i >= 0; i--)
            {
                ListBox_Files.Items.RemoveAt(i);
            }
            outputSettings = new List<OutputSettings>();
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
                            File.WriteAllText(generatedAvsFileFull, avisynthFileString, new UTF8Encoding(false));
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
                for (int i = 0; i < outputSettings.Count; i++)
                {
                    inputFile[i] = new string[outputSettings[i].x264Args.Length];
                }

                    SaveSelectedIndices();
                for(int i=0; i<outputSettings.Count; i++)
                {
                    for (int j = 0; j < outputSettings[i].x264Args.Length; j++)
                    {
                        inputFile[i][j] = outputSettings[i].FileName; //who needs silly things like performance
                    }
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
                    string filename = String.Format(outputSettings[i].fileNamePrefix[0] + outputSettings[i].fileNameBody + outputSettings[i].fileNameSuffix[0], fileCount[i]);
                    for (int j = 0; j < outputSettings[i].audioLanguageCode.Length; j++) //audiolanguagecode.length is equal to the number of tabs/audio tracks
                    {
                        if (!outputSettings[i].noAudio)
                        {
                            sb.Append("REM Audio " + filename + " Track " + (j + 1) + Environment.NewLine);
                            sb.Append("\"" + appSettings.BePipeLocation + "\" --script \"LWLibavAudioSource(^" + outputSettings[i].FileName + "^, stream_index=" + (j + 1) + ")\" | \"" +
                                appSettings.NeroAACLocation + "\" -q " + outputSettings[i].quality[j] + " -if - -of \"" + "Audio\\" + filename + " Track " + (j + 1) + ".m4a\""
                                + Environment.NewLine + Environment.NewLine);
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
                                " --track-name 0:\"" + outputSettings[i].videoTrackName +  "\" \"Videos\\" + filename + ".264\"");
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
                                    sb.Append(" --language 0:" + audioLang + " --no-chapters --track-name 0:\"" + outputSettings[i].audioTrackName[x] +
                                        "\" \"Audio\\" + audioFilename + " Track " + (x + 1) + ".m4a\"");
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
                File.WriteAllText(saveBatFileDialog.FileName, sb.ToString(), new UTF8Encoding(false));
            }
        }
    }
}
