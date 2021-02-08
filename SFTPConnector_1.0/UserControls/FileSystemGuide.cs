using System;
using System.IO;
using System.Windows.Forms;

namespace SFTPConnector_1._0.UserControls
{
    public partial class FileSystemGuide : UserControl
    {
        public FileSystemGuide()
        {
            InitializeComponent();
        }

        public void BrowsFile(Action<string> fileAction)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            //УСТАНОВИТЬ ЗАНЧЕНИЕ ПУТИ ДО ФАЙЛА
            string filePath;
            using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
            {
                filePath = fileStream.Name;
                openFileDialog.InitialDirectory = filePath.Replace(openFileDialog.FileName, "");
            }
            fileAction(filePath);
        }

        public void BrowsFolder(Action<string> folderAction)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;

            string folderPath = folderBrowserDialog.SelectedPath;
            if (folderPath == null)
                return;

            //ИЗМЕНЕНИЕ АДРЕСА ЛОКАЛЬНОЙ ДИРЕКТОРИИ В ДАННЫХ ТАБЛИЦЫ
            folderAction(folderPath);            
        }
    }
}
