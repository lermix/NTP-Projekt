using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAplikacija.Tools
{
    /// <summary>
    /// A class with static methods used for various (de)crypting and hashing tasks.
    /// </summary>
    class Cryptography
    {
        /// <summary>
        /// Method that calculates SHA512 hash and returns it as a string.
        /// </summary>
        public static string makeSha512(string input)
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
    }
}
