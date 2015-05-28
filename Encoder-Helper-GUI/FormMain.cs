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
            settingsTabCollection.OutputSettings = outputSettings;
            settingsTabCollection.ListBox = ListBox_Files;
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
            appSettings = new AppSettings();
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
                for (int i = 0; i < settingsTabCollection.VideoTabList.Count; i++)
                {
                    var size = new Size();
                    size.Width = settingsTabCollection.Size.Width - 32;
                    size.Height = settingsTabCollection.VideoTabList[i].PanelVideoTabSize.Height;
                    settingsTabCollection.VideoTabList[i].PanelVideoTabSize = size;
                }
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
                outputSettings[index].fileNamePrefix = new string[vidTabCount];
                outputSettings[index].fileNameBody = new string[vidTabCount];
                outputSettings[index].fileNameSuffix = new string[vidTabCount];
                for (int i = 0; i < vidTabCount; i++ )
                {
                    outputSettings[index].x264Args[i] = settingsTabCollection.VideoTabList[i].TextBox_x264_Args_Text;
                    outputSettings[index].encoder[i] = settingsTabCollection.VideoTabList[i].ComboBox_Encoder_SelectedIndex;
                    outputSettings[index].fileNamePrefix[i] = settingsTabCollection.VideoTabList[i].FileNamePrefixText;
                    outputSettings[index].fileNameBody[i] = settingsTabCollection.VideoTabList[i].FileNameBodyText;
                    outputSettings[index].fileNameSuffix[i] = settingsTabCollection.VideoTabList[i].FileNameSuffixText;
                }
                outputSettings[index].videoTrackName = settingsTabCollection.TextBox_VideoTrackName_Text;
                outputSettings[index].videoLanguageCode = settingsTabCollection.TextBox_VideoLanguageCode_Text;
                outputSettings[index].avisynthTemplate = settingsTabCollection.TextBox_AvisynthTemplate_Text;
                outputSettings[index].counterIndex = settingsTabCollection.ComboBoxCounterSelectedIndex;
                outputSettings[index].counterValue = settingsTabCollection.NumericUpDownCounterValue;

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
            int idx = outputSettings[selectedIndicesToSave[0]].counterIndex;
            for (int i = 0; i < outputSettings.Count; i++)
            {
                if (outputSettings[i].counterIndex == idx)
                {
                    outputSettings[i].counterValue = settingsTabCollection.NumericUpDownCounterValue; ;
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
                var result = saveEhFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    saveFileName = saveEhFileDialog.FileName;
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
                        settingsTabCollection.OutputSettings = outputSettings;
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

        private bool handleAvisynthTemplates(string[] inputFile) //just for organizational convenience
        {
            int avisynthCounter = 1;
            bool alreadyCreatedDirectory = false;

            for (int i = 0; i < outputSettings.Count; i++)
            {
                string avisynthFileString;
                if (outputSettings[i].avisynthTemplate != "")
                {
                    try
                    {
                        avisynthFileString = String.Format(File.ReadAllText(outputSettings[i].avisynthTemplate), "\"" + outputSettings[i].FileName + "\"");
                    }
                    catch(FileNotFoundException)
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
                    inputFile[i] = generatedAvsFileShort;
                    try
                    {
                        File.WriteAllText(generatedAvsFileFull, avisynthFileString);
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("There was an error making one of the generated avisynth files: " + e.Message);
                        return false;
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
                string[] inputFile = new string[outputSettings.Count];

                for(int i=0; i<outputSettings.Count; i++)
                {
                    inputFile[i] = outputSettings[i].FileName;
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
                    string filename = String.Format(outputSettings[i].fileNamePrefix[0] + outputSettings[i].fileNameBody[0] + outputSettings[i].fileNameSuffix[0], fileCount[i]);
                    for (int j = 0; j < outputSettings[i].audioLanguageCode.Length; j++) //audiolanguagecode.length is equal to the number of tabs/audio tracks
                    {
                        sb.Append("REM Audio " + filename + " Track " + (j+1) + Environment.NewLine);
                        sb.Append("\"" + appSettings.BePipeLocation + "\" --script \"LWLibavAudioSource(^" + outputSettings[i].FileName + "^, stream_index=" + (j+1) + ")\" | \"" +
                            appSettings.NeroAACLocation + "\" -q " + outputSettings[i].quality[j] + " -if - -of \"" + "Audio\\" + filename + " Track " + (j+1) + ".m4a\"" 
                            + Environment.NewLine + Environment.NewLine);
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
                            string filename = String.Format(outputSettings[i].fileNamePrefix[k] + outputSettings[i].fileNameBody[k] + outputSettings[i].fileNameSuffix[k], fileCount[i]);
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
                            string audioFilename = String.Format(outputSettings[i].fileNamePrefix[0] + outputSettings[i].fileNameBody[0] + outputSettings[i].fileNameSuffix[0], fileCount[i]);
                            sb.Append("REM Video " + filename + Environment.NewLine);
                            sb.Append("\"" + x264 + "\" --output \"Videos\\" + filename + ".264\" " + outputSettings[i].x264Args[k] + " \"" 
                                + inputFile[i] + "\"" + Environment.NewLine + Environment.NewLine);
                            sb.Append("REM Mux " + filename + Environment.NewLine);
                            sb.Append("\"" + appSettings.MKVMergeLocation + "\" -o \"Muxed\\" + filename + ".mkv\" --language 0:" + vidLang + 
                                " --track-name 0:\"" + outputSettings[i].videoTrackName +  "\" \"Videos\\" + filename + ".264\"");
                            for (int x = 0; x < outputSettings[i].audioLanguageCode.Length; x++)
                            {
                                string audioLang;
                                if(outputSettings[i].audioLanguageCode[x] == ""){
                                    audioLang = "und";
                                }
                                else
                                {
                                    audioLang = outputSettings[i].audioLanguageCode[x];
                                }
                                sb.Append(" --language 0:" + audioLang + " --no-chapters --track-name 0:\"" + outputSettings[i].audioTrackName[x] + 
                                    "\" \"Audio\\" + audioFilename + " Track " + (x+1) + ".m4a\"");
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
                File.WriteAllText(saveBatFileDialog.FileName, sb.ToString(), Encoding.ASCII);
            }
        }
    }
}
