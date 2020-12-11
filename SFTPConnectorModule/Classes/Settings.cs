using System;
using System.IO;

namespace SFTPConnectorModule
{
    public static class Settings
    {
        private static string HashProgrammPassword { get; set; } = "";
        public static string LocalFolderPath { get; set; } = "C:\\Users\\User\\source\\test";
        public static string CsvTaskFilePath { get; set; } = "csvList.csv";
        public static string CsvLogFilePath { get; set; } = "csvLog.csv";
        public static string CsvExcListPath { get; set; } = "csvExc.csv";

        public static string GetHashProgrammPassword()
        {
            return HashProgrammPassword;
        }
        public static void SetHashProgrammPassword(string hash)
        {
            HashProgrammPassword = hash;
        }
    }
}
