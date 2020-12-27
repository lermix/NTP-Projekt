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
            int loginResponse = WFAplikacija.Tools.LoginManager.Login(username, password);
            loggedIn = loginResponse != 0;
            if (loggedIn)
            {
                // Set correct role (1 = admin, -1 = worker)
                DataObjects.UserRole role = loginResponse == 1 ?
                    DataObjects.UserRole.Admin :
                    DataObjects.UserRole.Worker;
                WFAplikacija.Tools.Session.user = new DataObjects.User(_id: 0, _name: username, _surname: username, username, role);
            }
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
