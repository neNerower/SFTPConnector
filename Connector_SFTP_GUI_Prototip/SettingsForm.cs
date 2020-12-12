using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFTPConnectorModule;

namespace Connector_SFTP_GUI_Prototip
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            FillActualSettings();
        }

        private void FillActualSettings()//Fill textBoxes data from file .settings
        {
            this.LocalFolderPathTextBox.Text = Properties.Settings.Default.LocalFolderPath;
            this.CsvTaskFilePathTextBox.Text = Properties.Settings.Default.CsvTaskFilePath;
            this.CsvLogFilePathTextBox.Text = Properties.Settings.Default.CsvLogFilePath;
            this.CsvExcFilePathTextBox.Text = Properties.Settings.Default.CsvExcListPath;
        }
        private void UseActualSettings()//Get settings data from FormControls to SettingsClass
        {
            Settings.SetLocalFolderPath(this.LocalFolderPathTextBox.Text);
            Settings.SetCsvTaskFilePath(this.CsvTaskFilePathTextBox.Text);
            Settings.SetCsvLogFilePath(this.CsvLogFilePathTextBox.Text);
            Settings.SetCsvExcListPath(this.CsvExcFilePathTextBox.Text);
        }
        private void SaveActualSettings()//Save settings data from FormControls to file .settings
        {
            Properties.Settings.Default.LocalFolderPath = this.LocalFolderPathTextBox.Text;
            Properties.Settings.Default.CsvTaskFilePath = this.CsvTaskFilePathTextBox.Text;
            Properties.Settings.Default.CsvLogFilePath = this.CsvLogFilePathTextBox.Text;
            Properties.Settings.Default.CsvExcListPath = this.CsvExcFilePathTextBox.Text;
            Properties.Settings.Default.Save();
        }


        //Get data to SettingsClass
        //Save to config file
        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            UseActualSettings();
            SaveActualSettings();
            this.Close();
        }

        //OpenFileDialod\SaveFileDialog | FolderBrowserDialog
        //Использовать контрол для вызова системного окна поиска -> ShowDialog
        private string GetFolderPath()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return null;

            return folderBrowserDialog.SelectedPath;
        }

        private void LocalFolderPathChangeButton_Click(object sender, EventArgs e)
        {
            string path = GetFolderPath();
            if (path == null)
                return;

            //ASQ FORM (yes/no)
            //Set all paths ??
            //Yes(all)
            this.LocalFolderPathTextBox.Text = path;
            this.CsvLogFilePathTextBox.Text = Path.Combine(path, "csvLog.csv");
            this.CsvExcFilePathTextBox.Text = Path.Combine(path, "csvExc.csv");
            //No(just)
            //Settings.SetCsvTaskFilePath(path);

            UseActualSettings();
            SaveActualSettings();
        }
        // ..FolderPathChange.._Click(..)
        //For CsvLogFilePath
        //For CsvExcListPath
    }
}
