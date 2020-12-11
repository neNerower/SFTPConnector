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
            Settings.LocalFolderPath = this.LocalFolderPathTextBox.Text;
            Settings.CsvTaskFilePath = this.CsvTaskFilePathTextBox.Text;
            Settings.CsvLogFilePath = this.CsvLogFilePathTextBox.Text;
            Settings.CsvExcListPath = this.CsvExcFilePathTextBox.Text;
        }
        private void SetDefaultSettings()
        {
            Settings.LocalFolderPath = "C:\\Users\\User\\source\\test";
            Settings.CsvTaskFilePath = "csvList.csv";
            Settings.CsvLogFilePath = "csvLog.csv";
            Settings.CsvExcListPath = "csvExc.csv";
            FillActualSettings();
        }
        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            SaveActualSettings();
            this.Close();
        }

        //
        //ОБЩИЙ МЕТОД ДЛЯ ВСЕХ PATH_BUTTON 
        //OpenFileDialod\SaveFileDialog | FolderBrowserDialog
        //Использовать контрол для вызова системного окна поиска ShowDialog
        //
        private void GetFilePath()
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            //string filePath = openFileDialog.
        }
    }
}
