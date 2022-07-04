using GmailFarmV2.Forms;
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
using OpenQA.Selenium;
using static GmailFarmV2.Models.Models;
using RandomNameGeneratorLibrary;
using SeleniumUndetectedChromeDriver;
using PasswordGenerator;
using static GmailFarmV2.smsGen;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.DevTools.V102.Database;

namespace GmailFarmV2.Views
{
    public partial class AccountsPage : UserControl
    {
        public AccountsPage()
        {
            InitializeComponent();
            
        }

        private void AccountsPage_Load(object sender, EventArgs e)
        {
            
            ReUpdateTable();
            timer1.Interval = 30000;
            timer1.Start();
            activeLabel.Text = AccountTable.Rows.Count.ToString();
            int errors = 0;
            foreach (DataGridViewRow row in AccountTable.Rows)
            {
                if (row.Cells["Status"].Value == "Error")
                {
                    errors++;
                }
            }
            ErrorLabel.Text = errors.ToString();
            int ovc = 0;
            foreach (DataGridViewRow row in AccountTable.Rows)
            {
                if (row.Cells["OneClickVerified"].Value.ToString() == "True")
                {
                    ovc++;
                }
            }
            OVCLabel.Text = ovc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string UserPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            try
            {
                if (AccountTable.SelectedRows.Count >= 1)
                {
                    string dateOrg = DateTime.Now.ToString("yyyyMMdd_hhmmss");
                    string dateTrimmed = String.Concat(dateOrg.Where(c => !Char.IsWhiteSpace(c)));
                    string path = Path.Combine(UserPath, "Downloads\\") + dateTrimmed + "_" + AccountTable.SelectedRows.Count + ".txt";

                    using (StreamWriter newFile = File.CreateText(path))
                    {
                        foreach (DataGridViewRow row in AccountTable.SelectedRows)
                        {
                            int selectedrowindex = AccountTable.SelectedCells[0].RowIndex;
                            DataGridViewRow selectedRow = AccountTable.Rows[selectedrowindex];
                            string answer = selectedRow.Cells["Username"].Value.ToString();
                            answer = answer + ", " + selectedRow.Cells["Password"].Value.ToString();
                            answer = answer + ", " + selectedRow.Cells["BackUpEmail"].Value.ToString();
                            newFile.WriteLine(answer);
                            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value); 
                            deleteAccount(id);
                        }
                    }

                }
                else
                {
                   ExportForm.Location = new Point(656, 367);
                    ExportForm.Visible = true;
                }

                //  this.mainDataBaseDataSet.AccountTabel.WriteXml("SavedAccounts.xml");

                ReUpdateTable();


            }
            catch
            {

            }

            ReUpdateTable();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateBox.Visible = false;
            WindowBox.Value = 0;
            AmountBox.Value = 0;
            CountryBox.Text = "Auto";
        }


