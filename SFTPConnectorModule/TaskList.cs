using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFTPConnectorModule
{
    public class TaskList
    {
        private CsvTaskReader TaskReader { get; set; }
        private List<FileData> Tasks { get; set; }

        public TaskList()
        {
            TaskReader = new CsvTaskReader();
            Tasks = new List<FileData>();
        }

        public void UploadTaskList()
        {
            //загрузка данных из csv-файла в TaskList
            Tasks = TaskReader.Read();
        }
        public List<FileData> GetTasks()
        {
            return Tasks;//EMPTY LIST IF IT WASNT UPLOADED ALREADY
        }

        public void UpdateLocalPath()
        {
            foreach (FileData fileData in Tasks)//FOR EACH FROM TASKLIST
            {
                fileData.SetPath(fileData.PathRemoteFile);
            }
        }
    }
}
