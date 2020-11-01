﻿// <auto-generated />
using CodeFirstPractice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstPractice.Migrations
{
    [DbContext(typeof(ShelfContext))]
    [Migration("20201101174325_AddsShelfMaterials")]
    partial class AddsShelfMaterials
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirstPractice.Models.Shelf", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<int>("ShelfMaterialID")
                        .HasColumnType("int(10)");

                    b.HasKey("ID");

                    b.HasIndex("ShelfMaterialID")
                        .HasName("FK_Shelf_Material_Shelf");

                    b.ToTable("shelf");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            Name = "Dairy",
                            ShelfMaterialID = -1
                        },
                        new
                        {
                            ID = -2,
                            Name = "Vegetables",
                            ShelfMaterialID = -1
                        },
                        new
                        {
                            ID = -3,
                            Name = "Candy",
                            ShelfMaterialID = -1
                        },
                        new
                        {
                            ID = -4,
                            Name = "Medicine",
                            ShelfMaterialID = -1
                        },
                        new
                        {
                            ID = -5,
                            Name = "Baked goods",
                            ShelfMaterialID = -1
                        });
                });

            modelBuilder.Entity("CodeFirstPractice.Models.Shelf_Material", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("MaterialName")
                        .HasColumnType("varchar(25)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("ID");

                    b.ToTable("shelf_material");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            MaterialName = "Milk"
                        },
                        new
                        {
                            ID = -2,
                            MaterialName = "Chocolate"
                        },
                        new
                        {
                            ID = -3,
                            MaterialName = "yogurt"
                        });
                });

            modelBuilder.Entity("CodeFirstPractice.Models.Shelf", b =>
                {
                    b.HasOne("CodeFirstPractice.Models.Shelf_Material", "ShelfMaterial")
                        .WithMany("Shelves")
                        .HasForeignKey("ShelfMaterialID")
                        .HasConstraintName("FK_Shelf_Material_Shelf")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
