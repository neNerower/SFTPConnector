using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void FillActualSettings()
        {
            this.LocalFolderPathTextBox.Text = Settings.LocalFolderPath;
            this.CsvTaskFilePathTextBox.Text = Settings.CsvTaskFilePath;
            this.CsvLogFilePathTextBox.Text = Settings.CsvLogFilePath;
            this.CsvExcFilePathTextBox.Text = Settings.CsvExcListPath;
        }
        private void SaveActualSettings()
        {
            Settings.SetLocalFolderPath(this.LocalFolderPathTextBox.Text);
            Settings.SetCsvTaskFilePath(this.CsvTaskFilePathTextBox.Text);
            Settings.SetCsvLogFilePath(this.CsvLogFilePathTextBox.Text);
            Settings.SetCsvExcListPath(this.CsvExcFilePathTextBox.Text);
        }
        private void SetDefaultSettings()
        {
            Settings.SetLocalFolderPath("");
            Settings.SetCsvTaskFilePath("");
            Settings.SetCsvLogFilePath("");
            Settings.SetCsvExcListPath("");
            FillActualSettings();
        }
        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            SaveActualSettings();
            //SaveSettingsFile();
            //Save to config file
            this.Close();
        }

        //
        //OpenFileDialod\SaveFileDialog | FolderBrowserDialog
        //Использовать контрол для вызова системного окна поиска ShowDialog
        //
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
            Settings.SetLocalFolderPath(path);
            Settings.SetCsvLogFilePath(path);
            Settings.SetCsvExcListPath(path);
            //No(just)
            //Settings.SetCsvTaskFilePath(path);

            FillActualSettings();
        }
        // ..FolderPathChange.._Click(..)
        //For CsvLogFilePath
        //For CsvExcListPath
    }
}
