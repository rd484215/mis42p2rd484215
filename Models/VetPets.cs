using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mis42p2rd484215.Models
{
    public class VetPets
    {
        public int vetPetsID { get; set; }
        public DateTime appointmentDate { get; set; }
        public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int petsID { get; set; }
        public virtual Pets Pet { get; set; }
        // the next two properties link the orderDetail to the Product
        public int vetID { get; set; }
        public virtual Vet Vet { get; set; }


    }
}