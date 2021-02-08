using SFTPConnectorLib.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SFTPConnectorLib.Models
{
    public class TaskList
    {
        private List<FileData> tasks;

        public TaskList()
        {
            tasks = new List<FileData>();
        }

        public IEnumerable<FileData> GetTasks()
        {
            return tasks;//EMPTY LIST IF IT WASNT UPLOADED ALREADY
        }
        public void SetTask(string taskFilePath)
        {
            //загрузка данных из csv-файла в Tasks
            var taskReader = new CsvTaskReader(taskFilePath);
            tasks = taskReader.Read().ToList();
        }

        public void SetBaseFolder(string basePath)
        {
            foreach (FileData fileData in tasks)
            {
                fileData.SetLocalPath(basePath);
            }
        }
    }
}