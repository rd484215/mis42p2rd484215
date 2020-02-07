using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mis42p2rd484215.Models
{
    public class Pets
    {
        public int petsID { get; set; }

        public string petName { get; set; }
        public string petType { get; set; }
        public string ownerLastName { get; set; }
        public string ownerFirstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime patientSince { get; set; }

        public ICollection<Vet> Vet { get; set; }


    }
}