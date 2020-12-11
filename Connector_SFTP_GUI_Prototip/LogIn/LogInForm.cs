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
            IfPassNotSetted();

        }

        private void IfPassNotSetted()
        {
            if (Settings.GetHashProgrammPassword() == "")
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


        /*
        private void AddComponents()
        {
            var PasswordLabel = new Label()
            {
                Location = new Point(150, 80),
                Size = new Size(200, 20),
                Text = "Enter your password"
            };

            var PasswordTextBox = new TextBox()
            {
                Location = new Point(150, 100),
                Size = new Size(200, 75),
                UseSystemPasswordChar = true,
                BackColor = Color.Aqua
            };

            var PasswordButton = new Button()
            {
                Location = new Point(200, 150),
                Size = new Size(100, 50),
                BackColor = Color.Aqua,
                FlatStyle = FlatStyle.System,
                Text = "Log In",
                ForeColor = Color.Brown
            };

            this.Controls.Add(PasswordTextBox);
            this.Controls.Add(PasswordButton);
            this.Controls.Add(PasswordLabel);
        }
        */
    }
}
