using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mis42p2rd484215.Models
{
    public class Vet
    {

        [key]
        public int vetID { get; set; }
        public string vetLastName { get; set; }
        public string vetFirstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public int petID { get; set; }
        public virtual Pets Pets { get; set; }
    }
}