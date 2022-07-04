namespace GmailFarmV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsButt = new System.Windows.Forms.Button();
            this.ProxiesButt = new System.Windows.Forms.Button();
            this.AccountButt = new System.Windows.Forms.Button();
            this.LogButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logPage1 = new GmailFarmV2.Views.LogPage();
            this.settingsPage1 = new GmailFarmV2.Views.SettingsPage();
            this.accountsPage1 = new GmailFarmV2.Views.AccountsPage();
            this.proxiesPage2 = new GmailFarmV2.Views.ProxiesPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.SettingsButt);
            this.panel1.Controls.Add(this.ProxiesButt);
            this.panel1.Controls.Add(this.AccountButt);
            this.panel1.Controls.Add(this.LogButt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 622);
            this.panel1.TabIndex = 0;
            // 
            // SettingsButt
            // 
            this.SettingsButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SettingsButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SettingsButt.FlatAppearance.BorderSize = 0;
            this.SettingsButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsButt.ForeColor = System.Drawing.Color.White;
            this.SettingsButt.Location = new System.Drawing.Point(0, 340);
            this.SettingsButt.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsButt.Name = "SettingsButt";
            this.SettingsButt.Size = new System.Drawing.Size(199, 73);
            this.SettingsButt.TabIndex = 3;
            this.SettingsButt.Text = "Settings";
            this.SettingsButt.UseVisualStyleBackColor = false;
            this.SettingsButt.Click += new System.EventHandler(this.SettingsButt_Click);
            // 
            // ProxiesButt
            // 
            this.ProxiesButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProxiesButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProxiesButt.FlatAppearance.BorderSize = 0;
            this.ProxiesButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProxiesButt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProxiesButt.ForeColor = System.Drawing.Color.White;
            this.ProxiesButt.Location = new System.Drawing.Point(0, 238);
            this.ProxiesButt.Margin = new System.Windows.Forms.Padding(0);
            this.ProxiesButt.Name = "ProxiesButt";
            this.ProxiesButt.Size = new System.Drawing.Size(199, 73);
            this.ProxiesButt.TabIndex = 1;
            this.ProxiesButt.Text = "Proxies";
            this.ProxiesButt.UseVisualStyleBackColor = false;
            this.ProxiesButt.Click += new System.EventHandler(this.ProxiesButt_Click);
            // 
            // AccountButt
            // 
            this.AccountButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AccountButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AccountButt.FlatAppearance.BorderSize = 0;
            this.AccountButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountButt.ForeColor = System.Drawing.Color.White;
            this.AccountButt.Location = new System.Drawing.Point(0, 136);
            this.AccountButt.Margin = new System.Windows.Forms.Padding(0);
            this.AccountButt.Name = "AccountButt";
            this.AccountButt.Size = new System.Drawing.Size(199, 73);
            this.AccountButt.TabIndex = 2;
            this.AccountButt.Text = "Accounts";
            this.AccountButt.UseVisualStyleBackColor = false;
            this.AccountButt.Click += new System.EventHandler(this.AccountButt_Click);
            // 
            // LogButt
            // 
            this.LogButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogButt.FlatAppearance.BorderSize = 0;
            this.LogButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogButt.ForeColor = System.Drawing.Color.White;
            this.LogButt.Location = new System.Drawing.Point(0, 540);
            this.LogButt.Margin = new System.Windows.Forms.Padding(0);
            this.LogButt.Name = "LogButt";
            this.LogButt.Size = new System.Drawing.Size(199, 73);
            this.LogButt.TabIndex = 4;
            this.LogButt.Text = "Live Log";
            this.LogButt.UseVisualStyleBackColor = false;
            this.LogButt.Click += new System.EventHandler(this.LogButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "EP-GmailFarm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logPage1
            // 
            this.logPage1.Location = new System.Drawing.Point(202, 0);
            this.logPage1.Name = "logPage1";
            this.logPage1.Size = new System.Drawing.Size(1002, 622);
            this.logPage1.TabIndex = 2;
            // 
            // settingsPage1
            // 
            this.settingsPage1.Location = new System.Drawing.Point(202, 0);
            this.settingsPage1.Name = "settingsPage1";
            this.settingsPage1.Size = new System.Drawing.Size(1002, 622);
            this.settingsPage1.TabIndex = 4;
            // 
            // accountsPage1
            // 
            this.accountsPage1.Location = new System.Drawing.Point(202, 0);
            this.accountsPage1.Name = "accountsPage1";
            this.accountsPage1.Size = new System.Drawing.Size(1002, 622);
            this.accountsPage1.TabIndex = 5;
            // 
            // proxiesPage2
            // 
            this.proxiesPage2.Location = new System.Drawing.Point(202, 0);
            this.proxiesPage2.Name = "proxiesPage2";
            this.proxiesPage2.Size = new System.Drawing.Size(1002, 622);
            this.proxiesPage2.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1204, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.proxiesPage2);
            this.Controls.Add(this.logPage1);
            this.Controls.Add(this.settingsPage1);
            this.Controls.Add(this.accountsPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button ProxiesButt;
        private Button SettingsButt;
        private Button AccountButt;
        private Button LogButt;
        private Views.LogPage logPage1;
        private Views.ProxiesPage proxiesPage1;
        private Views.SettingsPage settingsPage1;
        private Views.AccountsPage accountsPage1;
        private Views.ProxiesPage proxiesPage2;
        private System.Windows.Forms.Timer timer1;
    }
}