using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Project3.Models
{
    public class Project3Context : DbContext
    {
        public Project3Context() : base("Project3") { }
        public DbSet<Tram> Tram { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Metro> Metro { get; set; }
        public DbSet<Parking> Parking { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}