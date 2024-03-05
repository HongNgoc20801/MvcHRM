using System;
using System.Data.Entity;

namespace QLNS1.Models
{
    public partial class QLNSdatabase : DbContext
    {
        public QLNSdatabase()
            : base("name=QLNSModel")
        {
        }

        public DbSet<RegionModel> Regions { get; set; } // Use RegionModel class instead of QLNSModel
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<NationModel> Nations { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegionModel>().HasKey(e => e.RegionID); // Define the primary key using Fluent API
            modelBuilder.Entity<DepartmentModel>().HasKey(e => e.DepartmentID); // Define the primary key for DepartmentModel
            modelBuilder.Entity<NationModel>().HasKey(e => e.NationID);

        }
    }
}
