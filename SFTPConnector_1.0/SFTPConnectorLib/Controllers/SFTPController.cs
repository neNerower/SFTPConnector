using Renci.SshNet;
using SFTPConnectorLib.Models;
using System;
using System.IO;

namespace SFTPConnectorLib.Controllers
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
                    using (Stream fileStream = File.OpenWrite(fileData.LocalFilePath))
                    {
                        sftp.DownloadFile(fileData.LocalFilePath, fileStream);
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