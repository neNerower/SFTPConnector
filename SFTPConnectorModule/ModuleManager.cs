using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace SFTPConnectorModule
{
    public delegate void CompletionHandler(params Object[] args);

    public interface IModuleManager
    {
        void Downloading(CompletionHandler handler);

        void UploadTaskList();
        void UpdateLocalFolderPath();
        List<FileData> GetTaskList();

    }

    public class ModuleManager : IModuleManager
    {
        private SFTPController SftpController { get; set; }
        private CsvController CsvController { get; set; }
        private DirectoryManager DirectoryManager { get; set; }
        private List<FileData> TaskList { get; set; }
        private bool Is_TaskListUpload { get; set; } = false;
        private bool Is_AbleToDownload { get; set; }

        public ModuleManager()
        {
            InitControllers();
        }

        private void InitControllers()
        {
            SftpController = new SFTPController();
            CsvController = new CsvController();
            DirectoryManager = new DirectoryManager();
        }

        public void UploadTaskList()
        {
            //загрузка данных из csv-файла в TaskList
            TaskList = CsvController.CsvReadTask();
            Is_TaskListUpload = true;
        }
        public List<FileData> GetTaskList()
        {
            if (Is_TaskListUpload)
                return TaskList;//EMPTY LIST IF IT WASNT UPLOADED ALREADY

            return new List<FileData>();//RETURNS ACTUAL TASK LIST
        }

        public void UpdateLocalFolderPath()
        {
            foreach (FileData fileData in TaskList)//ДЛЯ КАЖДОЙ ЗАПИСИ ИЗ СПИСКА ЗАДАЧ
            {
                fileData.SetPath(fileData.PathRemoteFile);
            }
        }

        private void DownloadFile(FileData fileData, CompletionHandler handler)
        {
            if (fileData.Status == "Succes")
                return;

            try
            {
                DirectoryManager.MkDir(fileData.PathLocalFile);//СОЗДАНИЕ ЛОКАЛЬНОЙ ДИРЕКТОРИИ ДЛЯ ХРАНЕНИЯ ФАЙЛА

                if (!File.Exists(fileData.PathLocalFile))//ЕСЛИ ФАЙЛ С ТАКИМ ИМЕНЕМ ЕЩЕ НЕ БЫЛ СОЗДАН
                {
                    SftpController.downloadFile(fileData);//DOWNLOADING FILE
                    fileData.Status = "Succes";
                }
                else fileData.Status = "File exists already";
            }
            catch (Exception e)
            {
                fileData.Status = e.Message;
            }
            finally
            {
                //WRITE LINE TO LOG FILE (CHECK THE STATUS)
                CsvController.CsvWrite(CsvController.CsvCompleteLogLine(fileData), Settings.CsvLogFilePath);
                handler();//HANDLER FOR REFRESHING UI-TABLE AFTER EACH ETERATION
            }
        }

        public void Downloading(CompletionHandler handler)
        {
            foreach (FileData fileData in TaskList)//ДЛЯ КАЖДОЙ ЗАПИСИ ИЗ СПИСКА ЗАДАЧ
            {
                DownloadFile(fileData, handler);
                //downloadingThreads.Add(new Thread(() => DownloadFile(fileData, handler)));
                //downloadingThreads[downloadingThreads.Count - 1].Start();
            }
        }
    }
}