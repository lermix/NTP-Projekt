using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CentralniServer.Controllers
{
    public class UserController : Controller
    {

        [HttpPost]
        public string Login(string username, string hashedPassword)
        {
            CentralniServer.Data.DBManager dbManager = new Data.DBManager();
            List<dynamic> users = dbManager.FetchUsers();
            users = users.FindAll(u => u.username == username);

            if (users.Count != 1)
                return "N_Username";
            else if (users[0].password != hashedPassword)
                return "N_Password";
            else
                return "Y";
        }
    }
}
