using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailFarmV2.Models
{
   
        public class ActiveKey
        {
            [Key] public int Id { get; set; }
            public string key { get; set; }
            public string keyPass { get; set; }
            public string IP { get; set; }
            [DataType(DataType.Date)]
            public DateTime dateCreated { get; set; }
            public DateTime ExpireDate { get; set; }
            public string assignedUser { get; set; }

            public ActiveKey()
            {
                return;
            }





        
    }
}
