using SFTPConnectorLib.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace SFTPConnectorLib.Tools
{
    internal class CsvTaskReader
    {
        private readonly string _taskFilePath;

        public CsvTaskReader(string path)
        {
            _taskFilePath = path;
        }

        public IEnumerable<FileData> Read()
        {
            if (!File.Exists(_taskFilePath))
                return new List<FileData>();

            using (StreamReader streamReader = new StreamReader(_taskFilePath))
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
