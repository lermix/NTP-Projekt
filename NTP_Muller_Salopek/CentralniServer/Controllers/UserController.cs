using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralniServer.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        /// Temporary method that computes hash. Need be removed when Database is implemented.
        /// </summary>
        private static string makeSha512Hash(string input)
        {
            string resultString;
            using (System.Security.Cryptography.SHA512 shaM = new System.Security.Cryptography.SHA512Managed())
            {
                var data = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hash = shaM.ComputeHash(data);
                resultString = System.Text.Encoding.Default.GetString(hash);
            }
            return resultString;
        }

        [HttpPost]
        public string Index(string username, string hashedPassword)
        {
            string exampleUsername = "admin";
            string exampleHashedPassword = makeSha512Hash("123");

            if (username == exampleUsername && hashedPassword == exampleHashedPassword)
                return "Y";
            else if (username == exampleUsername)
                return "N_Password";
            else
                return "N_Username";
        }
    }
}
