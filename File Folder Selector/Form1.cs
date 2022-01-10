using File_Folder_Selector.Structs;
using File_Folder_Selector.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Folder_Selector
{
    /// <summary>
    /// This winforms will be used for the second extension command.
    /// in the project menu there will be a Zip options button.
    /// it will allow you to select other files/folders to exclude as well as include
    /// </summary>
    public partial class Form1 : Form
    {
        private Settings settings;

        public Form1()
        {
            InitializeComponent();
            settings = new Settings();
            mainListBox.DataSource = GetListString();
            zipFolderCheckBox.Checked = settings.Options.CreateZipFolder;
        }

        private IEnumerable<string> GetListString()
        {
            var list = settings.Options.FileDirSettings;
            var output = list.Keys.ToList();
            for (int i = 0; i < output.Count; i++)
            {
                output[i] = $"{(list[output[i]] ? '✅' : '❎')}{output[i]}";
            }
            return output;
        }

        private void AddExclusion(string value)
        {
            value = value.TrimStart(' ').TrimEnd(' ');

            if (settings.Options.FileDirSettings.ContainsKey(value))
                return;

            settings.Options.FileDirSettings.Add(value, true);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            settings.Save();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("All unsaved data will perish. Do you want to exit?", "Warning!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var queued = toAddTextBox.Text.Split(new string[] { ", ", "," }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in queued)
            {
                AddExclusion(item);            
            }

            mainListBox.DataSource = GetListString();
            toAddTextBox.Clear();
        }

        private void mainListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainListBox.SelectedIndex != -1)
            {
                removeBtn.Enabled = true;
                alterBtn.Enabled = true;
            }
            else
            {
                removeBtn.Enabled = false;
                alterBtn.Enabled = false;
            }
        }

        private void zipFolderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            settings.Options.CreateZipFolder = zipFolderCheckBox.Checked;
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AddExclusion(dialog.SafeFileName);
            }

            mainListBox.DataSource = GetListString();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var index = mainListBox.Items[mainListBox.SelectedIndex].ToString().Remove(0, 1);
            settings.Options.FileDirSettings.Remove((string)index);

            mainListBox.DataSource = GetListString();
        }

        private void alterBtn_Click(object sender, EventArgs e)
        {
            var index = mainListBox.Items[mainListBox.SelectedIndex].ToString().Remove(0, 1);
            //settings.Options.FileDirSettings[(string)index] = !settings.Options.FileDirSettings[(string)index];
            settings.Options.FileDirSettings[index] ^= true;

            mainListBox.DataSource = GetListString();
        }
    }
}
