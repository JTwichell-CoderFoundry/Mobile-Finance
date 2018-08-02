using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFinance.Models
{
    class Account
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public decimal StartingBalance { get; set; }
        public decimal CurrentBalance { get; set; }

        public Account()
        {
            Name = "";
            Description = "";
            Created = new DateTime(1970,1,1,0,0,0,0);
            Updated = null;
            StartingBalance = 0.00m;
            CurrentBalance = 0.00m;
        }
    }
}
