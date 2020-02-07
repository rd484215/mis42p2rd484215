using mis42p2rd484215.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace mis42p2rd484215.DAL
{
    public class SD2Context : DbContext
    {
        public SD2Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SD2Context, mis42p2rd484215.Migrations.MISContext.Configuration>("DefaultConnection"));

        }

        public DbSet<Petts> Petts { get; set; }
        public DbSet<Vett> Vett { get; set; }
        //public DbSet<Appointment> Appointment { get; set; }

        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<mis42p2rd484215.Models.Appointment> Appointments { get; set; }
    }
}