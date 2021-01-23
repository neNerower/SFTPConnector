using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFTPConnectorModule
{
    internal class CsvLogger
    {
        private void Write(string logLine)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Settings.CsvLogFilePath, true, System.Text.Encoding.Default))
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
                            ",\"Host: " + fileData.Host + " User: " + fileData.Username + " Path: " + fileData.PathLocalFile + //host username localpath
                            "\"," + fileData.Status;//status
            Write(logLine);
        }
    }
}
