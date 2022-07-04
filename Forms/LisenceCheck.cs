using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;
using System.Data;

namespace GmailFarmV2.Forms
{
    public partial class LisenceCheck : Form
    {
        public SqlConnection con;

        public LisenceCheck()
        {
            InitializeComponent();
            Properties.Settings.Default.Reload();
            KeyBox.Text = Properties.Settings.Default.SavedKey;
            PassBox.Text = Properties.Settings.Default.SavedPass;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = @"Data Source=100.42.52.204;Initial Catalog=elysiect_GmailFarm2;Persist Security Info=True;User ID=elysiect_elysiect;Password=HTQ63LxlBwz7b2Rn";
                con = new SqlConnection(ConnectionString);
                SqlCommand command;
                SqlDataReader Reader;
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }



                string Sql;
                Sql = "SELECT keyPass, IP, Id FROM ActiveKey WHERE [key] =@key";
                command = new SqlCommand(Sql, con);
                command.Parameters.AddWithValue("@key", KeyBox.Text);
                Reader = command.ExecuteReader();

                //My attempt for testing key and shit idk bruh

                string Pass = "";
                string hostName = "";
                int id = 0;

                while (Reader.Read())
                {
                    Pass = Reader.GetString(0);
                    hostName = Reader.GetString(1);
                    id = Reader.GetInt32(2);


                    if (Pass == PassBox.Text)
                    {
                        bool valid = CheckDate(KeyBox.Text);

                        if (valid == true)
                        {
                            if (hostName == Dns.GetHostName())
                            {
                                Properties.Settings.Default.SavedKey = KeyBox.Text.ToString();
                                Properties.Settings.Default.SavedPass = PassBox.Text.ToString();
                                Properties.Settings.Default.Save();
                               
                                LaunchForm1();

                            }
                            else if (hostName == "not set")
                            {
                                SetDevice(KeyBox.Text);
                                
                                Properties.Settings.Default.SavedKey = KeyBox.Text.ToString();
                                Properties.Settings.Default.SavedPass = PassBox.Text.ToString();
                                Properties.Settings.Default.Save();
                               
                                LaunchForm1();
                            }
                            else
                            {
                                KeyBox.Text = "Wrong Device Assigned";
                            }
                        }
                        else
                        {
                            DisableKey(KeyBox.Text);
                            KeyBox.Text = "Key has Expired!";
                        }
                    }
                    else
                    {
                        KeyBox.Text = "Wrong Password or Key";
                    }
                }
                Reader.Close();
                con.Close();
                return;
            }
            catch
            {
                KeyBox.Text = "Error: 101, Restart Program";
                return;
            }
        }
        public void DeleteKey(string oldkey)
        {
            string ConnectionString = @"Data Source=100.42.52.204;Initial Catalog=elysiect_GmailFarm2;Persist Security Info=True;User ID=elysiect_elysiect;Password=HTQ63LxlBwz7b2Rn";
            con = new SqlConnection(ConnectionString);

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand command;

            SqlDataAdapter updater = new SqlDataAdapter();
            string Sql;
            Sql = "Delete FROM ActiveKey WHERE [key] =@key";
            command = new SqlCommand(Sql, con);
            command.Parameters.AddWithValue("@key", oldkey);
            command.ExecuteNonQuery();

            con.Close();
            command.Dispose();

        }
        public void SetDevice(string id)
        {
            string ConnectionString = @"Data Source=100.42.52.204;Initial Catalog=elysiect_GmailFarm2;Persist Security Info=True;User ID=elysiect_elysiect;Password=HTQ63LxlBwz7b2Rn";
            con = new SqlConnection(ConnectionString);

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand command;

            SqlDataAdapter updater = new SqlDataAdapter();
            string Sql;
            Sql = "UPDATE ActiveKey SET IP =@ip  WHERE [key] =@key";
            command = new SqlCommand(Sql, con);
            command.Parameters.AddWithValue("@key", id);
            command.Parameters.AddWithValue("@ip", Dns.GetHostName());
            command.ExecuteNonQuery();

            con.Close();
            command.Dispose();
        }
        public void DisableKey(string oldkey)
        {
            int id = 0;
            string key = "", keyPass = "", assignedUser = "";
            DateTime created = DateTime.Today, expired = DateTime.Today;

            string ConnectionString = @"Data Source=100.42.52.204;Initial Catalog=elysiect_GmailFarm2;Persist Security Info=True;User ID=elysiect_elysiect;Password=HTQ63LxlBwz7b2Rn";
            con = new SqlConnection(ConnectionString);

            con.Open();
            SqlCommand command;
            SqlDataReader Reader;
            SqlDataAdapter updater = new SqlDataAdapter();
            string Sql;
            Sql = "SELECT Id, keyPass, dateCreated, ExpireDate, assignedUser FROM ActiveKey WHERE [key] =@key";
            command = new SqlCommand(Sql, con);
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
            command = new SqlCommand(Sql, con);
            command.Parameters.AddWithValue("@id", oldkey);
            command.ExecuteNonQuery();
            command.Dispose();

            Sql = "INSERT INTO ExpiredKey (Id, [key], keyPass, dateCreated, ExpireDate, assignedUser)" +
                  " VALUES (@id, @key, @keyPass, @dateCreated, @ExpireDate, @assignedUser)";
            command = new SqlCommand(Sql, con);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@key", oldkey);
            command.Parameters.AddWithValue("@keyPass", keyPass);
            command.Parameters.AddWithValue("@dateCreated", created);
            command.Parameters.AddWithValue("@ExpireDate", expired);
            command.Parameters.AddWithValue("@assignedUser", assignedUser);

            int effected = command.ExecuteNonQuery();
            command.Dispose();
            con.Close();

            DeleteKey(oldkey);

        }
        public bool CheckDate(string key)
        {
            bool valid = false;
            DateTime date = DateTime.Today;
            string ConnectionString = @"Data Source=100.42.52.204;Initial Catalog=elysiect_GmailFarm2;Persist Security Info=True;User ID=elysiect_elysiect;Password=HTQ63LxlBwz7b2Rn";
            con = new SqlConnection(ConnectionString);

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand command;
            SqlDataReader Reader;
            SqlDataAdapter updater = new SqlDataAdapter();
            string Sql;
            Sql = "SELECT ExpireDate FROM ActiveKey WHERE [key] =@key";
            command = new SqlCommand(Sql, con);
            command.Parameters.AddWithValue("@key", key);
            Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                DateTime Expiredate = Reader.GetDateTime(0);
                if (Expiredate >= date)
                {
                    valid = true;
                }
            }






            Reader.Close();
            con.Close();
            command.Dispose();

            return valid;
        }
        public void LaunchForm1()
        {
            Form1 form1 = new Form1();
            form1.Show();
            form1.Owner = this;
            this.Hide();

        }

        private void LisenceCheck_Load(object sender, EventArgs e)
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

        private void DiscordLink_Click(object sender, EventArgs e)
        {
            var uri = "https://discord.gg/qUdFRvgEcd";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            System.Diagnostics.Process.Start(psi);
        }
        
        
    }
}
