using System;
using System.Collections.Generic;
using System.IO;

namespace SFTPConnectorModule
{
    public interface IModuleManager
    {
        void Downloading();

    }
    public class ModuleManager : IModuleManager
    {
        private SFTPController SftpController { get; set; }
        private CsvController CsvController { get; set; }
        public List<FileData> TaskList { get; set; }

        public ModuleManager()
        {
            InitControllers();
            InitLists();
            
        }

        private void InitControllers()
        {
            SftpController = new SFTPController();
            CsvController = new CsvController();

        }
        private void InitLists()
        {
            //загрузка данных из csv-файла в TaskList
            TaskList = CsvController.CsvReadTask();

            //TaskList = new List<FileData>();
            //TaskList.Add(new FileData("host", "username", "password", "pathRemoteFile"));
            //TaskList.Add(new FileData("host1", "username1", "password1", "pathRemoteFile1"));
        }
        
        public void Downloading()
        {
            foreach (FileData fileData in TaskList)
            {
                try
                {
                    SftpController.downloadFile(fileData);
                    fileData.Status = "Succes";
                }
                catch (Exception e)
                {
                    fileData.Status = e.Message;
                }
                finally
                {
                    CsvController.CsvWrite(CsvController.CsvCompleteLogLine(fileData), Settings.CsvLogFilePath);
                }
            }

            //CsvController.CsvWriteLog(CsvLog);

        }
    }
}
