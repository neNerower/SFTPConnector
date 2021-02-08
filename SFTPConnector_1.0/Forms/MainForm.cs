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
            fsGuide.BrowsFile(taskTable.SetTask);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fsGuide.BrowsFolder(taskTable.SetBaseFolder);
        }
    }
}
