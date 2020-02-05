using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mis42p2rd484215.Models
{
    public class Products
    {
        public int productID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<OrderDetail> OrderDetail { get; set; }

        //public int productID { get; set; }

    }
}