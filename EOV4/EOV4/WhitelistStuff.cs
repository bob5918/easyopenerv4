using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Security.Cryptography;

using System.Threading;
using MySql.Data.MySqlClient;


namespace EOV4
{
    class EOV4
    {




        public async static Task<bool> CheckkeyAsync(string key)
        {

            try
            {
                if (await SQLStuff.GetSQLResultAsync("HWID", "SELECT * FROM whitelisted WHERE `HWID`='" + baseEncode(key) + "' LIMIT 1") == baseEncode(key))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                
                return false;

            }
        }

        public static string baseEncode(string text)
        {


            string hashedthing = GenerateSHA256(text, "saltkey");
            return hashedthing;
        }
        public static string baseDecode(string text)
        {
            byte[] mybyte = Encoding.UTF8.GetBytes(text);
            byte[] returntext = Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(returntext); ;
        }
        public static string CreateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
        public static String GenerateSHA256(String input, String salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256hashstring =
                new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);
            return BitConverter.ToString(hash);
        }


    }
}
