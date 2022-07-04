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
using static GmailFarmV2.Models.Models;

namespace GmailFarmV2.Views
{
    public partial class ProxiesPage : UserControl
    {
        public ProxiesPage()
        {
            InitializeComponent();
            
        }

        private void ProxiesPage_Load(object sender, EventArgs e)
        {
        ReUpdateProxyTable();
            timer1.Interval = 2000;
            timer1.Start();
        }
        public SqlConnection con;
        public void ReUpdateProxyTable()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory) + "\\Database1.mdf;Integrated Security=True");
            SqlCommand command;
            SqlDataReader Reader;
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }



            string Sql;
            Sql = "SELECT Id, IP, Port, UserName, Password, Valid, Type, TimesUsed FROM Proxies";
            command = new SqlCommand(Sql, con);
            Reader = command.ExecuteReader();

            ProxyTable.Rows.Clear();
            List<Proxy> ProxyList = new List<Proxy>();
            while (Reader.Read())
            {
                Proxy Proxy = new Proxy();
               Proxy.id = Reader.GetInt32(0);
               Proxy.IP = Reader.GetString(1);
                Proxy.Port = Reader.GetInt32(2);
                Proxy.UserName = Reader.GetString(3);
                Proxy.Password = Reader.GetString(4);
                Proxy.Valid = Convert.ToBoolean(Reader.GetValue(5));
                Proxy.Type = Reader.GetString(6);
                Proxy.TimesUsed = Reader.GetInt32(7);
                ProxyList.Add(Proxy);

            }
            Reader.Close();

            foreach (Proxy prox in ProxyList)
            {

                ProxyTable.Rows.Add(prox.id, prox.IP, prox.Port, prox.UserName, prox.Password, prox.Valid, prox.Type, prox.TimesUsed);
                
            }
        }
        public void RemoveProxy(int id)
        {
           
                string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory) + "\\Database1.mdf;Integrated Security=True";
                con = new SqlConnection(ConnectionString);
                SqlCommand command;
                SqlDataReader Reader;
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }



                string Sql;
                Sql = "DELETE FROM Proxies WHERE Id =@id";
                command = new SqlCommand(Sql, con);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                con.Close();
            
        }
        public void AddProxy(int Id, string IP, int port, string User, string pass, string type, bool valid, int timesused)
        {
            
                string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory) + "\\Database1.mdf;Integrated Security=True";
                con = new SqlConnection(ConnectionString);
                SqlCommand command;
                SqlDataReader Reader;
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }



                string Sql;
                Sql = "INSERT INTO Proxies (Id, IP, Port, Username, Password, Valid, Type, TimesUsed) VALUES ( @id, @ip, @port, @user, @pass, @valid, @type, @timesused)";
                command = new SqlCommand(Sql, con);
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@ip", IP);
                command.Parameters.AddWithValue("@port", port);
                command.Parameters.AddWithValue("@user", User);
                command.Parameters.AddWithValue("@pass", pass);
                command.Parameters.AddWithValue("@valid", valid);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@timesused", timesused);

            command.ExecuteNonQuery();


            ReUpdateProxyTable();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in ProxyTable.SelectedRows)
            {
                int selectedrowindex = ProxyTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = ProxyTable.Rows[selectedrowindex];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value); ;
                RemoveProxy(id);
            }
            ReUpdateProxyTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           AddproxyBox.Location = new Point(656, 367);
            AddproxyBox.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddproxyBox.Visible = false;
            IPBox.Clear();
            PortBox.Clear();
            TypeBox.ResetText();
            UserBox.Clear();
            PassBox.Clear();

        }
        public int GenerateRandomNo()
        {
            int _min = 0000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddProxy(GenerateRandomNo(), IPBox.Text, Convert.ToInt32(PortBox.Text), UserBox.Text, PassBox.Text, TypeBox.SelectedText, false, 0);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            AddproxyBox.Visible = false;
            IPBox.Clear();
            PortBox.Clear();
            TypeBox.ResetText();
            UserBox.Clear();
            PassBox.Clear();
        }

        private void PortBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ProxyTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var id = senderGrid.Rows[e.RowIndex].Cells[0].Value;
                id = Convert.ToInt32(id);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProxTot.Text = ProxyTable.Rows.Count.ToString();
            int val = 0;
            foreach (DataGridViewRow row in ProxyTable.Rows)
            {
                if (row.Cells["Valid"].Value == "True")
                {
                    val++;
                }
            }
            ProxVal.Text = val.ToString();
        }
    }
}
