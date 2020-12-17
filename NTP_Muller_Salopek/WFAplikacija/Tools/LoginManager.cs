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

        public static bool storeAdmin(string username, string password)
        {
            // 64 Bytes of "admin" hashed
            byte[] user_bytes = WFAplikacija.Tools.Cryptography.makeSha512(username);
            // 64 Bytes of "123" hashed
            byte[] pass_bytes = WFAplikacija.Tools.Cryptography.makeSha512(password);

            BinaryWriter bw;
            try
            {
                bw = new BinaryWriter(new FileStream(filePath + fileName, FileMode.Create));
                bw.Write(user_bytes);
                bw.Write(pass_bytes);
                return true;
            }
            catch (IOException e)
            {
                // Eror while opening or writing the file
                return false;
            }
        }

        /// <summary>
        /// Check if a user exists in the users file.
        /// </summary>
        /// <param name="username">Non-hashed username of user.</param>
        /// <param name="password">Non-hashed password of user.</param>
        /// <returns>"true" True if match and "false" in case of an IO exception or invalid username or password.</returns>
        public static bool login(string username, string password)
        {
            // 64 Bytes of hash
            byte[] user_bytes = WFAplikacija.Tools.Cryptography.makeSha512(username);
            byte[] pass_bytes = WFAplikacija.Tools.Cryptography.makeSha512(password);
            BinaryReader br;
            try
            {
                br = new BinaryReader(new FileStream(filePath + fileName, FileMode.Open));
                // 1 user represented by 64 bytes of hashed username and 64 bytes of hashed password
                int readNBytes = 1 * (64 + 64);
                byte[] allBytes = br.ReadBytes(readNBytes);

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
