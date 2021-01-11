using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAplikacija.Tools;
using WFAplikacija.DataObjects;

namespace WFAplikacija
{
    public partial class LoginForm : Form
    {
        private const string defaultMessage = "Press button to login";

        public LoginForm()
        {
            InitializeComponent();
            // After initialization set layout
            LoadFormLayout();
            this.FormClosing += delegate {
                // Save app layout
                SaveFormLayout();
            };
        }


        /// <summary>
        /// Load layout from an INI file if exists
        /// </summary>
        public void LoadFormLayout()
        {
            IniFilesManager settings = new IniFilesManager(WFAplikacija.Properties.Resources.SettingsIniFile);

            if (settings.KeyExists(WFAplikacija.Properties.Resources.IniWidthKey))
                this.Width = Int32.Parse(settings.Read(WFAplikacija.Properties.Resources.IniWidthKey));
            if (settings.KeyExists(WFAplikacija.Properties.Resources.IniHeightKey))
                this.Height = Int32.Parse(settings.Read(WFAplikacija.Properties.Resources.IniHeightKey));
            if (settings.KeyExists(WFAplikacija.Properties.Resources.IniXPosKey))
                this.Left = Int32.Parse(settings.Read(WFAplikacija.Properties.Resources.IniXPosKey));
            if (settings.KeyExists(WFAplikacija.Properties.Resources.IniYPosKey))
                this.Top = Int32.Parse(settings.Read(WFAplikacija.Properties.Resources.IniYPosKey));
        }

        /// <summary>
        /// Save layout to INI file
        /// </summary>
        public void SaveFormLayout()
        {
            IniFilesManager settings = new IniFilesManager(WFAplikacija.Properties.Resources.SettingsIniFile);

            settings.Write(WFAplikacija.Properties.Resources.IniWidthKey, this.Width.ToString());
            settings.Write(WFAplikacija.Properties.Resources.IniHeightKey, this.Height.ToString());
            settings.Write(WFAplikacija.Properties.Resources.IniXPosKey, this.Left.ToString());
            settings.Write(WFAplikacija.Properties.Resources.IniYPosKey, this.Top.ToString());
        }

        private void ShowMainApp()
        {
            var appForm = new AppForm();
            appForm.LoadFormLayout();
            // Set appForm function on close
            appForm.FormClosing += delegate {
                // Save app layout
                appForm.SaveFormLayout();
                // Closing LoginForm closes entire app
                this.Close();
            };
            appForm.Show();

            // if not admin, hide admin tab
            if (WFAplikacija.Tools.Session.user == null ||
                WFAplikacija.Tools.Session.user.role != WFAplikacija.DataObjects.UserRole.Admin)
            {
                appForm.RemoveAdminTab();
            }

            // Hide LoginForm so that app keeps running
            this.Hide();
        }

        private void test (AppForm app)
        {
            app.Width = 50;
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            Action<User> callbackFn = delegate (User u)
            {
                if (u != null)
                    this.ShowMainApp();
                else
                {
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    messageLabel.Text = "Invalid login.";
                }
            };
            Action onError = delegate
            {
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                messageLabel.Text = "Server error.";
            };

            WFAplikacija.Tools.LoginManager.Login(username, password, callbackFn, onError);
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Text = defaultMessage;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Text = defaultMessage;
        }

        private void langComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int langIndex = this.langComboBox.SelectedIndex;
            // Default select is English
            WFAplikacija.Tools.Language lang = langIndex == 1 ? Tools.Language.Croatian : Tools.Language.English;
            WFAplikacija.Tools.LanguageManager.SetLanguage(lang);
            // Refresh text of current login form
            this.RefreshDisplayText();
        }
    }
}
