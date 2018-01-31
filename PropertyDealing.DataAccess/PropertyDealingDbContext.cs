using Microsoft.AspNet.Identity.EntityFramework;
using PropertyDealing.DataAccess.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDealing.DataAccess
{
    public class PropertyDealingDbContext : IdentityDbContext<User>
    {
        public PropertyDealingDbContext() : base("name=connection")
        {

        }

        public static PropertyDealingDbContext Create()
        {
            return new PropertyDealingDbContext();
        }

        //public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(e => e.IdUser)
                .ToTable("User");

            modelBuilder.Entity<Property>()
                .HasKey(e => e.Id)
                .ToTable("Property");
        }
    }
}
