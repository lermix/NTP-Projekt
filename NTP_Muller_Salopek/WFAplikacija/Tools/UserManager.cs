using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAplikacija.Tools
{
    class UserManager
    {
        private static bool loggedIn = false;

        public static bool Login(string username, string password)
        {
            loggedIn = WFAplikacija.Tools.LoginManager.Login(username, password);
            return loggedIn;
        }

        public static bool Logout()
        {
            loggedIn = false;
            return loggedIn;
        }

        public static bool UserLoggedIn()
        {
            return loggedIn;
        }
    }
}
