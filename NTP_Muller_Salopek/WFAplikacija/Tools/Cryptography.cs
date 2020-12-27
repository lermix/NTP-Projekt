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
        /// Method that calculates SHA512 hash and returns it as byte[] of length 64 (512 bits = 64 Bytes.
        /// To get it as a string, use method WFAplikacija.Tools.Cryptography.byteArrayToString.
        /// </summary>
        public static byte[] makeSha512(string input)
        {
            byte[] hash;
            using (System.Security.Cryptography.SHA512 shaM = new System.Security.Cryptography.SHA512Managed())
            {
                var data = System.Text.Encoding.UTF8.GetBytes(input);
                hash = shaM.ComputeHash(data);
            }
            return hash;
        }
    }
}
