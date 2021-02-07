using System;
using System.IO;

namespace SFTPConnectorLib.Controllers
{
    class FolderManager
    {
        public string FilePathCombine(string locPath, string rmPath)
        {
            rmPath = rmPath.Replace("/", "\\");
            //Console.WriteLine(rmPath);

            return Path.Combine(locPath, rmPath.Substring(1));
        }

        private string GetFolderPath(string path)
        {
            string res = "";
            string[] words = path.Split(new char[] { '\\' });

            for (int i = 1; i < words.Length - 1; i++)
            {
                res += "\\" + words[i];
            }

            return res;
        }

        public void CreateFolder(string path)
        {
            try
            {
                path = GetFolderPath(path);

                // Determine whether the directory exists
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory \"{0}\" was created successfully at {1}.", path, Directory.GetCreationTime(path));
            }
            finally { }
        }
    }

}
