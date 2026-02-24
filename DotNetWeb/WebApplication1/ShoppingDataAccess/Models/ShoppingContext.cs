using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDataAccess.Models
{
    public class ShoppingContext : DbContext
    {
        public DbSet<ShoppingOccasion> ShoppingOccasions { get; set; }
        public DbSet<ShoppingPlace> ShoppingPlaces { get; set; }
        public DbSet<ShoppingItem> ShoppingItems { get; set; }

        public ShoppingContext() : base("name=MySqlServerConnString")
        {
            Database.SetInitializer<ShoppingContext>(new ShoppingInitalizer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoppingOccasion>().ToTable("ShoppingOccasion");
            modelBuilder.Entity<ShoppingOccasion>().HasKey(x => x.ShoppingOccasionId);
            modelBuilder.Entity<ShoppingOccasion>().Property(x => x.Description).HasMaxLength(50);

            modelBuilder.Entity<ShoppingPlace>().ToTable("ShoppingPlace");
            modelBuilder.Entity<ShoppingPlace>().HasKey(x => x.ShoppingPlaceId);
            modelBuilder.Entity<ShoppingPlace>().Property(x => x.Address).HasMaxLength(200);
            modelBuilder.Entity<ShoppingPlace>().Property(x => x.Name).HasMaxLength(50);

            modelBuilder.Entity<ShoppingItem>().ToTable("ShoppingItem");
            modelBuilder.Entity<ShoppingItem>().HasKey(x => x.ShoppingItemId);
            modelBuilder.Entity<ShoppingItem>().Property(x => x.Name).HasMaxLength(50);
            modelBuilder.Entity<ShoppingItem>().Property(x => x.UnitOfMeasure).HasMaxLength(20);

            base.OnModelCreating(modelBuilder);
        }
    }
}
