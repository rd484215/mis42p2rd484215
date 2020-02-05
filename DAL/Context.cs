using mis42p2rd484215.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mis42p2rd484215.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }


    }
}