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
        private readonly TaskList _taskList  = new TaskList();
        private readonly ModuleManager _moduleManager = new ModuleManager();
        private Thread downloadingThread;

        public MainForm()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UPLOADING DATA
            UploadTaskFile();
        }
        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DOWNLOADING FILES
            DownloadingAsync();
        }
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopDownloading();
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
            _taskList.UploadTaskList();
            this.TaskDataTable.DataSource = _taskList.GetTasks();
        }

        private bool ChooseLocalFolder()
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
            _taskList.UpdateLocalPath();
            this.TaskDataTable.DataSource = _taskList.GetTasks();
            this.TaskDataTable.Refresh();

            return true;
        }

        async private void DownloadingAsync()
        {
            if (TaskDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Not enough data!");
                UploadTaskFile();
                return;
            }

            //ВЫБОР ЛОКАЛЬНОЙ ДИРЕКТОРИИ ДЛЯ ЗАГРУЗКИ ФАЙЛОВ В НЕЕ
            if (!ChooseLocalFolder())
                return;

            //
            openToolStripMenuItem.Enabled = false;
            runToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = true;

            //СКАЧИВАНИЕ ФАЙЛОВ
            //await Task.Run(() => ModuleManager.Downloading((_) => RefreshTable()));
            downloadingThread = new Thread(new ThreadStart(() => _moduleManager.Downloading(_taskList.GetTasks(), (_) => RefreshTable())));
            downloadingThread.Start();
            await Task.Run(() => downloadingThread.Join());

            MessageBox.Show("Downloading finished");
            //
            openToolStripMenuItem.Enabled = true;
            runToolStripMenuItem.Enabled = true;
            stopToolStripMenuItem.Enabled = false;
        }
        private void RefreshTable()//ОБНОВЛЕНИЕ ДАННЫХ В ТАБЛИЦЕ
        {
            TaskDataTable.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                TaskDataTable.Refresh();
            });
        }

        private void StopDownloading()
        {
            downloadingThread.Abort();
        }
    }
}
