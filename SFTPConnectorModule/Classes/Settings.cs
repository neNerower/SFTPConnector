using System;
using System.IO;

namespace SFTPConnectorModule
{
    public static class Settings
    {
        
        private static string HashProgrammPassword { get; set; } = "";
        public static string LocalFolderPath { get; private set; } = "C:\\Users\\User\\source\\test";
        public static string CsvTaskFilePath { get; private set; } = "csvList.csv";
        public static string CsvLogFilePath { get; private set; } = "csvLog.csv";

        //ВРЕМЕННО НЕ НЕСЕТ НИКАКОЙ ФУНКЦИОНАЛЬНОСТИ
        public static string CsvExcListPath { get; private set; } = "csvExc.csv";
        //
        
        public static string GetHashProgrammPassword()
        {
            return HashProgrammPassword;
        }
        public static void SetHashProgrammPassword(string hash)
        {
            HashProgrammPassword = hash;
        }

        public static void SetLocalFolderPath(string path)
        {
            LocalFolderPath = path;
        }
        public static void SetCsvTaskFilePath(string path)
        {
            CsvTaskFilePath = path;
        }
        public static void SetCsvLogFilePath(string path)
        {
            CsvLogFilePath = Path.Combine(path, "csvList.csv");
        }
        public static void SetCsvExcListPath(string path)
        {
            CsvExcListPath = Path.Combine(path, "csvExc.csv");
        }
    }
}
