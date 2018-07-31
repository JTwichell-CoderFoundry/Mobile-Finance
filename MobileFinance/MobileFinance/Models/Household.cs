using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFinance.Models
{
    class Household
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Household()
        {
            Name = "";
            Description = "";
        }
    }    
}
