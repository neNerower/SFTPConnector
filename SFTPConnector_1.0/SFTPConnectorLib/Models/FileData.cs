using SFTPConnectorLib.Controllers;
using System;

namespace SFTPConnectorLib.Models
{
    public class FileData
    {
        public int ID { get; set; }
        public string Host { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string RemoteFilePath { get; private set; }
        public string LocalFilePath { get; private set; } //This prop init just in SetLocalPath function
        public string Status { get; set; }

        public FileData(string host, string username, string password, string remotePath)
        {
            Host = host;
            Username = username;
            Password = password;
            RemoteFilePath = remotePath;
            Status = "Waiting";
        }

        public void SetLocalPath(string basePath)
        {
            var dm = new FolderManager();

            LocalFilePath = dm.FilePathCombine(basePath + "\\" + Host, RemoteFilePath);
        }
    }
}
