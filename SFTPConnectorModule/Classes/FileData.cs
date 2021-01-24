using System;

namespace SFTPConnectorModule
{
    public class FileData
    {
        public int ID { get; set; }
        public string Host { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string PathRemoteFile { get; private set; }
        public string PathLocalFile { get; private set; }
        public string Status { get; set; }

        public FileData(string host, string username, string password, string pathRemoteFile)
        {
            InitMembers(host, username, password, pathRemoteFile);
        }

        private void InitMembers(string host, string username, string password, string pathRemoteFile)
        {
            Host = host;
            Username = username;
            Password = password;
            PathRemoteFile = pathRemoteFile;
            SetLocalPath();
            Status = "Waiting";
        }

        public void SetLocalPath()
        {
            var dm = new DirectoryManager();

            PathLocalFile = dm.RmPathCombiner(Settings.LocalFolderPath + "\\" + Host, PathRemoteFile);
        }
    }
}
