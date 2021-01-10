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

        [HttpGet]
        public string Delete(int id)
        {
            if (id <= 0)
                return "N";
            bool success = Data.DBManager.DeleteUser(id);
            return success ? "Y" : "N";
        }

        [HttpPost]
        public string Add(string name, string surname, string username, string hashedPassword, string role)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(hashedPassword) ||
                string.IsNullOrWhiteSpace(role))
            {
                return "N_Parameters_name_surname_username_hashedPassword_role";
            }
            role = role.ToLower();
            if (role != "admin" && role != "worker")
                return "N_Parameters_Role";

            if (Data.DBManager.AddUser(new { name, surname, username, password=hashedPassword, role}))
                return "Y";
            else return "N_Error";
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
