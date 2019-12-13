using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;

namespace EOV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EasyOpener V4. Please wait while we check if you're whitelisted :)");
            load();
        }
        private static void calccommand()
        {
            int result = 0;
            Console.WriteLine("");
            Console.Write("Please input an operation: ");
            var input = Console.ReadLine();
            string[] a = input.Split(' ');
           
            var v0 = Convert.ToInt16(a[0]);
            var v1 = Convert.ToInt16(a[2]);
          
            if(a[1].Contains("+"))
            {
                result = v0 + v1;

            } else if (a[1].Contains("-"))

            {
                result = v0 - v1;
            }
            else if (a[1].Contains("*"))

            {
                result = v0 * v1;
            }
            else if (a[1].Contains("/"))

            {
                result = v0 / v1;
            }
            else if (a[1].Contains("%"))

            {
                result = v0 & v1;
            }
            Console.WriteLine("Here you go! " + result);
            
            
        }
        static async void load()
        {
            var version = "1.0.0.7";
            WebClient client = new WebClient();
           
            if (await EOV4.CheckkeyAsync(HWIDGen.Value()) == true)
            {

                Console.WriteLine("You are whitelisted :)");

                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                string username = await SQLStuff.GetSQLResultAsync("username", "SELECT * FROM whitelisted WHERE `HWID`='" + EOV4.baseEncode(HWIDGen.Value()) + "' LIMIT 1");
                wplayer.URL = "startup.mp3";
                wplayer.controls.play();
                Thread.Sleep(6000);
                Console.Clear();
                Console.WriteLine("Checking for updates...");
                var onver = await SQLStuff.GetSQLResultAsync("value", "SELECT * FROM settings WHERE `setting`='version' LIMIT 1");
                if (onver == version)
                {

                    Console.Clear();
                    Console.WriteLine("You're on the latest version :D");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.Title = "EOV4 //\\ Private Alpha //\\";
                    Console.WriteLine("Welcome to EOV4, " + username + " //\\ Private Alpha //\\");
                    Console.Write(">");
                    String command;
                    Boolean quitNow = false;
                    var ccolor = ConsoleColor.White;
                    while (!quitNow)
                    {
                        command = Console.ReadLine();
                        Console.Write("<");


                        switch (command)
                        {
                            case "help":
                                Console.WriteLine("Current Commands are:" + "\n" + "motd -- outputs current MOTD to console" + "\n" + "ui -- Opens a new winform with the user's basic info" + "\n" + "ping -- outputs pong" + "\n" + "quit -- Closes EOV4 out" + "\n" + "cls -- Clears screen to original screen" + "\n" + "clear -- Clears the console of all text" + "\n" + "red -- Changes text color to red" + "\n" + "magenta -- Changes color to magenta" + "\n" + "calc -- Uses a normal text calculator" + "\n" + "normal -- Changes text color to normal" + "\n" + "calcui -- Opens a new winform with a calculator(WIP)" + "\n" + "updatelog -- Outputs current updatelog" + "\n" + "mario(Legacy) -- Plays mario theme song through beeps" + "\n" + "notepad -- Opens notepad.exe" + "\n" + "paint -- Opens mspaint.exe" + "\n" + "time -- outputs system's current time");
                                Console.Write(">");
                                break;
                            case "motd":
                                var motd = await SQLStuff.GetSQLResultAsync("value", "SELECT * FROM settings WHERE `setting`='motd' LIMIT 1");
                                Console.WriteLine(motd);
                                Console.Write(">");
                                break;
                            case "ui":
                                Console.WriteLine("Here is the UI");
                                Application.EnableVisualStyles();
                                Application.Run(new EOV4UI());
                                Console.Write(">");
                                break;
                            case "mario":
                                Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
                                Console.WriteLine("Mario!");
                                Console.Write(">");
                                break;
                            case "notepad":
                                Process.Start("notepad.exe");
                                Console.WriteLine("Notepad.exe was launched!");
                                Console.Write(">");
                                break;
                            case "paint":
                                Process.Start("mspaint.exe");
                                Console.WriteLine("MSPAINT.EXE HAS BEEN LAUNCHED!");
                                Console.Write(">");
                                break;
                            case "time":
                                Console.WriteLine(DateTime.Now);
                                Console.Write(">");
                                break;


                            case "ping":
                                Console.WriteLine("Pong");
                                Console.Beep();
                                Console.Write(">");
                                break;
                            case "quit":
                                quitNow = true;
                                break;
                            case "cls":
                                Console.Clear();
                                Console.WriteLine("Welcome to EOV4, " + username + " //\\ Private Alpha //\\");
                                Console.Write(">");
                                break;
                            case "clear":
                                Console.Clear();
                                Console.Write(">");
                                break;
                            case "admin":
                                string adminlevel = await SQLStuff.GetSQLResultAsync("admin", "SELECT * FROM whitelisted WHERE `HWID`='" + EOV4.baseEncode(HWIDGen.Value()) + "' LIMIT 1");
                                if (adminlevel == "1")
                                {
                                    Console.WriteLine("Admin Panel :o");
                                    Application.EnableVisualStyles();
                                    Application.Run(new AdminPanel());

                                    Console.Write(">");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry you do not have access to this");
                                    Console.Write(">");
                                }
                                break;
                            case "red":
                                Console.ForegroundColor = ConsoleColor.Red;
                                ccolor = ConsoleColor.Red;
                                Console.WriteLine("Red!");
                                Console.Write(">");
                                break;
                            case "normal":
                                Console.ForegroundColor = ConsoleColor.White;
                                ccolor = ConsoleColor.White;
                                Console.WriteLine("Back to normal!");
                                Console.Write(">");
                                break;
                            case "magenta":
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                ccolor = ConsoleColor.Magenta;
                                Console.WriteLine("Magenta");
                                Console.Write(">");
                                break;
                            case "calc":
                                Console.WriteLine("Use ONLY 2 numbers or it will crash. ex: 2 + 2 not 2 + 2 * 3 or 2 + 2 + 2");
                                calccommand();
                                Console.Write(">");

                                break;
                            case "github":
                                Console.WriteLine("https://github.com/bob5918/easyopenerv4");
                                Process.Start("https://github.com/bob5918/easyopenerv4");
                                Console.WriteLine("Opened webbrowser!");
                                Console.Write(">");
                                break;
                            case "updatelog":
                                Console.WriteLine(client.DownloadString("https://pastebin.com/raw/mWW7N2XN"));
                                Console.Write(">");
                                client.Dispose();
                                break;
                            case "calcui":
                                Console.WriteLine("Calculator UI!");
                                Application.EnableVisualStyles();
                                Application.Run(new Calculator());
                                
                                Console.Write(">");
                                break;
                            default:
                                Console.WriteLine("Unknown Command " + command);
                                Console.Beep();
                                Console.Write(">");
                                break;
                        }
                        client.Dispose();
                    }
                }



                else
                {
                    Console.WriteLine("Update found! Please run EOUpdate.exe to get");
                    Thread.Sleep(3000);
                    Environment.Exit(1);
                    client.Dispose();
                    
                }
               
            }
            else
            {
                Console.WriteLine("You are not whitelisted :(");
                Thread.Sleep(3000);
                Environment.Exit(1);
                client.Dispose();

            }
            client.Dispose();
        }
    }
}
