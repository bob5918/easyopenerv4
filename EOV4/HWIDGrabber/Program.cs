using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Threading;

namespace HWIDGrabber
{
    class Program
    {
        static void Main(string[] args)
        {
            var thing = baseEncode(HWIDGen.Value());
           
            Thread t = new Thread((ThreadStart)(() => {
                Console.WriteLine("Your HWID is " + thing);
                Clipboard.SetText(thing);
                Console.WriteLine("Copied");
                Console.Read();

            }));
            

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }
        public static string baseEncode(string text)
        {
            
           
            string hashedthing = GenerateSHA256(text, "saltkeyhere");
            return hashedthing;
        }
        public static string baseDecode(string text)
        {
            byte[] mybyte = Encoding.UTF8.GetBytes(text);
            byte[] returntext = Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(returntext); ;
        }
      public static  string CreateSalt(int size)
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
