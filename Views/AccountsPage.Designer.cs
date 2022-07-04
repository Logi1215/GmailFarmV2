namespace GmailFarmV2.Views
{
    partial class AccountsPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AccountTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackUpEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OneClickVerified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inbox = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CreateBox = new System.Windows.Forms.GroupBox();
            this.NoProxBox = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.AmountBox = new System.Windows.Forms.NumericUpDown();
            this.WindowBox = new System.Windows.Forms.NumericUpDown();
            this.RecoveryBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportForm = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ExportPathBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExportAmountBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.AbortButt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.activeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.OVCLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTable)).BeginInit();
            this.CreateBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowBox)).BeginInit();
            this.ExportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExportAmountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountTable
            // 
            this.AccountTable.AllowUserToAddRows = false;
            this.AccountTable.AllowUserToDeleteRows = false;
            this.AccountTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Username,
            this.Password,
            this.BackUpEmail,
            this.OneClickVerified,
            this.Proxy,
            this.Score,
            this.Status,
            this.UserPath,
            this.Inbox});
            this.AccountTable.Location = new System.Drawing.Point(-3, 0);
            this.AccountTable.Name = "AccountTable";
            this.AccountTable.RowTemplate.Height = 25;
            this.AccountTable.Size = new System.Drawing.Size(1005, 368);
            this.AccountTable.TabIndex = 0;
            this.AccountTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountTable_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.HeaderText = "User";
            this.Username.Name = "Username";
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Password
            // 
            this.Password.HeaderText = "Pass";
            this.Password.Name = "Password";
            this.Password.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BackUpEmail
            // 
            this.BackUpEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BackUpEmail.HeaderText = "R-Email";
            this.BackUpEmail.Name = "BackUpEmail";
            this.BackUpEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // OneClickVerified
            // 
            this.OneClickVerified.HeaderText = "OCV";
            this.OneClickVerified.Name = "OneClickVerified";
            this.OneClickVerified.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Proxy
            // 
            this.Proxy.HeaderText = "Proxy";
            this.Proxy.Name = "Proxy";
            this.Proxy.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UserPath
            // 
            this.UserPath.HeaderText = "UserPath";
            this.UserPath.Name = "UserPath";
            this.UserPath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserPath.Visible = false;
            // 
            // Inbox
            // 
            this.Inbox.HeaderText = "Inbox";
            this.Inbox.Name = "Inbox";
            this.Inbox.Text = "Inbox";
            this.Inbox.Width = 50;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(692, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(843, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateBox
            // 
            this.CreateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateBox.Controls.Add(this.NoProxBox);
            this.CreateBox.Controls.Add(this.button4);
            this.CreateBox.Controls.Add(this.button3);
            this.CreateBox.Controls.Add(this.CountryBox);
            this.CreateBox.Controls.Add(this.AmountBox);
            this.CreateBox.Controls.Add(this.WindowBox);
            this.CreateBox.Controls.Add(this.RecoveryBox);
            this.CreateBox.Controls.Add(this.label3);
            this.CreateBox.Controls.Add(this.label12);
            this.CreateBox.Controls.Add(this.label2);
            this.CreateBox.Controls.Add(this.label1);
            this.CreateBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBox.Location = new System.Drawing.Point(67, 70);
            this.CreateBox.Name = "CreateBox";
            this.CreateBox.Size = new System.Drawing.Size(346, 255);
            this.CreateBox.TabIndex = 3;
            this.CreateBox.TabStop = false;
            this.CreateBox.Visible = false;
            // 
            // NoProxBox
            // 
            this.NoProxBox.AutoSize = true;
            this.NoProxBox.ForeColor = System.Drawing.Color.White;
            this.NoProxBox.Location = new System.Drawing.Point(38, 158);
            this.NoProxBox.Name = "NoProxBox";
            this.NoProxBox.Size = new System.Drawing.Size(75, 19);
            this.NoProxBox.TabIndex = 10;
            this.NoProxBox.Text = "No Proxy";
            this.NoProxBox.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(-1, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(347, 26);
            this.button4.TabIndex = 9;
            this.button4.Text = "Close";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(92, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CountryBox
            // 
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Items.AddRange(new object[] {
            "Auto",
            "US"});
            this.CountryBox.Location = new System.Drawing.Point(194, 58);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(94, 23);
            this.CountryBox.TabIndex = 7;
            this.CountryBox.SelectedIndexChanged += new System.EventHandler(this.CountryBox_SelectedIndexChanged);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(53, 57);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(53, 23);
            this.AmountBox.TabIndex = 6;
            // 
            // WindowBox
            // 
            this.WindowBox.Location = new System.Drawing.Point(53, 130);
            this.WindowBox.Name = "WindowBox";
            this.WindowBox.Size = new System.Drawing.Size(53, 23);
            this.WindowBox.TabIndex = 5;
            // 
            // RecoveryBox
            // 
            this.RecoveryBox.Location = new System.Drawing.Point(180, 129);
            this.RecoveryBox.Name = "RecoveryBox";
            this.RecoveryBox.Size = new System.Drawing.Size(129, 23);
            this.RecoveryBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(191, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Recovery-Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(211, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "# of Windows";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // ExportForm
            // 
            this.ExportForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExportForm.Controls.Add(this.checkBox1);
            this.ExportForm.Controls.Add(this.ExportPathBox);
            this.ExportForm.Controls.Add(this.label5);
            this.ExportForm.Controls.Add(this.ExportAmountBox);
            this.ExportForm.Controls.Add(this.label4);
            this.ExportForm.Controls.Add(this.ExportButton);
            this.ExportForm.Controls.Add(this.button5);
            this.ExportForm.Location = new System.Drawing.Point(485, 70);
            this.ExportForm.Name = "ExportForm";
            this.ExportForm.Size = new System.Drawing.Size(346, 255);
            this.ExportForm.TabIndex = 4;
            this.ExportForm.TabStop = false;
            this.ExportForm.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(140, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 19);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Default";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ExportPathBox
            // 
            this.ExportPathBox.Location = new System.Drawing.Point(140, 93);
            this.ExportPathBox.Name = "ExportPathBox";
            this.ExportPathBox.Size = new System.Drawing.Size(172, 23);
            this.ExportPathBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(185, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Location";
            // 
            // ExportAmountBox
            // 
            this.ExportAmountBox.Location = new System.Drawing.Point(37, 93);
            this.ExportAmountBox.Name = "ExportAmountBox";
            this.ExportAmountBox.Size = new System.Drawing.Size(53, 23);
            this.ExportAmountBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amount";
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Location = new System.Drawing.Point(97, 189);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(157, 43);
            this.ExportButton.TabIndex = 10;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(347, 26);
            this.button5.TabIndex = 10;
            this.button5.Text = "Close";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AbortButt
            // 
            this.AbortButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AbortButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbortButt.ForeColor = System.Drawing.Color.White;
            this.AbortButt.Location = new System.Drawing.Point(837, 254);
            this.AbortButt.Name = "AbortButt";
            this.AbortButt.Size = new System.Drawing.Size(145, 48);
            this.AbortButt.TabIndex = 5;
            this.AbortButt.Text = "STOP";
            this.AbortButt.UseVisualStyleBackColor = false;
            this.AbortButt.Visible = false;
            this.AbortButt.Click += new System.EventHandler(this.AbortButt_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Acounts:";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.activeLabel.Location = new System.Drawing.Point(105, 433);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(54, 21);
            this.activeLabel.TabIndex = 7;
            this.activeLabel.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(40, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Errors:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(51, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "OVC:";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.Location = new System.Drawing.Point(99, 476);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(60, 21);
            this.ErrorLabel.TabIndex = 10;
            this.ErrorLabel.Text = "label10";
            // 
            // OVCLabel
            // 
            this.OVCLabel.AutoSize = true;
            this.OVCLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OVCLabel.Location = new System.Drawing.Point(99, 520);
            this.OVCLabel.Name = "OVCLabel";
            this.OVCLabel.Size = new System.Drawing.Size(57, 21);
            this.OVCLabel.TabIndex = 11;
            this.OVCLabel.Text = "label11";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(40, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Quick Stats";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(843, 374);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 48);
            this.button6.TabIndex = 13;
            this.button6.Text = "Remove Proxies";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(692, 374);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 48);
            this.button7.TabIndex = 14;
            this.button7.Text = "Change Recovery";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(541, 374);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(145, 48);
            this.button8.TabIndex = 15;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // AccountsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.OVCLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AbortButt);
            this.Controls.Add(this.ExportForm);
            this.Controls.Add(this.CreateBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AccountTable);
            this.Name = "AccountsPage";
            this.Size = new System.Drawing.Size(1002, 622);
            this.Load += new System.EventHandler(this.AccountsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountTable)).EndInit();
            this.CreateBox.ResumeLayout(false);
            this.CreateBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowBox)).EndInit();
            this.ExportForm.ResumeLayout(false);
            this.ExportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExportAmountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView AccountTable;
        private Button button1;
        private Button button2;
        private GroupBox CreateBox;
        private Label label12;
        private Label label2;
        private Label label1;
        private TextBox RecoveryBox;
        private Label label3;
        private ComboBox CountryBox;
        private NumericUpDown AmountBox;
        private NumericUpDown WindowBox;
        private Button button3;
        private Button button4;
        private GroupBox ExportForm;
        private Button ExportButton;
        private Button button5;
        private CheckBox checkBox1;
        private TextBox ExportPathBox;
        private Label label5;
        private NumericUpDown ExportAmountBox;
        private Label label4;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn BackUpEmail;
        private DataGridViewTextBoxColumn OneClickVerified;
        private DataGridViewTextBoxColumn Proxy;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn UserPath;
        private DataGridViewButtonColumn Inbox;
        private Button AbortButt;
        private CheckBox NoProxBox;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
        private Label activeLabel;
        private Label label8;
        private Label label9;
        private Label ErrorLabel;
        private Label OVCLabel;
        private Label label13;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
