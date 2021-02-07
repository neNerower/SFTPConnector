using SFTPConnectorLib.Models;
using System;
using System.IO;

namespace SFTPConnectorLib.Controllers
{
    internal class CsvLogger
    {
        private readonly string _logFilePath;

        public CsvLogger(string path)
        {
            _logFilePath = path;
        }

        private void Write(string logLine)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_logFilePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(logLine);
                }
                //Console.WriteLine($"Line wrote to {Path.GetFileName(path)}");
            }
            finally { }
        }

        public void LogLine(FileData fileData)
        {
            string logLine = DateTime.Now.ToString() + "," + fileData.ID + //log time and fileData ID 
                            ",\"Host: " + fileData.Host + " User: " + fileData.Username + " Path: " + fileData.LocalFilePath + //host username localpath
                            "\"," + fileData.Status;//status
            Write(logLine);
        }
    }
}