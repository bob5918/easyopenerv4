using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOV4
{
    public partial class EOV4UI : Form
    {

        public EOV4UI()
        {
            InitializeComponent();
        }

        private async void EOV4UI_Load(object sender, EventArgs e)
        {
            var motd = await SQLStuff.GetSQLResultAsync("value", "SELECT * FROM settings WHERE `setting`='motd' LIMIT 1");
            label1.Text = "HWID: " + EOV4.baseEncode(HWIDGen.Value());
            label3.Text = "Current MOTD: " + motd;
            string adminlevel = await SQLStuff.GetSQLResultAsync("admin", "SELECT * FROM whitelisted WHERE `HWID`='" + EOV4.baseEncode(HWIDGen.Value()) + "' LIMIT 1");
            if (adminlevel == "1")
            {
                label2.Text = "isAdmin: true";
            }
            else
            {
                label2.Text = "isAdmin: false";
            }
        }

        private void EOV4UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Cya later fam");
        }

        private async void  button2_Click(object sender, EventArgs e)
        {
            var motd = await SQLStuff.GetSQLResultAsync("value", "SELECT * FROM settings WHERE `setting`='motd' LIMIT 1");
            label3.Text = "Current MOTD: "+ motd;
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }
        [STAThread]
        private void button1_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(() => Clipboard.SetText(EOV4.baseEncode(HWIDGen.Value()), TextDataFormat.Text));
            thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
            thread.Start();
            thread.Join(); //Wait for the thread to end
           
            MessageBox.Show("Copied to clipboard!","EOV4 HWID Handler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
