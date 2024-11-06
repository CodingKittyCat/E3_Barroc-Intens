﻿// <auto-generated />
using E3_BarrocIntens.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("E3_BarrocIntens.Data.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleName = "Maintenance"
                        },
                        new
                        {
                            Id = 2,
                            RoleName = "Finance"
                        },
                        new
                        {
                            Id = 3,
                            RoleName = "Sales"
                        },
                        new
                        {
                            Id = 4,
                            RoleName = "Customers"
                        });
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Customer User",
                            Password = "$2a$11$rd9x5Ac0kUFdOKvuh4.ejuJg297.ReVKgqT2TpgRZ01ADA/w2O1Wy",
                            RoleId = 4,
                            Username = "customer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Finance User",
                            Password = "$2a$11$iBHJpoNWKELwgb5sQZffSuiLvX6/KxBbnL7G7cFDqcv5LNWrFGjE.",
                            RoleId = 2,
                            Username = "finance"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sales User",
                            Password = "$2a$11$Wxz5fVfi6cfzXo2cfWrGf.Ypu.9zMa.U7WPeXTIZDxav20cNIsmHm",
                            RoleId = 3,
                            Username = "sales"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Maintenance User",
                            Password = "$2a$11$kVGJSsjeNLnDZO1B30N37.prJg/4jErd7pUk8dhog5wqr3wo8a/uW",
                            RoleId = 1,
                            Username = "maintenance"
                        });
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.User", b =>
                {
                    b.HasOne("E3_BarrocIntens.Data.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}