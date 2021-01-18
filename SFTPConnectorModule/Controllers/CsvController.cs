using System;
using System.Collections.Generic;
using System.IO;

namespace SFTPConnectorModule
{
    public interface ICsvController
    {
        List<FileData> CsvReadTask();
        //void CsvWriteLog(List<string> csvList, string path);
        void CsvWrite(string csvLine, string path);
        string CsvCompleteLogLine(FileData fileData);

    }

    class CsvController : ICsvController
    {
        
        public List<FileData> CsvReadTask()
        {
            if (!File.Exists(Settings.CsvTaskFilePath))
            {
                return new List<FileData>();
                //File.Create(Settings.CsvTaskFilePath).Close();                
            }

            using (StreamReader streamReader = new StreamReader(Settings.CsvTaskFilePath))
            {
                var fileDataList = new List<FileData>();

                string line;
                int id = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    id++;

                    try
                    {
                        FileData fileData = CsvPars(line);
                        fileData.ID = id;

                        fileDataList.Add(fileData);
                    }
                    catch(Exception ex)
                    {
                        CsvWrite(DateTime.Now.ToString() + "," + id + ",\"" + line + "\"," + ex.Message, Settings.CsvLogFilePath);
                    }
                }

                return fileDataList;
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

        //public void CsvWriteLog(List<string> csvList, string path)
        //{
        //    try
        //    {
        //        using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
        //        {
        //            foreach (string line in csvList)
        //            {
        //                sw.WriteLine(line);
        //            }
        //        }
        //        Console.WriteLine($"{Path.GetFileName(path)} writing completed");
        //    }
        //    finally { }
        //}

        public void CsvWrite(string csvLine, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(csvLine);
                }
                Console.WriteLine($"Line wrote to {Path.GetFileName(path)}");
            }
            finally { }
        }

        public string CsvCompleteLogLine(FileData fileData)
        {
            return DateTime.Now.ToString() + "," + fileData.ID + ",\"Host: " + fileData.Host + " User: " + fileData.Username + " Path: " + fileData.PathLocalFile + "\"," + fileData.Status;
        }
    }
}
