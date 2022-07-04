using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmailFarmV2.Views
{
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();
            
        }
       
        public void DisableKey(string oldkey)
        {
            int id = 0;
            string key = "", keyPass = "", assignedUser = "";
            DateTime created = DateTime.Today, expired = DateTime.Today;

            string ConnectionString = @"Data Source=100.42.52.204;Initial Catalog=elysiect_GmailFarm2;Persist Security Info=True;User ID=elysiect_elysiect;Password=HTQ63LxlBwz7b2Rn";
            Connection = new SqlConnection(ConnectionString);

            Connection.Open();
            SqlCommand command;
            SqlDataReader Reader;
            SqlDataAdapter updater = new SqlDataAdapter();
            string Sql;
            Sql = "SELECT Id, keyPass, dateCreated, ExpireDate, assignedUser FROM ActiveKey WHERE [key] =@key";
            command = new SqlCommand(Sql, Connection);
            command.Parameters.AddWithValue("@key", oldkey);
            Reader = command.ExecuteReader();


            //setting values?
            while (Reader.Read())
            {
                id = Reader.GetInt32(0);
                key = oldkey;
                keyPass = Reader.GetString(1);
                created = Reader.GetDateTime(2);
                expired = Reader.GetDateTime(3);
                assignedUser = Reader.GetString(4);
            }

            Reader.Close();
            command.Dispose();



            Sql = "DELETE FROM ActiveKey WHERE [key] = @id";
            command = new SqlCommand(Sql, Connection);
            command.Parameters.AddWithValue("@id", oldkey);
            command.ExecuteNonQuery();
            command.Dispose();

            Sql = "INSERT INTO ExpiredKey (Id, [key], keyPass, dateCreated, ExpireDate, assignedUser)" +
                  " VALUES (@id, @key, @keyPass, @dateCreated, @ExpireDate, @assignedUser)";
            command = new SqlCommand(Sql, Connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@key", oldkey);
            command.Parameters.AddWithValue("@keyPass", keyPass);
            command.Parameters.AddWithValue("@dateCreated", created);
            command.Parameters.AddWithValue("@ExpireDate", expired);
            command.Parameters.AddWithValue("@assignedUser", assignedUser);

            int effected = command.ExecuteNonQuery();
            command.Dispose();
            Connection.Close();

            DeleteKey(oldkey);

        }
        public void DeleteKey(string oldkey)
        {
            string ConnectionString = @"Data Source=100.42.52.204;Initial Catalog=elysiect_GmailFarm2;Persist Security Info=True;User ID=elysiect_elysiect;Password=HTQ63LxlBwz7b2Rn";
            Connection = new SqlConnection(ConnectionString);

            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }

            SqlCommand command;

            SqlDataAdapter updater = new SqlDataAdapter();
            string Sql;
            Sql = "Delete FROM ActiveKey WHERE [key] =@key";
            command = new SqlCommand(Sql, Connection);
            command.Parameters.AddWithValue("@key", oldkey);
            command.ExecuteNonQuery();

            Connection.Close();
            command.Dispose();

        }
        private SqlConnection Connection;
        public void UpdateKeyBox()
        {
            string ConnectionString = @"Data Source=100.42.52.204;Initial Catalog=elysiect_GmailFarm2;Persist Security Info=True;User ID=elysiect_elysiect;Password=HTQ63LxlBwz7b2Rn";
            Connection = new SqlConnection(ConnectionString);
            SqlCommand command;
            SqlDataReader Reader;
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }



            string Sql;
            Sql = "SELECT ExpireDate, AssignedUser FROM ActiveKey WHERE [key] =@key";
            command = new SqlCommand(Sql, Connection);
            command.Parameters.AddWithValue("@key", Properties.Settings.Default.SavedKey);
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                DateTime dateTime = DateTime.Now;
                var expireDate = Reader.GetDateTime(0);

                int days = (expireDate - dateTime).Days;
                if(days < 0)
                {
                    DisableKey(Properties.Settings.Default.SavedKey);
                    Form1.ActiveForm.Close();
                }
                KeyLabel.Text = "This key has " + days.ToString() + " days remaining";
                AssignedBox.Text = Reader.GetString(1);
                KeyBox.Text = Properties.Settings.Default.SavedKey;
            }
            Reader.Close();
            Connection.Close();

        }
        private void SettingsPage_Load(object sender, EventArgs e)
        {
           Updatebalance();
           UpdateKeyBox();
            textBox1.Text = Properties.Settings.Default.SavedAPIKey;
            textBox2.Text = Properties.Settings.Default.SavedClipTester;
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SavedAPIKey = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SavedClipTester = textBox2.Text;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var uri = "https://sms-gen.com/userarea/addfunds";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            System.Diagnostics.Process.Start(psi);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var uri = "https://sms-gen.com/home";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            System.Diagnostics.Process.Start(psi);
            
        }
       
       
        public async Task Updatebalance()
        {
               var balance = await smsGen.CheckBalance();
                 SMSAmount.Text = "$" + balance.balance.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Updatebalance();
           
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
           
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var uri = "https://discord.gg/qUdFRvgEcd";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            System.Diagnostics.Process.Start(psi);
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var uri = "mailto:neel.logan1215@gmail.com";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
