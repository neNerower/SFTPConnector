using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFTPConnectorModule;

namespace Connector_SFTP_GUI_Prototip
{
    public partial class MainForm : Form
    {
        private IModuleManager ModuleManager { get; } = new ModuleManager();

        public MainForm()
        {
            //ВСЕ КЛАССЫ SFTPConnectorModule ПРОСТАВИТЬ PUBLIC
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UPLOADING DATA
            UploadTaskFile();
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DOWNLOADING FILES
            DownloadingAsync();
        }
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pauseToolStripMenuItem.Enabled = false;

            //ModuleManager.LockDownloading();
            continueToolStripMenuItem.Enabled = true;
        }
        private void continueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            continueToolStripMenuItem.Enabled = false;

            //ModuleManager.UnlockDownloading();
            pauseToolStripMenuItem.Enabled = true;
        }

        private void dropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HashProgrammPassword = "None";
            Properties.Settings.Default.Save();

            MessageBox.Show("Password dropped successfuly");
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewPassForm().ShowDialog();
        }

        ///
        ///
        ///

        private void UploadTaskFile()
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            //УСТАНОВИТЬ ЗАНЧЕНИЕ ПУТИ ДО ФАЙЛА
            using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
            {
                Settings.SetCsvTaskFilePath(fileStream.Name);
                openFileDialog.InitialDirectory = fileStream.Name.Replace(openFileDialog.FileName, "");
            }

            //ЗАГРУЗКА ДАННЫХ ИЗ НАЙДЕННОГО ФАЙЛА
            ModuleManager.UploadTaskList();
            this.TaskDataTable.DataSource = ModuleManager.GetTaskList();
        }

        async private void DownloadingAsync()
        {
            if (TaskDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Not enough data!");
                UploadTaskFile();
                return;//ВЫХОД ЕСЛИ ТАБЛИЦА НЕ СОДЕРЖИТ НИ ОДНОЙ СТРОКИ
            }

            //ВЫБОР ЛОКАЛЬНОЙ ДИРЕКТОРИИ ДЛЯ ЗАГРУЗКИ ФАЙЛОВ В НЕЕ
            if (!ChooseLocalFolder())
                return;

            //
            openToolStripMenuItem.Enabled = false;
            downloadToolStripMenuItem.Enabled = false;
            pauseToolStripMenuItem.Enabled = true;
            
            //
            //СКАЧИВАНИЕ ФАЙЛОВ
            await Task.Run(() => ModuleManager.Downloading((_) => RefreshTable()));

            //Thread DownloadingThread = new Thread(new ThreadStart(() => ModuleManager.Downloading((_) => RefreshTable())));
            //DownloadingThread.Start();
            //await Task.Run(() => DownloadingThread.Join());

            MessageBox.Show("Downloading successfuly finished");

            //
            openToolStripMenuItem.Enabled = true;
            downloadToolStripMenuItem.Enabled = true;
            pauseToolStripMenuItem.Enabled = false;
            continueToolStripMenuItem.Enabled = false;
        }

        private void RefreshTable()//ОБНОВЛЕНИЕ ДАННЫХ В ТАБЛИЦЕ
        {
            TaskDataTable.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                TaskDataTable.Refresh();
            });
        }

        private Boolean ChooseLocalFolder()
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return false;

            string path = folderBrowserDialog.SelectedPath;
            if (path == null)
                return false;

            //ЗАПИСЬ НОВОГО АДРЕСА ЛОКАЛЬНОЙ ДИРЕКТОРИИ В SETTINGS
            Settings.SetLocalFolderPath(path);
            Settings.SetCsvLogFilePath(Path.Combine(path, "csvLog.csv"));
            Settings.SetCsvExcListPath(Path.Combine(path, "csvExc.csv"));

            //ИЗМЕНЕНИЕ АДРЕСА ЛОКАЛЬНОЙ ДИРЕКТОРИИ В ДАННЫХ ТАБЛИЦЫ
            ModuleManager.ChangeLocalFolderPath();
            this.TaskDataTable.DataSource = ModuleManager.GetTaskList();
            this.TaskDataTable.Refresh();

            return true;
        }

    }
}
