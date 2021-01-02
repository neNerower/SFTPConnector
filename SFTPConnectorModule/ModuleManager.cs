using System;
using System.Collections.Generic;
using System.IO;

namespace SFTPConnectorModule
{
    public interface IModuleManager
    {
        void Downloading();
        void UploadTaskList();
        List<FileData> GetTaskList();

    }
    public class ModuleManager : IModuleManager
    {
        private SFTPController SftpController { get; set; }
        private CsvController CsvController { get; set; }
        private List<FileData> TaskList { get; set; }
        private Boolean TaskListUploadFlag { get; set; } = false;

        public ModuleManager()
        {
            InitControllers();
        }

        private void InitControllers()
        {
            SftpController = new SFTPController();
            CsvController = new CsvController();
        }

        public void UploadTaskList()
        {
            //загрузка данных из csv-файла в TaskList
            TaskList = CsvController.CsvReadTask();
            TaskListUploadFlag = true;
        }
        public List<FileData> GetTaskList()
        {
            if (TaskListUploadFlag)
            {
                return TaskList;
            }

            return new List<FileData>();
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
