using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFTPConnectorModule
{
    internal class CsvTaskReader
    {
        public List<FileData> Read()
        {
            if (!File.Exists(Settings.CsvTaskFilePath))
                return new List<FileData>();

            using (StreamReader streamReader = new StreamReader(Settings.CsvTaskFilePath))
            {
                var taskList = new List<FileData>();
                string line;
                int id = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    id++;

                    try
                    {
                        FileData fileData = CsvPars(line);
                        fileData.ID = id;

                        taskList.Add(fileData);
                    }
                    catch (Exception ex)
                    {
                        //Write log line
                        //CsvWrite(DateTime.Now.ToString() + "," + id + ",\"" + line + "\"," + ex.Message, Settings.CsvLogFilePath);
                    }
                }

                return taskList;
            }
        }

        private FileData CsvPars(string str)
        {
            string[] arguments = str.Split(new char[] { ',' });
            if (arguments.Length == 4)
            {
                return new FileData(arguments[0], arguments[1], arguments[2], arguments[3]);
            }

            throw new Exception("Not enough arguments to complete fileData");
        }
    }
}
