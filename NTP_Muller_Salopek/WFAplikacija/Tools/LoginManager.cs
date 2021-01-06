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
        private static string roleAdmin { get; } = "ROLE_ADMIN";
        private static string roleWorker { get; } = "ROLE_WORKER";

        public static void GenerateUsers()
        {
            List<string> users = new List<string>
            {
                "admin", "123", roleAdmin,
                "worker", "123", roleWorker
            };
            using (BinaryWriter bw = new BinaryWriter(new FileStream(filePath + fileName, FileMode.Create)))
            {
                for (int i = 0; i < 6; i+=3)
                {
                    byte[] hashedUsername = Cryptography.makeSha512(users[i]);
                    byte[] hashedPassword = Cryptography.makeSha512(users[i + 1]);
                    byte[] hashedRole = Cryptography.makeSha512(users[i + 2]);
                    bw.Write(hashedUsername);
                    bw.Write(hashedPassword);
                    bw.Write(hashedRole);
                }
                bw.Close();
            }
        }

        /// <summary>
        /// Check if a user exists in the users file.
        /// </summary>
        /// <param name="username">Non-hashed username of user.</param>
        /// <param name="password">Non-hashed password of user.</param>
        /// <returns>"0" = invalid login, "1" = admin logged in, "-1" non admin user logged in</returns>
        public static int Login(string username, string password)
        {
            // 64 Bytes of hash
            byte[] user_bytes = WFAplikacija.Tools.Cryptography.makeSha512(username);
            byte[] pass_bytes = WFAplikacija.Tools.Cryptography.makeSha512(password);
            byte[] role_admin_bytes = WFAplikacija.Tools.Cryptography.makeSha512(roleAdmin);
            using (BinaryReader br = new BinaryReader(new FileStream(filePath + fileName, FileMode.Open)))
            {
                try
                {
                    // Read until user found (or exception->EOF)
                    while(true)
                    {
                        // 2 users => 64 B hashed username, 64 B h. pass., 64 B h. role
                        bool userFound = true;
                        bool adminFound = true;
                        int bytesPerUser = 64 + 64 + 64;
                        int readNBytes = 2 * bytesPerUser;

                        byte[] allBytes = br.ReadBytes(readNBytes);

                        for (int nthUser = 0; nthUser < 2; ++nthUser)
                        {
                            for (int i = 0; i < 64 && userFound; ++i)
                            {
                                if (allBytes[nthUser * bytesPerUser + i] != user_bytes[i] ||
                                    allBytes[nthUser * bytesPerUser + 64 + i] != pass_bytes[i])
                                    userFound = false;
                                if (allBytes[nthUser * bytesPerUser + 128 + i] != role_admin_bytes[i])
                                    adminFound = false;
                            }
                        }
                        // User found: return 1 if admin, otherwise -1
                        if (userFound)
                            return adminFound ? 1 : -1;
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    br.Close();
                    return 0;
                }
                catch (IOException e)
                {
                    // EOF or Exception, so return 0 (invalid login)
                    br.Close();
                    return 0;
                }
                br.Close();
                return 0;
            }
        }
    }
}
