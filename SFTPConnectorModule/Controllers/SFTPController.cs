using Renci.SshNet;
using System;
using System.IO;

namespace SFTPConnectorModule
{
    class SFTPController
    {
        public void downloadFile(FileData fileData)
        {
            using (SftpClient sftp = new SftpClient(fileData.Host, fileData.Username, fileData.Password))
            {
                try
                {
                    sftp.Connect();
                    using (Stream fileStream = File.OpenWrite(fileData.PathLocalFile))
                    {
                        sftp.DownloadFile(fileData.PathRemoteFile, fileStream);
                    }
                    sftp.Disconnect();
                }
                //catch (Exception er)
                //{
                //    Console.WriteLine("\n\nAn exception has been caught " + er.ToString());
                //}
                finally { }
            }

        }
    }
}
