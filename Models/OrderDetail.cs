using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mis42p2rd484215.Models
{
    public class OrderDetail
    {

        public int orderdetailId { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int orderId { get; set; }
        public virtual Orders Order { get; set; }
        // the next two properties link the orderDetail to the Product
        public int productId { get; set; }
        public virtual Products Product { get; set; }
    }
}