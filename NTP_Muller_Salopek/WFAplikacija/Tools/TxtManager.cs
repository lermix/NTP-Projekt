using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAplikacija.DataObjects;

namespace WFAplikacija.Tools
{
    static class TxtManager
    {
        private static string location = @"../../Bills/";

        public static bool setAES = false; 

        public static void WriteToFile(Bill bill)
        {
            string fileName = "Bill_ID_" + bill.id + ".txt";
            string text = bill.ToString();
            if (setAES)
            {
                text = AES.Encrypt(text, "AGARAMUDHALA", "EZHUTHELLAM", 3, "@1B2c3D4e5F6g7H8", 256);
            }
            else
            {
                text = CES.Encryption(text);
            }
            System.IO.File.WriteAllText(location + fileName, text);
        }

        public static string ReadFromFile(int ID)
        {
            string fileName = "Bill_ID_" + ID + ".txt";
            try
            {
                string text = System.IO.File.ReadAllText(location + fileName);
                if (setAES)
                {
                    return AES.Decrypt(text, "AGARAMUDHALA", "EZHUTHELLAM", 3, "@1B2c3D4e5F6g7H8", 256);
                }
                else
                {
                    return CES.Decryption(text);
                }
            }
            catch (Exception)
            {
                return "No file found";
            }
        }

    }
}
