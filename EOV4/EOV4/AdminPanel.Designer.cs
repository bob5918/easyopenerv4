namespace EOV4
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.hwid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.givenby = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdminLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectKeyBtn = new System.Windows.Forms.Button();
            this.CHWID = new System.Windows.Forms.Label();
            this.CHWIDP = new System.Windows.Forms.Label();
            this.CADMINLEVEL = new System.Windows.Forms.Label();
            this.selectedAdminLevel = new System.Windows.Forms.Label();
            this.selectedHWID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.selectedHWIDText = new System.Windows.Forms.TextBox();
            this.selectedHWIDPermitterText = new System.Windows.Forms.TextBox();
            this.selectedAdminLevelText = new System.Windows.Forms.TextBox();
            this.SAdminLevel = new System.Windows.Forms.Label();
            this.HWIDP = new System.Windows.Forms.Label();
            this.sHWID = new System.Windows.Forms.Label();
            this.updateKeyBtn = new System.Windows.Forms.Button();
            this.refreshListBtn = new System.Windows.Forms.Button();
            this.createKeyBtn = new System.Windows.Forms.Button();
            this.deleteKeyBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectedHWIDPermitter = new System.Windows.Forms.Label();
            this.HWIDHWID = new System.Windows.Forms.Label();
            this.SUsername = new System.Windows.Forms.Label();
            this.SelectedUsernameText = new System.Windows.Forms.TextBox();
            this.selectedUsername = new System.Windows.Forms.Label();
            this.CUsername = new System.Windows.Forms.Label();
            this.discordid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDiscordID = new System.Windows.Forms.Label();
            this.selectedDiscordID = new System.Windows.Forms.Label();
            this.CDiscordID = new System.Windows.Forms.Label();
            this.selectedDiscordIDText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hwid,
            this.givenby,
            this.AdminLevel,
            this.username,
            this.discordid});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 314);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // hwid
            // 
            this.hwid.Text = "hwid";
            this.hwid.Width = 150;
            // 
            // givenby
            // 
            this.givenby.Text = "Permitter";
            this.givenby.Width = 150;
            // 
            // AdminLevel
            // 
            this.AdminLevel.Text = "Admin Level";
            this.AdminLevel.Width = 150;
            // 
            // username
            // 
            this.username.Text = "Username";
            // 
            // selectKeyBtn
            // 
            this.selectKeyBtn.Location = new System.Drawing.Point(794, 12);
            this.selectKeyBtn.Name = "selectKeyBtn";
            this.selectKeyBtn.Size = new System.Drawing.Size(112, 23);
            this.selectKeyBtn.TabIndex = 1;
            this.selectKeyBtn.Text = "Select HWID";
            this.selectKeyBtn.UseVisualStyleBackColor = true;
            this.selectKeyBtn.Click += new System.EventHandler(this.selectKeyBtn_Click);
            // 
            // CHWID
            // 
            this.CHWID.AutoSize = true;
            this.CHWID.Location = new System.Drawing.Point(794, 67);
            this.CHWID.Name = "CHWID";
            this.CHWID.Size = new System.Drawing.Size(40, 13);
            this.CHWID.TabIndex = 2;
            this.CHWID.Text = "HWID:";
            // 
            // CHWIDP
            // 
            this.CHWIDP.AutoSize = true;
            this.CHWIDP.Location = new System.Drawing.Point(794, 80);
            this.CHWIDP.Name = "CHWIDP";
            this.CHWIDP.Size = new System.Drawing.Size(84, 13);
            this.CHWIDP.TabIndex = 4;
            this.CHWIDP.Text = "HWID Permitter:";
            // 
            // CADMINLEVEL
            // 
            this.CADMINLEVEL.AutoSize = true;
            this.CADMINLEVEL.Location = new System.Drawing.Point(794, 93);
            this.CADMINLEVEL.Name = "CADMINLEVEL";
            this.CADMINLEVEL.Size = new System.Drawing.Size(71, 13);
            this.CADMINLEVEL.TabIndex = 5;
            this.CADMINLEVEL.Text = "Admin Level: ";
            // 
            // selectedAdminLevel
            // 
            this.selectedAdminLevel.AutoSize = true;
            this.selectedAdminLevel.Location = new System.Drawing.Point(16, 372);
            this.selectedAdminLevel.Name = "selectedAdminLevel";
            this.selectedAdminLevel.Size = new System.Drawing.Size(87, 13);
            this.selectedAdminLevel.TabIndex = 10;
            this.selectedAdminLevel.Text = "Admin Level: null";
            // 
            // selectedHWID
            // 
            this.selectedHWID.AutoSize = true;
            this.selectedHWID.Location = new System.Drawing.Point(15, 346);
            this.selectedHWID.Name = "selectedHWID";
            this.selectedHWID.Size = new System.Drawing.Size(104, 13);
            this.selectedHWID.TabIndex = 7;
            this.selectedHWID.Text = "Selected HWID: null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Before";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "After";
            // 
            // selectedHWIDText
            // 
            this.selectedHWIDText.Location = new System.Drawing.Point(109, 419);
            this.selectedHWIDText.Name = "selectedHWIDText";
            this.selectedHWIDText.Size = new System.Drawing.Size(411, 20);
            this.selectedHWIDText.TabIndex = 14;
            // 
            // selectedHWIDPermitterText
            // 
            this.selectedHWIDPermitterText.Location = new System.Drawing.Point(109, 445);
            this.selectedHWIDPermitterText.Name = "selectedHWIDPermitterText";
            this.selectedHWIDPermitterText.Size = new System.Drawing.Size(411, 20);
            this.selectedHWIDPermitterText.TabIndex = 21;
            // 
            // selectedAdminLevelText
            // 
            this.selectedAdminLevelText.Location = new System.Drawing.Point(109, 471);
            this.selectedAdminLevelText.Name = "selectedAdminLevelText";
            this.selectedAdminLevelText.Size = new System.Drawing.Size(411, 20);
            this.selectedAdminLevelText.TabIndex = 22;
            // 
            // SAdminLevel
            // 
            this.SAdminLevel.AutoSize = true;
            this.SAdminLevel.Location = new System.Drawing.Point(17, 471);
            this.SAdminLevel.Name = "SAdminLevel";
            this.SAdminLevel.Size = new System.Drawing.Size(71, 13);
            this.SAdminLevel.TabIndex = 27;
            this.SAdminLevel.Text = "Admin Level: ";
            // 
            // HWIDP
            // 
            this.HWIDP.AutoSize = true;
            this.HWIDP.Location = new System.Drawing.Point(15, 445);
            this.HWIDP.Name = "HWIDP";
            this.HWIDP.Size = new System.Drawing.Size(87, 13);
            this.HWIDP.TabIndex = 26;
            this.HWIDP.Text = "HWID Permitter: ";
            // 
            // sHWID
            // 
            this.sHWID.AutoSize = true;
            this.sHWID.Location = new System.Drawing.Point(12, 422);
            this.sHWID.Name = "sHWID";
            this.sHWID.Size = new System.Drawing.Size(88, 13);
            this.sHWID.TabIndex = 24;
            this.sHWID.Text = "Selected HWID: ";
            // 
            // updateKeyBtn
            // 
            this.updateKeyBtn.Location = new System.Drawing.Point(30, 553);
            this.updateKeyBtn.Name = "updateKeyBtn";
            this.updateKeyBtn.Size = new System.Drawing.Size(490, 23);
            this.updateKeyBtn.TabIndex = 29;
            this.updateKeyBtn.Text = "Update HWID";
            this.updateKeyBtn.UseVisualStyleBackColor = true;
            this.updateKeyBtn.Click += new System.EventHandler(this.updateKeyBtn_Click);
            // 
            // refreshListBtn
            // 
            this.refreshListBtn.Location = new System.Drawing.Point(794, 41);
            this.refreshListBtn.Name = "refreshListBtn";
            this.refreshListBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshListBtn.TabIndex = 30;
            this.refreshListBtn.Text = "Refresh List";
            this.refreshListBtn.UseVisualStyleBackColor = true;
            this.refreshListBtn.Click += new System.EventHandler(this.refreshListBtn_Click);
            // 
            // createKeyBtn
            // 
            this.createKeyBtn.Location = new System.Drawing.Point(912, 12);
            this.createKeyBtn.Name = "createKeyBtn";
            this.createKeyBtn.Size = new System.Drawing.Size(94, 23);
            this.createKeyBtn.TabIndex = 31;
            this.createKeyBtn.Text = "Create HWID";
            this.createKeyBtn.UseVisualStyleBackColor = true;
            this.createKeyBtn.Click += new System.EventHandler(this.createKeyBtn_Click);
            // 
            // deleteKeyBtn
            // 
            this.deleteKeyBtn.Location = new System.Drawing.Point(1012, 12);
            this.deleteKeyBtn.Name = "deleteKeyBtn";
            this.deleteKeyBtn.Size = new System.Drawing.Size(105, 23);
            this.deleteKeyBtn.TabIndex = 32;
            this.deleteKeyBtn.Text = "Delete HWID";
            this.deleteKeyBtn.UseVisualStyleBackColor = true;
            this.deleteKeyBtn.Click += new System.EventHandler(this.deleteKeyBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(755, 491);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 20);
            this.textBox1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Decode HWID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(755, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(411, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Encode HWID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectedHWIDPermitter
            // 
            this.selectedHWIDPermitter.AutoSize = true;
            this.selectedHWIDPermitter.Location = new System.Drawing.Point(16, 359);
            this.selectedHWIDPermitter.Name = "selectedHWIDPermitter";
            this.selectedHWIDPermitter.Size = new System.Drawing.Size(103, 13);
            this.selectedHWIDPermitter.TabIndex = 9;
            this.selectedHWIDPermitter.Text = "HWID Permitter: null";
            // 
            // HWIDHWID
            // 
            this.HWIDHWID.AutoSize = true;
            this.HWIDHWID.Location = new System.Drawing.Point(1069, 579);
            this.HWIDHWID.Name = "HWIDHWID";
            this.HWIDHWID.Size = new System.Drawing.Size(70, 13);
            this.HWIDHWID.TabIndex = 36;
            this.HWIDHWID.Text = "Ignore me pls";
            // 
            // SUsername
            // 
            this.SUsername.AutoSize = true;
            this.SUsername.Location = new System.Drawing.Point(2, 504);
            this.SUsername.Name = "SUsername";
            this.SUsername.Size = new System.Drawing.Size(100, 13);
            this.SUsername.TabIndex = 37;
            this.SUsername.Text = "Selected Username";
            // 
            // SelectedUsernameText
            // 
            this.SelectedUsernameText.Location = new System.Drawing.Point(109, 497);
            this.SelectedUsernameText.Name = "SelectedUsernameText";
            this.SelectedUsernameText.Size = new System.Drawing.Size(409, 20);
            this.SelectedUsernameText.TabIndex = 38;
            // 
            // selectedUsername
            // 
            this.selectedUsername.AutoSize = true;
            this.selectedUsername.Location = new System.Drawing.Point(17, 385);
            this.selectedUsername.Name = "selectedUsername";
            this.selectedUsername.Size = new System.Drawing.Size(122, 13);
            this.selectedUsername.TabIndex = 39;
            this.selectedUsername.Text = "Selected Username: null";
            // 
            // CUsername
            // 
            this.CUsername.AutoSize = true;
            this.CUsername.Location = new System.Drawing.Point(797, 110);
            this.CUsername.Name = "CUsername";
            this.CUsername.Size = new System.Drawing.Size(58, 13);
            this.CUsername.TabIndex = 40;
            this.CUsername.Text = "Username:";
            // 
            // discordid
            // 
            this.discordid.Text = "DiscordID";
            // 
            // SDiscordID
            // 
            this.SDiscordID.AutoSize = true;
            this.SDiscordID.Location = new System.Drawing.Point(34, 526);
            this.SDiscordID.Name = "SDiscordID";
            this.SDiscordID.Size = new System.Drawing.Size(54, 13);
            this.SDiscordID.TabIndex = 41;
            this.SDiscordID.Text = "DiscordID";
            // 
            // selectedDiscordID
            // 
            this.selectedDiscordID.AutoSize = true;
            this.selectedDiscordID.Location = new System.Drawing.Point(203, 346);
            this.selectedDiscordID.Name = "selectedDiscordID";
            this.selectedDiscordID.Size = new System.Drawing.Size(76, 13);
            this.selectedDiscordID.TabIndex = 42;
            this.selectedDiscordID.Text = "DiscordID: null";
            // 
            // CDiscordID
            // 
            this.CDiscordID.AutoSize = true;
            this.CDiscordID.Location = new System.Drawing.Point(797, 139);
            this.CDiscordID.Name = "CDiscordID";
            this.CDiscordID.Size = new System.Drawing.Size(57, 13);
            this.CDiscordID.TabIndex = 43;
            this.CDiscordID.Text = "DiscordID:";
            // 
            // selectedDiscordIDText
            // 
            this.selectedDiscordIDText.Location = new System.Drawing.Point(109, 524);
            this.selectedDiscordIDText.Name = "selectedDiscordIDText";
            this.selectedDiscordIDText.Size = new System.Drawing.Size(411, 20);
            this.selectedDiscordIDText.TabIndex = 44;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 597);
            this.Controls.Add(this.selectedDiscordIDText);
            this.Controls.Add(this.CDiscordID);
            this.Controls.Add(this.selectedDiscordID);
            this.Controls.Add(this.SDiscordID);
            this.Controls.Add(this.CUsername);
            this.Controls.Add(this.selectedUsername);
            this.Controls.Add(this.SelectedUsernameText);
            this.Controls.Add(this.SUsername);
            this.Controls.Add(this.HWIDHWID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteKeyBtn);
            this.Controls.Add(this.createKeyBtn);
            this.Controls.Add(this.refreshListBtn);
            this.Controls.Add(this.updateKeyBtn);
            this.Controls.Add(this.SAdminLevel);
            this.Controls.Add(this.HWIDP);
            this.Controls.Add(this.sHWID);
            this.Controls.Add(this.selectedAdminLevelText);
            this.Controls.Add(this.selectedHWIDPermitterText);
            this.Controls.Add(this.selectedHWIDText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectedAdminLevel);
            this.Controls.Add(this.selectedHWIDPermitter);
            this.Controls.Add(this.selectedHWID);
            this.Controls.Add(this.CADMINLEVEL);
            this.Controls.Add(this.CHWIDP);
            this.Controls.Add(this.CHWID);
            this.Controls.Add(this.selectKeyBtn);
            this.Controls.Add(this.listView1);
            this.Name = "AdminPanel";
            this.Text = "HWID Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader hwid;
        private System.Windows.Forms.ColumnHeader givenby;
        private System.Windows.Forms.ColumnHeader AdminLevel;
        private System.Windows.Forms.Button selectKeyBtn;
        private System.Windows.Forms.Label CHWID;
        private System.Windows.Forms.Label CHWIDP;
        private System.Windows.Forms.Label CADMINLEVEL;
        private System.Windows.Forms.Label selectedAdminLevel;
        private System.Windows.Forms.Label selectedHWID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox selectedHWIDText;
        private System.Windows.Forms.TextBox selectedHWIDPermitterText;
        private System.Windows.Forms.TextBox selectedAdminLevelText;
        private System.Windows.Forms.Label SAdminLevel;
        private System.Windows.Forms.Label HWIDP;
        private System.Windows.Forms.Label sHWID;
        private System.Windows.Forms.Button updateKeyBtn;
        private System.Windows.Forms.Button refreshListBtn;
        private System.Windows.Forms.Button createKeyBtn;
        private System.Windows.Forms.Button deleteKeyBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label selectedHWIDPermitter;
        private System.Windows.Forms.Label HWIDHWID;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.Label SUsername;
        private System.Windows.Forms.TextBox SelectedUsernameText;
        private System.Windows.Forms.Label selectedUsername;
        private System.Windows.Forms.Label CUsername;
        private System.Windows.Forms.ColumnHeader discordid;
        private System.Windows.Forms.Label SDiscordID;
        private System.Windows.Forms.Label selectedDiscordID;
        private System.Windows.Forms.Label CDiscordID;
        private System.Windows.Forms.TextBox selectedDiscordIDText;
    }
}