using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOV4
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private async void AdminPanel_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MySqlConnection connection = new MySqlConnection("server=;user=;database=;port=;password=;");
            MySqlDataReader sqlData = null;
            try
            {
                await connection.OpenAsync();
                MySqlCommand sqlcommand = new MySqlCommand("SELECT * FROM whitelisted", connection);
                sqlData = sqlcommand.ExecuteReader();
                while (await sqlData.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(sqlData["HWID"].ToString());
                    
                    item.SubItems.Add(sqlData["givenBy"].ToString());
                    item.SubItems.Add(sqlData["admin"].ToString());
                    item.SubItems.Add(sqlData["username"].ToString());
                    item.SubItems.Add(sqlData["discordid"].ToString());
                    listView1.Items.Add(item);

                }

            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
                connection.Close();

            }
            connection.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                CHWID.Text = "HWID: " + item.Text;
                CHWID.Text = "DiscordID: " + item.SubItems[4].Text; 
                CHWIDP.Text = "HWID Permitter: " + item.SubItems[1].Text;
                CADMINLEVEL.Text = "Admin Level: " + item.SubItems[2].Text;
                CUsername.Text = "Username: " + item.SubItems[3].Text;
            }
        }

        private void selectKeyBtn_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                selectedHWID.Text = "Selected HWID: " + item.Text;
                HWIDHWID.Text = item.Text;
                selectedDiscordID.Text = "DiscordID: " + item.SubItems[4].Text;
                selectedUsername.Text = "Selected Username: " + item.SubItems[3].Text;
               selectedHWIDPermitter.Text = "HWID Permitter: " + item.SubItems[1].Text;
                selectedAdminLevel.Text = "Admin Level: " + item.SubItems[2].Text;
                Properties.Settings.Default.SelectedHWID = item.Text;
                Properties.Settings.Default.Save();
                // Place into text boxes.
                selectedHWIDText.Text = item.Text;
                SelectedUsernameText.Text = item.SubItems[3].Text;
                selectedHWIDPermitterText.Text = item.SubItems[1].Text;
                selectedAdminLevelText.Text = item.SubItems[2].Text;
                selectedDiscordIDText.Text = item.SubItems[4].Text;
             
            }
            
        }

        private async void refreshListBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SelectedHWID = "";
            Properties.Settings.Default.Save();
            listView1.Items.Clear();
            MySqlConnection connection = new MySqlConnection("server=;user=;database=;port=;password=;");
            MySqlDataReader sqlData = null;
            try
            {
                await connection.OpenAsync();
                MySqlCommand sqlcommand = new MySqlCommand("SELECT * FROM whitelisted", connection);
                sqlData = sqlcommand.ExecuteReader();
                while (await sqlData.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(sqlData["HWID"].ToString());
                   
                    item.SubItems.Add(sqlData["givenBy"].ToString());
                    item.SubItems.Add(sqlData["admin"].ToString());
                    item.SubItems.Add(sqlData["username"].ToString());
                    item.SubItems.Add(sqlData["discordid"].ToString());
                    listView1.Items.Add(item);

                }

            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
                connection.Close();

            }
            connection.Close();
        }

        private void createKeyBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SelectedHWID = "HWID";
            Properties.Settings.Default.Save();
            if (listView1.SelectedItems.Count > 0)
            {
                if(listView1.SelectedItems[0].Text == "HWID")
                {
                    listView1.SelectedItems[0].Selected = true;
                    listView1.Select();
                    return;
                }
                
            }
            ListViewItem item = new ListViewItem("HWID");
            
            item.SubItems.Add("Given By");
            item.SubItems.Add("Admin Level");
            item.SubItems.Add("Username");
            item.SubItems.Add("DiscordID");
            listView1.Items.Add(item);
            if (listView1.Items[listView1.Items.Count - 1] != null)
            {
                listView1.Items[listView1.Items.Count - 1].Selected = true;
                listView1.Select();
                selectKeyBtn_Click(null, null);
            }
        }

        private async void deleteKeyBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SelectedHWID = "";
            Properties.Settings.Default.Save();
            if (listView1.SelectedItems.Count > 0)
            {
                string keyCheck = await SQLStuff.GetSQLResultAsync("HWID", "SELECT * FROM whitelisted WHERE `HWID`='" + listView1.SelectedItems[0].Text + "' LIMIT 1");
                if(keyCheck == listView1.SelectedItems[0].Text)
                {
                    await SQLStuff.GetSQLResultAsync("HWID", "DELETE FROM whitelisted WHERE HWID='" + listView1.SelectedItems[0].Text + "'");
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
                else
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
            selectedHWID.Text = "Selected HWID: null";
            selectedDiscordID.Text = "DiscordID: null";
            selectedHWIDPermitter.Text = "HWID Permitter: null";
            selectedAdminLevel.Text = "Admin Level: null";
            selectedUsername.Text = "Selected Username: null";
            selectedDiscordIDText.Text = "";
            selectedHWIDText.Text = "";
            SelectedUsernameText.Text = "";
            selectedHWIDPermitterText.Text = "";
            selectedAdminLevelText.Text = "";
           
        }

        private async void updateKeyBtn_Click(object sender, EventArgs e)
        {
            if (selectedHWID.Text == "Selected HWID: HWID")
            {
                await SQLStuff.GetSQLResultAsync("HWID", "INSERT INTO `whitelisted`(`HWID`, `givenBy`, `admin`,`username`,`discordid`) VALUES ('"+ selectedHWIDText.Text + "','"+selectedHWIDPermitterText.Text+"','"+selectedAdminLevelText.Text+"'" +",'" +SelectedUsernameText.Text+"','" +selectedDiscordIDText.Text+ "')");
            }
            else
            {
                await SQLStuff.GetSQLResultAsync("HWID", "UPDATE `whitelisted` SET `HWID`='" + selectedHWIDText.Text + "',`givenBy`='" + selectedHWIDPermitterText.Text +"',`admin`='"+ selectedAdminLevelText.Text+"',`username`='" + SelectedUsernameText.Text+ "',`discordid`='" + selectedDiscordIDText.Text +"' WHERE `HWID`='" + HWIDHWID.Text + "'");
            }
            selectedHWID.Text = "Selected HWID: null";
            selectedDiscordID.Text = "DiscordID: null";
            selectedHWIDPermitter.Text = "HWID Permitter: null";
            selectedAdminLevel.Text = "Admin Level: null";
            selectedUsername.Text = "Selected Username: null";
            selectedDiscordIDText.Text = "";
            selectedHWIDText.Text = "";
            SelectedUsernameText.Text = "";
            selectedHWIDPermitterText.Text = "";
            selectedAdminLevelText.Text = "";
            
            refreshListBtn_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = EOV4.baseDecode(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = EOV4.baseEncode(textBox1.Text);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                selectKeyBtn_Click(null, null);
            }
        }
    }
}
