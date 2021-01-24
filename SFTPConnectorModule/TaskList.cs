using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFTPConnectorModule
{
    public class TaskList
    {
        private List<FileData> Tasks { get; set; }

        public TaskList()
        {
            Tasks = new List<FileData>();
        }

        public void UploadTaskList()
        {
            //загрузка данных из csv-файла в Tasks
            var taskReader = new CsvTaskReader();
            Tasks = taskReader.Read();
        }
        public List<FileData> GetTasks()
        {
            return Tasks;//EMPTY LIST IF IT WASNT UPLOADED ALREADY
        }

        public void UpdateLocalPath()
        {
            foreach (FileData fileData in Tasks)
            {
                fileData.SetLocalPath();
            }
        }
    }
}
