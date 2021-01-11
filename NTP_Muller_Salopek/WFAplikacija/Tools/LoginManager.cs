using System;
using Newtonsoft.Json;
using WFAplikacija.DataObjects;

namespace WFAplikacija.Tools
{
    class LoginManager
    {
        
        public static void Login(string username, string password, Action<User> callbackFn, Action onError=null)
        {
            string hashedPassword = WFAplikacija.Tools.Cryptography.GetHashString(password);
            string url = WFAplikacija.Properties.Resources.CentralniServerURL + "/User/Get/?username=" + username;

            RESTManager.Get(url, delegate (string response)
            {
                User user = null;
                if (!string.IsNullOrWhiteSpace(response))
                {
                    // id, name, surname, username, password, role
                    dynamic du = JsonConvert.DeserializeObject(response);
                    // int _id, string _name, string _surname, string _username, UserRole _role
                    if (du.password == hashedPassword)
                    {
                        int _id = du.id;
                        string _name = du.name, _surname = du.surname, _username = du.username;
                        UserRole _role = du.role == "admin" ? UserRole.Admin : UserRole.Worker;

                        user = new User(_id, _name, _surname, _username, _role);
                        WFAplikacija.Tools.Session.user = user;
                    }
                }
                callbackFn(user);
            }, onError);
        }
    }
}
