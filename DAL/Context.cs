using mis42p2rd484215.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mis42p2rd484215.DAL
{
    public class Context : DbContext
    {
        public Context() : base("name=DefaultConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, mis42p2rd484215.Migrations.MISContext.Configuration>("DefaultConnection"));

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }


    }
}