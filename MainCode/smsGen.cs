using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft;
using System.Data;
using System.Data.SqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using SeleniumExtras.WaitHelpers;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;

namespace GmailFarmV2
{
    public class smsGen
    {

        public class balanceApi
        {
            public double balance { get; set; }
            
            public bool isError { get; set; }

        }
        public class numberLayout
        {
            public string id { get; set; }
            public string number { get; set; }
            public string date { get; set; }
            public string status { get; set; }
            public string error { get; set; }
            public bool isError { get; set; }

        }

        public class codeRecieved
        {
            public bool retry { get; set; }
            public string sms { get; set; }
            public string error { get; set; }
            public bool isError { get; set; }   
        }

        
        
        public static async Task<balanceApi> CheckBalance()
        {

            string url = "https://public.sms-gen.com/v1/sms/balance?apikey=" + Properties.Settings.Default.SavedAPIKey;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    balanceApi newBalance = await response.Content.ReadAsAsync<balanceApi>();
                    return newBalance;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

          
        }

        public static async Task<codeRecieved> getText(string id)
        {
            string url = "https://public.sms-gen.com/v1/sms/code?id=" + id + "&apikey=" + Properties.Settings.Default.SavedAPIKey;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    codeRecieved newCode = await response.Content.ReadAsAsync<codeRecieved>();
                    return newCode;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }

        // 

        public static async Task<numberLayout> GetNumber(string country)
        {
            string url = "https://public.sms-gen.com/v1/sms/number?country=" + country + "&service=google&channel=2&apikey=" + Properties.Settings.Default.SavedAPIKey + "&ref=9557381";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    numberLayout num = await response.Content.ReadAsAsync<numberLayout>();
                    return num;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }










        }

        public class BanNum
        {
            public string error { get; set; }
            public bool isError { get; set; }
        }
        public static async Task<BanNum> BanNumber(string id)
        {
            string url = "https://public.sms-gen.com/v1/sms/bannumber?id=" + id +"&apikey=" + Properties.Settings.Default.SavedAPIKey;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    BanNum num = await response.Content.ReadAsAsync<BanNum>();
                    return num;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
        public static async Task<cancelNumber> CancelTheNumber(string id)
        {
            string url = "https://public.sms-gen.com/v1/sms/cancelnumber?id=" + id + "&apikey=" + Properties.Settings.Default.SavedAPIKey;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    cancelNumber num = await response.Content.ReadAsAsync<cancelNumber>();
                    return num;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public class Balance
        {
            public double balance { get; set; }
        }

        public class cancelNumber
        {
            public string error { get; set; }
            public bool isError { get; set; }

        }
        //Storage for stuff i can't use:



        //IWebElement LoginButon = browser.FindElement(By.Name("Login"));
        //LoginButon.Click();
        //need to make capatcha solver
        //IWebElement Ifram = browser.FindElement(By.TagName("reCAPTCHA"));
        // browser.SwitchTo().Frame(2);
        // IWebElement Cap = browser.FindElement(By.XPath("xpath=//span/div"));
        //Cap.Click();
        //new WebDriverWait(browser, TimeSpan.FromSeconds(3)).Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.XPath("//iframe[@title='reCAPTCHA']")));
        // var check = browser.FindElement(By.Id("recaptcha-anchor"));
        //check.Click();
        // public string ReadEmail(string User, string Password, string Domain)
        // {
        //     string CODE = "";
        //    ExchangeService exchange = new ExchangeService(ExchangeVersion.Exchange2007_SP1);
        //   exchange.Credentials = new WebCredentials(User, Password, Domain);
        //   exchange.AutodiscoverUrl(User);

        //    if(exchange != null)
        //     {
        //        FindItemsResults<Item> result = exchange.FindItems(WellKnownFolderName.Inbox, new ItemView(1));

        //        foreach(Item item in result)
        //        {
        //            EmailMessage message = EmailMessage.Bind(exchange, item.Id);

        //           String body = message.Body.Text;
        //            String from = message.From.Id.ToString();

        //            CODE = body;
        //CODE = CODE.Substring(CODE.Length - 6);
        //        }
        //    }

        //      return CODE;
        //   }

        //I dont think 
    }

}
