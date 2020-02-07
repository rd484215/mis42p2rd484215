using mis42p2rd484215.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mis42p2rd484215.DAL
{
    public class SD2Context : DbContext
    {
        public SD2Context() : base("name=DefaultConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, mis42p2rd484215.Migrations.MISContext.Configuration>("DefaultConnection"));

        }

        public DbSet<Pets> Pets { get; set; }
        public DbSet<Vet> Vet { get; set; }

    }
}