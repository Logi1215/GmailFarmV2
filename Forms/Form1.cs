namespace GmailFarmV2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
           ApiHelper.InitializeClient();
        }

        private bool formClosed;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            accountsPage1.Visible = true;
            proxiesPage2.Visible = false;
            settingsPage1.Visible = false;
            logPage1.Visible = false;
            Task.Run(() => NightCheckAsync());
           
        }

        public void NightCheckAsync()
        {
            
                if (timer1 != null)
                {
                    timer1.Stop();
                    timer1.Dispose();
                }


                var midnightTonight = DateTime.Today.AddDays(1);
                var differenceInMilliseconds = (midnightTonight - DateTime.Now).TotalMilliseconds;
                timer1.Interval = (int)differenceInMilliseconds;
                timer1.Start();


           
        }

        private void AccountButt_Click(object sender, EventArgs e)
        {
            accountsPage1.Visible = true;
            proxiesPage2.Visible = false;
            settingsPage1.Visible = false;
            logPage1.Visible = false;
        }

        private void ProxiesButt_Click(object sender, EventArgs e)
        {
            accountsPage1.Visible = false;
            proxiesPage2.Visible = true;
            settingsPage1.Visible = false;
            logPage1.Visible = false;
        }

        private void SettingsButt_Click(object sender, EventArgs e)
        {
            accountsPage1.Visible = false;
            proxiesPage2.Visible = false;
            settingsPage1.Visible = true;
            logPage1.Visible = false;
        }

        private void LogButt_Click(object sender, EventArgs e)
        {
            accountsPage1.Visible = false;
            proxiesPage2.Visible = false;
            settingsPage1.Visible = false;
            logPage1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var uri = "https://elysiumproject.store";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            System.Diagnostics.Process.Start(psi);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (!formClosed)
            {
                this.formClosed = true;
                this.Owner.Close();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            settingsPage1.UpdateKeyBox();
            Task.Run(() => NightCheckAsync());
        }
    }
}