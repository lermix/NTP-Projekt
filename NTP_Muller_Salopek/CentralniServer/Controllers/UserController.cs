using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CentralniServer.Controllers
{
    public class UserController : Controller
    {

        [HttpPost]
        public string Login(string username, string hashedPassword)
        {
            List<dynamic> users = Data.DBManager.FetchUsers();
            users = users.FindAll(u => u.username == username);

            if (users.Count != 1)
                return "N_Username";
            else if (users[0].password != hashedPassword)
                return "N_Password";
            else
                return "Y";
        }

        // /Users/Get
        [HttpGet]
        public string Get(int id)
        {
            var user_s = id > 0 ? Data.DBManager.FetchUser(id) : Data.DBManager.FetchUsers();

            string res = user_s != null ? JsonConvert.SerializeObject(user_s) : "{}";
            return res;
        }
    }
}
