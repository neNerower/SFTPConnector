using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFTPConnectorModule;

namespace Connector_SFTP_GUI_Prototip
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            GetActualPasswordHash();
            IfPassNotSetted();

        }

        private void GetActualPasswordHash()
        {
            Settings.SetHashProgrammPassword(Properties.Settings.Default.HashProgrammPassword);
        }
        private void IfPassNotSetted()
        {
            if (Settings.GetHashProgrammPassword() == "None")
                NewPasswordButton.Visible = true;

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void LogIn()
        {
            ILogInController logInController = new LogInController();

            if (logInController.CheckPassword(this.PasswordTextBox.Text))
            {
                this.PasswordLabel.Text = "Done";
                this.PasswordTextBox.Enabled = false;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.PasswordTextBox.Text = "";
                this.PasswordLabel.Text = "Try again";
            }
        }

        private void NewPasswordButton_Click(object sender, EventArgs e)
        {
            if (new NewPassForm().ShowDialog() == DialogResult.OK)
                NewPasswordButton.Visible = false;
        }

    }
}
