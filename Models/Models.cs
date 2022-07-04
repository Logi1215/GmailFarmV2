using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailFarmV2.Models
{
    public class Models
    {
        public class Account
        {
            public int Id { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string BackUpEmail { get; set; }
            public bool OneClickVerified { get; set; }
            public Proxy Proxy { get; set; }
            public decimal score { get; set; }
            public string status { get; set; }
            public UserPath UserPath { get; set; }


        }
        public class UserPath
        {
            public int Id { get; set; }
            public string Path { get; set; }

        }
        public class Proxy
        {
            public bool Valid { get; set; }
            public int Port { get; set; }
            public string IP { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string Type { get; set; }
            public int id { get; set; }
            public int TimesUsed { get; set; }
        }
    }
}
