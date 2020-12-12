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
    public partial class MainForm : Form
    {
        private ModuleManager ModuleManager { get; set; }
        public MainForm()
        {
            //ВСЕ КЛАССЫ SFTPConnectorModule ПРОСТАВИТЬ PUBLIC
            InitializeComponent();

        }

        private void InitData()
        {
            ModuleManager = new ModuleManager();
            this.TaskDataTable.DataSource = ModuleManager.TaskList;
        }

        private void lastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //УСТАНОВИТЬ ЗАНЧЕНИЕ ПУТИ ДО ФАЙЛА
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    Settings.SetCsvTaskFilePath(fileStream.Name);
                }

                ///
                InitData();
            }
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TaskDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Not enough data!");
                return;
            }

            ModuleManager.Downloading();
            TaskDataTable.Refresh();
        }

        //private void Downloading()
        //{
        //    var csvLog = new List<string>();
        //    //var excList = new List<Settings>();

        //    foreach (FileData fileData in TaskList)
        //    {
        //        try
        //        {
        //            SftpController.downloadFile(fileData);
        //            fileData.Status = "Succes";
        //        }
        //        catch (Exception e)
        //        {
        //            fileData.Status = e.Message;
        //            ExcList.Add(fileData);
        //        }
        //        finally
        //        {
        //            csvLog.Add(CsvController.CsvCompleteLogLine(fileData));

        //            CsvController.CsvWrite(CsvController.CsvCompleteLogLine(fileData), Settings.CsvLogListPath);
        //        }
        //    }

        //    //CsvController.CsvWriteLog(CsvLog);

        //}

    }
}
