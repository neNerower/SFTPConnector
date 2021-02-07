using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFTPConnectorLib.Models;

namespace SFTPConnector_1._0.UserControls
{
    public partial class TaskTable : UserControl
    {
        private readonly TaskList _taskList = new TaskList();

        public TaskTable()
        {
            InitializeComponent();

            taskDataTable.DataSource = _taskList;
        }

    }
}
