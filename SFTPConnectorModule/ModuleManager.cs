using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace SFTPConnectorModule
{
    public delegate void CompletionHandler(params Object[] args);

    public class ModuleManager
    {
        private SFTPController SftpController { get; set; }
        private DirectoryManager DirectoryManager { get; set; }
        private CsvLogger Logger { get; set; }

        public ModuleManager()
        {
            SftpController = new SFTPController();
            DirectoryManager = new DirectoryManager();
            Logger = new CsvLogger();
        }


        public void Downloading(IEnumerable<FileData> taskList, CompletionHandler handler)
        {
            foreach (FileData fileData in taskList)//ДЛЯ КАЖДОЙ ЗАПИСИ ИЗ СПИСКА ЗАДАЧ
            {
                DownloadFile(fileData);

                //WRITE LINE TO LOG FILE (CHECK THE STATUS)
                Logger.LogLine(fileData);
                handler();//HANDLER FOR REFRESHING UI-TABLE AFTER EACH ETERATION
            }
        }

        private void DownloadFile(FileData fileData)
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
        }
    }
}