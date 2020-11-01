using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstPractice.Models
{
    public class ShelfContext : DbContext
    {
        public virtual DbSet<Shelf> Shelves { get; set; }
        public virtual DbSet<Shelf_Material> Shelf_Material { get; set; }

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
                
                string keyName = "FK_" + nameof(Models.Shelf_Material) +
                                 "_" + nameof(Shelf);
                
                entity.Property(e => e.Name)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
                
                entity.Property(e => e.ID);
                
                entity.HasIndex(e => e.ShelfMaterialID)
                    .HasName(keyName);
                
                entity.HasOne(thisEntity => thisEntity.ShelfMaterial)
                    .WithMany(parent => parent.Shelves)
                    .HasForeignKey(thisEntity => thisEntity.ShelfMaterialID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName(keyName);

                entity.HasData(
                    new Shelf()
                    {
                        ID = -1,
                        Name = "Dairy",
                        ShelfMaterialID = -1
                    },
                    new Shelf()
                    {
                        ID = -2,
                        Name = "Vegetables",
                        ShelfMaterialID = -2
                    },
                    new Shelf()
                    {
                        ID = -3,
                        Name = "Candy",
                        ShelfMaterialID = -3
                    },
                    new Shelf()
                    {
                        ID = -4,
                        Name = "Medicine",
                        ShelfMaterialID = -4
                    },
                    new Shelf()
                    {
                        ID = -5,
                        Name = "Toys",
                        ShelfMaterialID = -4
                    },
                    new Shelf()
                    {
                        ID = -6,
                        Name = "Pet food",
                        ShelfMaterialID = -1
                    },
                    new Shelf()
                    {
                        ID = -7,
                        Name = "Ornaments",
                        ShelfMaterialID = -3
                    },
                    new Shelf()
                    {
                        ID = -8,
                        Name = "Tools",
                        ShelfMaterialID = -1
                    },
                    new Shelf()
                    {
                        ID = -9,
                        Name = "Cleaning supplies",
                        ShelfMaterialID = -3
                    },
                    new Shelf()
                    {
                        ID = -10,
                        Name = "Clothing",
                        ShelfMaterialID = -2
                    },
                    new Shelf()
                    {
                        ID = -11,
                        Name = "Baked goods",
                        ShelfMaterialID = -1
                    }
                );
               
            });
            modelBuilder.Entity<Shelf_Material>(entity =>
            {
                entity.Property(e => e.MaterialName)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
                
                entity.Property(e => e.ID);
                    
                entity.HasData(
                    new Shelf_Material()
                    {
                        ID = -1,
                        MaterialName = "oak"
                    },
                    new Shelf_Material()
                    {
                        ID = -2,
                        MaterialName = "spruce"
                    },
                    new Shelf_Material()
                    {
                        ID = -3,
                        MaterialName = "birch"
                    },
                    new Shelf_Material()
                    {
                        ID = -4,
                        MaterialName = "acacia"
                    }
                );
            });
        }
    }
}