namespace EOUpdate
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OnlineVersion = new System.Windows.Forms.TextBox();
            this.LocalVersion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // OnlineVersion
            // 
            this.OnlineVersion.Location = new System.Drawing.Point(13, 13);
            this.OnlineVersion.Name = "OnlineVersion";
            this.OnlineVersion.ReadOnly = true;
            this.OnlineVersion.Size = new System.Drawing.Size(155, 20);
            this.OnlineVersion.TabIndex = 0;
            this.OnlineVersion.Text = "Server Version: NIL";
            // 
            // LocalVersion
            // 
            this.LocalVersion.Location = new System.Drawing.Point(13, 53);
            this.LocalVersion.Name = "LocalVersion";
            this.LocalVersion.ReadOnly = true;
            this.LocalVersion.Size = new System.Drawing.Size(155, 20);
            this.LocalVersion.TabIndex = 1;
            this.LocalVersion.Text = "Local Version: NIL";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(13, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Download Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // UpdateLog
            // 
            this.UpdateLog.Location = new System.Drawing.Point(258, 13);
            this.UpdateLog.Name = "UpdateLog";
            this.UpdateLog.Size = new System.Drawing.Size(239, 137);
            this.UpdateLog.TabIndex = 3;
            this.UpdateLog.Text = resources.GetString("UpdateLog.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 216);
            this.Controls.Add(this.UpdateLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LocalVersion);
            this.Controls.Add(this.OnlineVersion);
            this.Name = "Form1";
            this.Text = "UpdateChecker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OnlineVersion;
        private System.Windows.Forms.TextBox LocalVersion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox UpdateLog;
    }
}

