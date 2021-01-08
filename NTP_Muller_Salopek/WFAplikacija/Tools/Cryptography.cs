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
        /// To get it as a string, use method WFAplikacija.Tools.Cryptography.GetHashString.
        /// </summary>
        public static byte[] makeSha512(string input)
        {
            using (System.Security.Cryptography.HashAlgorithm algorithm = System.Security.Cryptography.SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in makeSha512(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
