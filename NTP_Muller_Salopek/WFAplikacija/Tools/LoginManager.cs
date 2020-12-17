using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAplikacija.Tools
{
    class LoginManager
    {
        private static string filePath = "../../Data/";
        private static string fileName = "users.wfapl";

        /// <summary>
        /// Check if a user exists in the users file.
        /// </summary>
        /// <param name="username">Non-hashed username of user.</param>
        /// <param name="password">Non-hashed password of user.</param>
        /// <returns>"true" True if match and "false" in case of an IO exception or invalid username or password.</returns>
        public static bool Login(string username, string password)
        {
            // 64 Bytes of hash
            byte[] user_bytes = WFAplikacija.Tools.Cryptography.makeSha512(username);
            byte[] pass_bytes = WFAplikacija.Tools.Cryptography.makeSha512(password);
            using (BinaryReader br = new BinaryReader(new FileStream(filePath + fileName, FileMode.Open)))
            {
                try
                {
                    // 1 user represented by 64 bytes of hashed username and 64 bytes of hashed password
                    int readNBytes = 1 * (64 + 64);
                    byte[] allBytes = br.ReadBytes(readNBytes);
                    br.Close();

                    for (int i = 0; i < 64; ++i)
                        if (allBytes[i] != user_bytes[i] ||
                            allBytes[64 + i] != pass_bytes[i])
                            return false;
                    return true;
                }
                catch (IOException e)
                {
                    // Error while opening or reading the file
                    return false;
                }
            }
        }
    }
}
