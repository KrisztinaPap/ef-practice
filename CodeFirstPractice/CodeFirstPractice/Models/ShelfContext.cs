using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstPractice.Models
{
    public class ShelfContext : DbContext
    {
        public virtual DbSet<Shelf> Shelves { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connection =
                    "server=localhost;" +
                    "port=3306;" +
                    "user=root;" +
                    "database=codefirst_practice;";

                string version = "10.4.14-MariaDB";

                optionsBuilder.UseMySql(connection, x => x.ServerVersion(version));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shelf>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasData(
                    new Shelf()
                    {
                        ID = -1,
                        Name = "Dairy"
                    },
                    new Shelf()
                    {
                        ID = -2,
                        Name = "Vegetables"
                    },
                    new Shelf()
                    {
                        ID = -3,
                        Name = "Candy"
                    },
                    new Shelf()
                    {
                        ID = -4,
                        Name = "Medicine"
                    },
                    new Shelf()
                    {
                        ID = -5,
                        Name = "Baked goods"
                    }
                );
            });
        }
    }
}