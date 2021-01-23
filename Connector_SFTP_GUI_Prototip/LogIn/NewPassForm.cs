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
    public partial class NewPassForm : Form
    {
        public NewPassForm()
        {
            InitializeComponent();
        }

        private void SavePasswordButton_Click(object sender, EventArgs e)
        {
            SavePassword();
        }

        private void SavePassword()
        {
            if (this.PasswordTextBox.Text == this.ConfirmPasswordTextBox.Text)
            {
                ILogInController logInController = new LogInController();
                logInController.SetNewPassword(PasswordTextBox.Text);

                Properties.Settings.Default.HashProgrammPassword = Settings.GetHashProgrammPassword();
                Properties.Settings.Default.Save();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                PasswordLabel.Text = "Try again";
                PasswordTextBox.Text = "";
                ConfirmPasswordTextBox.Text = "";
            }
        }

    }
}
