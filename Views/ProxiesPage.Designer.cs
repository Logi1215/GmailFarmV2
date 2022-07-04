namespace GmailFarmV2.Views
{
    partial class ProxiesPage
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
            this.ProxyTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimesUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddproxyBox = new System.Windows.Forms.GroupBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProxVal = new System.Windows.Forms.Label();
            this.ProxTot = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProxyTable)).BeginInit();
            this.AddproxyBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProxyTable
            // 
            this.ProxyTable.AllowUserToAddRows = false;
            this.ProxyTable.AllowUserToDeleteRows = false;
            this.ProxyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProxyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IP,
            this.Port,
            this.Username,
            this.Password,
            this.Valid,
            this.Type,
            this.TimesUsed,
            this.TestButton});
            this.ProxyTable.Location = new System.Drawing.Point(-3, 0);
            this.ProxyTable.Name = "ProxyTable";
            this.ProxyTable.RowTemplate.Height = 25;
            this.ProxyTable.Size = new System.Drawing.Size(1005, 368);
            this.ProxyTable.TabIndex = 0;
            this.ProxyTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProxyTable_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // IP
            // 
            this.IP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.HeaderText = "User";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Valid
            // 
            this.Valid.HeaderText = "Valid";
            this.Valid.Name = "Valid";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // TimesUsed
            // 
            this.TimesUsed.HeaderText = "Times Used";
            this.TimesUsed.Name = "TimesUsed";
            // 
            // TestButton
            // 
            this.TestButton.HeaderText = "Test";
            this.TestButton.Name = "TestButton";
            this.TestButton.Width = 50;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(843, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(692, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddproxyBox
            // 
            this.AddproxyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddproxyBox.Controls.Add(this.TypeBox);
            this.AddproxyBox.Controls.Add(this.PassBox);
            this.AddproxyBox.Controls.Add(this.UserBox);
            this.AddproxyBox.Controls.Add(this.PortBox);
            this.AddproxyBox.Controls.Add(this.IPBox);
            this.AddproxyBox.Controls.Add(this.label3);
            this.AddproxyBox.Controls.Add(this.label2);
            this.AddproxyBox.Controls.Add(this.label5);
            this.AddproxyBox.Controls.Add(this.label1);
            this.AddproxyBox.Controls.Add(this.label4);
            this.AddproxyBox.Controls.Add(this.AddButton);
            this.AddproxyBox.Controls.Add(this.button5);
            this.AddproxyBox.Location = new System.Drawing.Point(102, 72);
            this.AddproxyBox.Name = "AddproxyBox";
            this.AddproxyBox.Size = new System.Drawing.Size(346, 255);
            this.AddproxyBox.TabIndex = 5;
            this.AddproxyBox.TabStop = false;
            this.AddproxyBox.Visible = false;
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS"});
            this.TypeBox.Location = new System.Drawing.Point(241, 67);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(73, 23);
            this.TypeBox.TabIndex = 20;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(145, 133);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(91, 23);
            this.PassBox.TabIndex = 19;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(6, 133);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(105, 23);
            this.UserBox.TabIndex = 18;
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(145, 67);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(67, 23);
            this.PortBox.TabIndex = 17;
            this.PortBox.TextChanged += new System.EventHandler(this.PortBox_TextChanged);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(6, 67);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(105, 23);
            this.IPBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(241, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(145, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "IP";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(97, 189);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(157, 43);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(40, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "Quick Stats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(25, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Valid:";
            // 
            // ProxVal
            // 
            this.ProxVal.AutoSize = true;
            this.ProxVal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProxVal.Location = new System.Drawing.Point(71, 473);
            this.ProxVal.Name = "ProxVal";
            this.ProxVal.Size = new System.Drawing.Size(19, 21);
            this.ProxVal.TabIndex = 16;
            this.ProxVal.Text = "0";
            // 
            // ProxTot
            // 
            this.ProxTot.AutoSize = true;
            this.ProxTot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProxTot.Location = new System.Drawing.Point(71, 433);
            this.ProxTot.Name = "ProxTot";
            this.ProxTot.Size = new System.Drawing.Size(19, 21);
            this.ProxTot.TabIndex = 17;
            this.ProxTot.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProxiesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProxTot);
            this.Controls.Add(this.ProxVal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AddproxyBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProxyTable);
            this.Name = "ProxiesPage";
            this.Size = new System.Drawing.Size(1002, 622);
            this.Load += new System.EventHandler(this.ProxiesPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProxyTable)).EndInit();
            this.AddproxyBox.ResumeLayout(false);
            this.AddproxyBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ProxyTable;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IP;
        private DataGridViewTextBoxColumn Port;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Valid;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn TimesUsed;
        private DataGridViewButtonColumn TestButton;
        private Button button1;
        private Button button2;
        private GroupBox AddproxyBox;
        private ComboBox TypeBox;
        private TextBox PassBox;
        private TextBox UserBox;
        private TextBox PortBox;
        private TextBox IPBox;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label1;
        private Label label4;
        private Button AddButton;
        private Button button5;
        private Label label13;
        private Label label6;
        private Label label7;
        private Label ProxVal;
        private Label ProxTot;
        private System.Windows.Forms.Timer timer1;
    }
}
