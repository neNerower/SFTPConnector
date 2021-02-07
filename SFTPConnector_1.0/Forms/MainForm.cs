using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFTPConnector_1._0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (openFileDialog.ShowDialog() != DialogResult.OK)
            //    return;

            ////УСТАНОВИТЬ ЗАНЧЕНИЕ ПУТИ ДО ФАЙЛА
            //using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
            //{
            //    Settings.SetCsvTaskFilePath(fileStream.Name);
            //    openFileDialog.InitialDirectory = fileStream.Name.Replace(openFileDialog.FileName, "");
            //}
            //string taskPath = fileSy

            ////ЗАГРУЗКА ДАННЫХ ИЗ НАЙДЕННОГО ФАЙЛА
            //taskTable.LoadTask(taskPath);

        }
    }
}
