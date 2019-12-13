using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace EOUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var onver = await SQLStuff.GetSQLResultAsync("value", "SELECT * FROM settings WHERE `setting`='version' LIMIT 1");
            UpdateLog.Text = client.DownloadString(""); // Put where your updatelog would be like a pastebin or something.

            OnlineVersion.Text = "Server Version: " + onver;
            var thing = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString();
           
            string assemblyVersion = Assembly.LoadFile(thing + @"\EOV4.exe").GetName().Version.ToString();
            
            LocalVersion.Text = "Local Version: " + assemblyVersion;
            if(onver == assemblyVersion)
            {
                MessageBox.Show("Up to date!");

            }
            else
            {
                MessageBox.Show("Not updated! Please click download update");
                button1.Enabled = true;
            }
            client.Dispose();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            MessageBox.Show("You will get a zip file called eo.zip. Unzip and replace everything then you will be updated");
            var filetodownload = await SQLStuff.GetSQLResultAsync("value", "SELECT * FROM settings WHERE `setting`='downloadLocation' LIMIT 1");
            client.DownloadFile(filetodownload, "eo.zip");
            MessageBox.Show("Done downloading! Please unzip eo.zip inside the directory");
            client.Dispose();
            
        }
    }
}
