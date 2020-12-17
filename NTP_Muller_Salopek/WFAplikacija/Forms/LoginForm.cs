using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAplikacija
{
    public partial class LoginForm : Form
    {
        private const string defaultMessage = "Press button to login";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowMainApp()
        {
            var appForm = new AppForm();
            appForm.Location = this.Location;
            appForm.StartPosition = this.StartPosition;
            // Set appForm function on close
            appForm.FormClosing += delegate {
                // Closing LoginForm closes entire app
                this.Close();
            };
            appForm.Show();
            // Hide LoginForm so that app keeps running
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (WFAplikacija.Tools.UserManager.Login(username, password))
            {
                this.ShowMainApp();
            }
            else
            {
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                messageLabel.Text = "Invalid login.";
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Text = defaultMessage;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Text = defaultMessage;
        }

    }
}
