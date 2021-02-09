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

            fileAction(openFileDialog.FileName);
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
