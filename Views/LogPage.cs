using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmailFarmV2.Views
{
    public partial class LogPage : UserControl
    {
        public LogPage()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void LogPage_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                DateTime dateTime = DateTime.Now;
                string UserPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string path = Path.Combine(UserPath, "Downloads\\") + dateTime.Date.DayOfWeek.ToString() + "___LIVELOG(DontTouchWhileActive)" + ".txt";
                textBox1.Text = File.ReadAllText(path);
            }
            catch
            {

            }
        }
    }
}