        static readonly CancellationTokenSource phonCancel = new CancellationTokenSource();
        private void button1_Click(object sender, EventArgs e)
        {
            CreateBox.Location = new Point(656, 367);
            CreateBox.Visible = true;
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            ExportForm.Visible = false;
            ExportAmountBox.ResetText();
            ExportPathBox.Clear();
        }
        public SqlConnection con;
        public List<Account> GetAccounts()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory) + "\\Database1.mdf;Integrated Security=True");
            SqlCommand command;
            SqlDataReader Reader;
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }



            string Sql;
            Sql = "SELECT Id, UserName, Password, BackUpEmail, OneClickVerified, Proxy, Status, Score, UserPath FROM Account";
            command = new SqlCommand(Sql, con);
            Reader = command.ExecuteReader();

            
            List<Account> AccountsList = new List<Account>();
            while (Reader.Read())
            {
                Account Account = new Account();
                Account.Proxy = new Models.Models.Proxy();
                Account.UserPath = new UserPath();
                Account.Id = Reader.GetInt32(0);
                Account.UserName = Reader.GetString(1);
                Account.Password = Reader.GetString(2);
                Account.BackUpEmail = Reader.GetString(3);
                Account.OneClickVerified = Convert.ToBoolean(Reader.GetValue(4));
                Account.Proxy.id = Reader.GetInt32(5);
                Account.status = Reader.GetString(6);
                Account.score = Reader.GetDecimal(7);
                Account.UserPath.Id = Convert.ToInt32(Reader.GetValue(8));
                AccountsList.Add(Account);

            }
            Reader.Close();
            return AccountsList;
        }
        public void ReUpdateTable()
        {
           
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory) + "\\Database1.mdf;Integrated Security=True");
            SqlCommand command;
            SqlDataReader Reader;
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }



            string Sql;
            Sql = "SELECT Id, UserName, Password, BackUpEmail, OneClickVerified, Proxy, Status, Score, UserPath FROM Account";
            command = new SqlCommand(Sql, con);
            Reader = command.ExecuteReader();

        AccountTable.Rows.Clear();
        List<Account> AccountsList = new List<Account>();
            while (Reader.Read())
            {
                Account Account = new Account();
                Account.Proxy = new Models.Models.Proxy();
                Account.UserPath = new UserPath();
                Account.Id = Reader.GetInt32(0);
                Account.UserName = Reader.GetString(1);
                Account.Password = Reader.GetString(2);
                Account.BackUpEmail = Reader.GetString(3);
                Account.OneClickVerified = Convert.ToBoolean(Reader.GetValue(4));
                Account.Proxy.id = Reader.GetInt32(5);
                Account.status = Reader.GetString(6);
                Account.score = Reader.GetDecimal(7);
                Account.UserPath.Id = Convert.ToInt32(Reader.GetValue(8));
                AccountsList.Add(Account);

            }
            Reader.Close();
            con.Close();
            
            foreach(Account Account in AccountsList)
            {
                
               
                AccountTable.Rows.Add(Account.Id, Account.UserName, Account.Password, Account.BackUpEmail, Account.OneClickVerified, Account.Proxy.id, Account.score, Account.status);

            }
        }
        public int GenerateRandomNo()
        {
            int _min = 0000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
        public void insertPath(string path, int id)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory) + "\\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(ConnectionString);
            SqlCommand command;
            
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }



            string Sql;
            Sql = "INSERT INTO UserPath (Id, Path) VALUES ( @id, @path)";
            command = new SqlCommand(Sql, con);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@path", path);
           
            command.ExecuteNonQuery();
            con.Close();
        }
        public void InsertAccount(string user, string pass, string email, bool OCV, int prox, string status, decimal score, int path)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory) + "\\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(ConnectionString);
            SqlCommand command;
            
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            


            string Sql;
            Sql = "INSERT INTO Account (Id, UserName, Password, BackUpEmail, OneClickVerified, Proxy, Status, Score, UserPath) VALUES ( @id, @user, @pass, @back, @one, @prox, @stat, @score, @userpath)";
            command = new SqlCommand(Sql, con);
            command.Parameters.AddWithValue("@id", GenerateRandomNo());
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);
            command.Parameters.AddWithValue("@back", email);
            command.Parameters.AddWithValue("@one", OCV);
            command.Parameters.AddWithValue("@prox", prox);
            command.Parameters.AddWithValue("@stat", status);
            command.Parameters.AddWithValue("@score", score);
            command.Parameters.AddWithValue("@userpath", path);
            command.ExecuteNonQuery();
            con.Close();

            Thread.Sleep(1000);
            ReUpdateTable();


        }
        public void deleteAccount(int id)
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
            Sql = "DELETE FROM Account WHERE Id =@id";
            command = new SqlCommand(Sql, con);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            con.Close();
        }
        public void writeStatus(int windowNum, string message)
        {
            DateTime dateTime = DateTime.Now;
            string UserPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string path = Path.Combine(UserPath, "Downloads\\") + dateTime.Date.DayOfWeek.ToString() + "___LIVELOG(DontTouchWhileActive)" + ".txt";
            string newMessage;

            newMessage = "Win-" + windowNum.ToString() + ":" + dateTime.Date.ToString() + ":" + message + "...";

            File.AppendAllText(path, newMessage + Environment.NewLine);


        }
        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

            string dateOrg = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            string dateTrimmed = String.Concat(dateOrg.Where(c => !Char.IsWhiteSpace(c)));
            string path = @"c:\temp\" + dateTrimmed + "_" + ExportAmountBox.Text + ".txt";
            List<Account> accounts = new List<Account>();
            accounts = GetAccounts();
            using (StreamWriter newFile = File.CreateText(path))
            {

                int loop = 0;
                foreach (Account account in accounts)
                {
                    if (loop == Convert.ToInt32(ExportAmountBox.Text))
                    {
                        break;
                    }
                    string answer = account.UserName;
                    answer = answer + ", " + account.Password;
                    answer = answer + ", " + account.BackUpEmail;
                    newFile.WriteLine(answer);
                    deleteAccount(account.Id);
                    loop++;
                    
                }
                ReUpdateTable();
            }
        }
        private UndetectedChromeDriver driver;
        public List<CancellationTokenSource> cancellationTokenSources = new List<CancellationTokenSource>();
        public void CreateStart(int win, string country, int amount, string recoveryEmail, bool noProxy)
        {
            int perTask = amount / win;
            int lop = 0;
            
            while(lop < win)
            {
                CancellationTokenSource _tokenSource = new CancellationTokenSource();
                var token = _tokenSource.Token;
                cancellationTokenSources.Add(_tokenSource);
                Task.Run(() => createAccount(lop, country, perTask, noProxy, token, recoveryEmail));

                lop++;
            }
        }
        public void OpenInbox(string path, string User, string password)
        {
            ChromeOptions option = new ChromeOptions();
            var driverExecutablePath = Directory.GetParent(Environment.CurrentDirectory) + $@"\Driver\chromedriver.exe";
            
            


             driver = UndetectedChromeDriver.Create(options: option, driverExecutablePath: driverExecutablePath, userDataDir: path, hideCommandPromptWindow: true);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Manage().Window.Size = new Size(60, 100);
            Thread.Sleep(2000);
            driver.GoToUrl("https://accounts.google.com/Logout?hl=en&continue=https://mail.google.com&service=mail&timeStmp=1656101256&secTok=.AG5fkS9WDQlCRbWC54a1zmYc-XayzFJmbQ&ec=GAdAFw");
            option.AddArgument("--disable-gpu");
            Thread.Sleep(3000);


            //IWebElement signBut = driver.FindElement(By.XPath("/html/body/header/div/div/div/a[2]"));
            //signBut.Click();
            try
            {
                wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div/div/ul/li[3]/div")));
                IWebElement prof = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div/div/ul/li[3]/div"));
                prof.Click();
                IWebElement remove = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div/div/ul/li[1]/div"));
                remove.Click();
                wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[5]/div/div[2]/div[3]/div[1]")));
                IWebElement yes = driver.FindElement(By.XPath("/html/body/div[5]/div/div[2]/div[3]/div[1]"));
                yes.Click();
                
                // IWebElement sign = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div/div/ul/li[3]/div"));
                // sign.Click();
                // Thread.Sleep(2000);

            }
            catch
            {

            }

            try
            {
                wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div/div[1]/div/div[1]/input")));
                IWebElement email = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div/div[1]/div/div[1]/input"));
                email.Click();
                email.SendKeys(User);
            wait.Until(driver => driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button")));
            IWebElement but = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button"));
                but.Click();

                wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input")));
                IWebElement pas = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input"));
                pas.Click();
                pas.SendKeys(password);
                Thread.Sleep(2000);
                wait.Until(driver => driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button")));
            IWebElement next = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button"));
                next.Click();
            }
            catch
            {

            }
            
            
           
            driver.Manage().Window.Maximize();

            




            //browser.Navigate().GoToUrl("https://mail.google.com/mail/u/0/#inbox");

        }
        public static async Task<Models.Models.Proxy> getProxy()
        {
            Models.Models.Proxy newProxy = new Models.Models.Proxy();
            SqlConnection con;
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

            
            List<Models.Models.Proxy> ProxyList = new List<Models.Models.Proxy>();
            while (Reader.Read())
            {
                Models.Models.Proxy Proxy = new Models.Models.Proxy();
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
            Random random = new Random();
            int index = random.Next(ProxyList.Count);
            newProxy = ProxyList[index];

            return newProxy;
        }
        public async Task createAccount(int winNum, string country, int amount, bool noProxy, CancellationToken token, string backupEmail) 
        {
            int loop = 0;
            while(loop < amount)
            {
                while (1 > 0)
                {
                    System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
                    
                    stopWatch.Start();

                    Models.Models.Proxy proxy = new Models.Models.Proxy();
                if(noProxy == false)
                {
                    proxy = new Models.Models.Proxy();
                        proxy = await getProxy();

                }
                OpenQA.Selenium.Proxy p = new OpenQA.Selenium.Proxy();
                p.IsAutoDetect = false;
                p.Kind = ProxyKind.Manual;

                if (country == "Auto")
                {
                    country = "US";
                }

                PersonNameGenerator Name = new PersonNameGenerator();
                string userFirstName = Name.GenerateRandomFirstName();
                string userLastName = Name.GenerateRandomLastName();
                var pas = new Password(10);
                var pwd = pas.Next();

                numberLayout number = new numberLayout();
               
                while(number.number == null)
                {
                   number = await GetNumber(country.ToString());
                    
                }

                ChromeOptions option = new ChromeOptions();

                if(noProxy != true)
                {
                    string host = proxy.IP + ":" + proxy.Port;
                    if (proxy.Type == "HTTP")
                    {

                        p.HttpProxy = host;
                    }
                    else
                    {
                        p.SocksProxy = host;
                        p.SocksUserName = proxy.UserName;
                    p.SocksPassword = proxy.Password;
                    }
                    option.Proxy = p;
                }

                //Selenium instance setup
                //Path.Combine(System.IO.Directory.GetCurrentDirectory(), 
                string profilePath = @"C:\Users\neell\AppData\Local\Temp\scoped_dir24000_1083721619\Default";
                
                
                var driverExecutablePath = Directory.GetParent(Environment.CurrentDirectory) + $@"\Driver\chromedriver.exe";




                 var browser = UndetectedChromeDriver.Create(options: option, driverExecutablePath: driverExecutablePath, userDataDir: profilePath, hideCommandPromptWindow: true);
                    var wait = new WebDriverWait(browser, TimeSpan.FromSeconds(20));
                    // browser.Manage().Window.Minimize();
                    Thread.Sleep(1000);
                    browser.Navigate().GoToUrl("https://accounts.google.com/signup/v2/webcreateaccount?continue=https%3A%2F%2Fwww.google.com%2F&hl=en&biz=false&flowName=GlifWebSignIn&flowEntry=SignUp");
                    Thread.Sleep(1000);
                    wait.Until(browser => browser.FindElement(By.Id("firstName")));
                    IWebElement FirstName = browser.FindElement(By.Id("firstName"));
                FirstName.Click();
                FirstName.SendKeys(userFirstName);

                IWebElement LastName = browser.FindElement(By.Id("lastName"));
                LastName.Click();
                LastName.SendKeys(userLastName);
                //Status Update
                writeStatus(winNum, "Creating User Info");
                //making it wait for autogen name
                Thread.Sleep(4000);
                IWebElement UserName = browser.FindElement(By.Name("Username"));
                string RealUserName = UserName.GetAttribute("value");
                if (token.IsCancellationRequested)
                {
                    var newCancel = smsGen.CancelTheNumber(number.id);
                    browser.Close();
                    browser.Quit();
                    //Status Update
                    writeStatus(winNum, "Canceled");
                    return;

                }
                //Password Automation
                IWebElement Passwrd = browser.FindElement(By.Name("Passwd"));
                Passwrd.Click();

                Passwrd.SendKeys(Convert.ToString(pwd));
                //Status Update
                writeStatus(winNum, "Created Password");

                IWebElement ConPasswrd = browser.FindElement(By.Name("ConfirmPasswd"));
                ConPasswrd.Click();
                ConPasswrd.SendKeys(Convert.ToString(pwd));

                IWebElement NextBtn = browser.FindElement(By.XPath("//div[2]/div/div/div/div/button/span"));
                NextBtn.Click();
                    Thread.Sleep(5000);
                    //sending num to phone box on screen
                    try
                {
                    IWebElement PhoneTextBox = browser.FindElement(By.Id("phoneNumberId"));

                    if (PhoneTextBox.Selected == false)
                    {
                        PhoneTextBox.Click();
                    }
                    PhoneTextBox.SendKeys(number.number);
                    //Status Update
                    writeStatus(winNum, "Sending Number to ChromeDriver");
                }
                catch (ElementNotInteractableException)
                {
                    var phoneNoWork = smsGen.CancelTheNumber(number.id);
                    browser.Close();
                    browser.Quit();
                    //Status Update
                    writeStatus(winNum, "Phone Number Error, Restarting Proccess");
                    break;
                }

                IWebElement endButton = browser.FindElement(By.XPath("//span[contains(.,'Next')]"));
                endButton.Click();
                Thread.Sleep(20000);

                try
                {
                    if (browser.FindElement(By.Id("phoneNumberId")).Displayed == true)
                    {
                        bool banned = false;
                        while (banned == false)
                        {
                            var ban = smsGen.BanNumber(number.id);
                            if (ban.Result.isError == false)
                            {
                                break;
                            }
                        }
                        writeStatus(winNum, "Phone Number Error, Refunding Number");
                        writeStatus(winNum, "Refund Successful, Restarting Proccess");
                        browser.Close();
                        browser.Quit();

                        break;
                    }
                }
                catch
                {
                    //suppose to be clear
                }

                codeRecieved code = new codeRecieved();
                    try
                    {
                        while (code.sms == null)
                {       
                        phonCancel.CancelAfter(90000);
                        code = await getText(number.id);
                        if (stopWatch.ElapsedMilliseconds > 900000)

                        
                    if (token.IsCancellationRequested)
                    {
                        var newCancel = smsGen.CancelTheNumber(number.id);
                        browser.Close();
                        browser.Quit();
                        writeStatus(winNum, "Canceled");
                        return;

                    }
                    writeStatus(winNum, "Retrieving Code");
                  
                    Thread.Sleep(2000);
                }
                    }
                    catch (OperationCanceledException)
                    {
                        var newCancel = smsGen.CancelTheNumber(number.id);
                        browser.Close();
                        browser.Quit();
                        writeStatus(winNum, "Canceled");
                        return;
                    }
                    finally
                    {
                        phonCancel.Dispose();
                    }

                
                writeStatus(winNum, "Code Retrieval Successful");
                Thread.Sleep(7000);
                try
                {
                    Actions browserAction = new Actions(browser);
                    browserAction.SendKeys(code.sms);
                    browserAction.Perform();
                }
                catch
                {
                    IWebElement backUpPhone = browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[2]/div/div[1]/div/div[1]/input"));
                    backUpPhone.Click();
                    backUpPhone.SendKeys(code.sms);
                }



                writeStatus(winNum, "Code Sent to ChromeDriver");



                if (token.IsCancellationRequested)
                {
                    browser.Close();
                    browser.Quit();
                    writeStatus(winNum, "Canceled");
                    return;

                }

                IWebElement AnotherAnotherNextButton = browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div[2]/div/div/div[2]/div/div[2]/div[2]/div[1]/div/div/button"));
                AnotherAnotherNextButton.Click();



                Thread.Sleep(4000);
                IWebElement phoneIdeBox = browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div[2]/div[1]/label/input"));
                phoneIdeBox.Click();
                phoneIdeBox.Clear();

                writeStatus(winNum, "Finalizing");

                IWebElement RecoveryEmail = browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[2]/div[1]/div/div[1]/div/div[1]/input"));
                RecoveryEmail.Click();
                RecoveryEmail.SendKeys(backupEmail);

                SelectElement BirthMonth = new SelectElement(browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[3]/div[1]/div/div/div[2]/select")));

                BirthMonth.SelectByText(randomMonth());


                IWebElement day = browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[3]/div[2]/div/div/div[1]/div/div[1]/input"));
                day.Click();
                Random rand = new Random();
                day.SendKeys(Convert.ToString(rand.Next(1, 26)));

                IWebElement year = browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[3]/div[3]/div/div/div[1]/div/div[1]/input"));
                year.Click();
                year.SendKeys(Convert.ToString(rand.Next(1980, 2002)));

                string GenderFinal;
                int gender = rand.Next(1, 3);
                if (gender == 1)
                {
                    GenderFinal = "Male";
                }
                else
                {
                    GenderFinal = "Female";
                }

                SelectElement GenderBox = new SelectElement(browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[4]/div[1]/div/div[2]/select")));

                GenderBox.SelectByText(GenderFinal);

                IWebElement AnotherNext = browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button"));
                AnotherNext.Click();

                Thread.Sleep(3000);
                IWebElement sendButton = browser.FindElement(By.XPath("//*[@id='view_container']/div/div/div[2]/div/div[2]/div/div[1]/div/div/button"));
                sendButton.Click();

                writeStatus(winNum, "Succesfully Created");
                writeStatus(winNum, "Appending to Table");

                browser.Navigate().GoToUrl("chrome://version/");
                IWebElement foundPath = browser.FindElement(By.XPath("/html/body/div/table/tbody/tr[8]/td[2]"));
                int pathId = GenerateRandomNo();
                    
                    try
                    {
                insertPath(foundPath.Text, pathId);
                    }
                    catch
                    {

                    }
                    browser.Quit();

                    if (noProxy == false)
                {
                    InsertAccount(RealUserName, pwd, backupEmail, false, proxy.id, "Idle", 0, pathId);
                }
                else
                {
                    
                        InsertAccount(RealUserName, pwd, backupEmail, false, 0, "Idle", 0, pathId);
                    
                }
                

                loop++;
                    break;
                }
            }

            
        }
        public string randomMonth()
        {
            Random rnd = new Random();

            int month = rnd.Next(1, 13);
            if (month == 1)
            {
                return "January";
            }
            else if (month == 2)
            {
                return "February";
            }
            else if (month == 3)
            {
                return "March";
            }
            else if (month == 4)
            {
                return "April";
            }
            else if (month == 5)
            {
                return "May";
            }
            else if (month == 6)
            {
                return "June";
            }
            else if (month == 7)
            {
                return "July";
            }
            else if (month == 8)
            {
                return "August";
            }
            else if (month == 9)
            {
                return "September";
            }
            else if (month == 10)
            {
                return "October";
            }
            else if (month == 11)
            {
                return "November";
            }
            else
            {
                return "December";
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            CreateStart(Convert.ToInt32(WindowBox.Value), CountryBox.Text.ToString(), Convert.ToInt32(AmountBox.Value), RecoveryBox.Text, NoProxBox.Checked);
            AbortButt.Location = new Point(692, 562);
            AbortButt.Visible = true;
            CreateBox.Visible = false;
            WindowBox.Value = 0;
            AmountBox.Value = 0;
            CountryBox.Text = "Auto";

        }

        private void AbortButt_Click(object sender, EventArgs e)
        {
            foreach(var c in cancellationTokenSources)
            {
                c.Cancel();
            }

            AbortButt.Visible = false;
        }

        private void CountryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public UserPath GetUserPath(int id)
        {
            SqlConnection con;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory) + "\\Database1.mdf;Integrated Security=True");
            SqlCommand command;
            SqlDataReader Reader;
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }



            string Sql;
            Sql = "SELECT UserPath FROM Account WHERE Id = @id";
            command = new SqlCommand(Sql, con);
            command.Parameters.AddWithValue("@id", id);
            Reader = command.ExecuteReader();


            Account AccountsList = new Account();
            while (Reader.Read())
            {
                AccountsList.UserPath = new UserPath();
                AccountsList.UserPath.Id = Convert.ToInt32(Reader.GetString(0));
               
                

            }
            Reader.Close();
            command.Dispose();
                Reader.Close();

            
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }



            
            Sql = "SELECT Path FROM UserPath WHERE Id = @id";
            command = new SqlCommand(Sql, con);
            command.Parameters.AddWithValue("@id", Convert.ToInt32(AccountsList.UserPath.Id));
            Reader = command.ExecuteReader();


            UserPath path = new UserPath();
            while (Reader.Read())
            {
                path.Path = Reader.GetString(0);

            }
            Reader.Close();
            con.Close();
            return path;
        }

        private void AccountTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value);
                string user = Convert.ToString(senderGrid.Rows[e.RowIndex].Cells[1].Value) + "@gmail.com";
                string pass = Convert.ToString(senderGrid.Rows[e.RowIndex].Cells[2].Value);
                //id = Convert.ToInt32(id);
                UserPath path = GetUserPath(id);
                Task.Run(() => OpenInbox(path.Path, user, pass));

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReUpdateTable();
            activeLabel.Text = AccountTable.Rows.Count.ToString();
            int errors = 0;
            foreach(DataGridViewRow row in AccountTable.Rows)
            {
                if(row.Cells["Status"].Value == "Error")
                {
                    errors++;
                }
            }
            ErrorLabel.Text = errors.ToString();
            int ovc = 0;
            foreach (DataGridViewRow row in AccountTable.Rows)
            {
                if (row.Cells["OneClickVerified"].Value.ToString() == "True")
                {
                    ovc++;
                }
            }
            OVCLabel.Text = ovc.ToString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }
        public void RemoveProxies(int id)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory) + "\\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(ConnectionString);
            SqlCommand command;

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }



            string Sql;
            Sql = "UPDATE Account SET Proxy = @Proxy WHERE Id = @id";
            command = new SqlCommand(Sql, con);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Proxy", "");
        }
    }
}
