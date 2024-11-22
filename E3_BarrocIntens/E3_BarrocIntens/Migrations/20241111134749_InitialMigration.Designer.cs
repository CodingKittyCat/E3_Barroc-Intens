﻿// <auto-generated />
using System;
using E3_BarrocIntens.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241111134749_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsPayed")
                        .HasColumnType("tinyint(1)");

                    b.Property<float>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Invoices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerName = "John Doe",
                            DueDate = new DateTime(2024, 11, 1, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1399),
                            InvoiceDate = new DateTime(2024, 10, 12, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1313),
                            IsPayed = true,
                            TotalAmount = 1200.5f
                        },
                        new
                        {
                            Id = 2,
                            CustomerName = "Jane Smith",
                            DueDate = new DateTime(2024, 11, 26, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1428),
                            InvoiceDate = new DateTime(2024, 10, 27, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1426),
                            IsPayed = false,
                            TotalAmount = 800.75f
                        },
                        new
                        {
                            Id = 3,
                            CustomerName = "Acme Corp",
                            DueDate = new DateTime(2024, 11, 6, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1443),
                            InvoiceDate = new DateTime(2024, 9, 27, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1441),
                            IsPayed = true,
                            TotalAmount = 2500f
                        },
                        new
                        {
                            Id = 4,
                            CustomerName = "Global Industries",
                            DueDate = new DateTime(2024, 11, 21, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1453),
                            InvoiceDate = new DateTime(2024, 10, 22, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1451),
                            IsPayed = false,
                            TotalAmount = 1500.3f
                        },
                        new
                        {
                            Id = 5,
                            CustomerName = "Tech Solutions",
                            DueDate = new DateTime(2024, 12, 1, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1458),
                            InvoiceDate = new DateTime(2024, 11, 1, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1456),
                            IsPayed = false,
                            TotalAmount = 950.6f
                        });
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.LeaseContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount_Of_Periods")
                        .HasColumnType("int");

                    b.Property<bool>("Bkr_Check")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Date_Created")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("End_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Payment_Status")
                        .HasColumnType("longtext");

                    b.Property<double>("Price_Per_Period")
                        .HasColumnType("double");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Time_Per_Period")
                        .HasColumnType("int");

                    b.Property<double>("Total_Price")
                        .HasColumnType("double");

                    b.Property<string>("Type_Of_Time")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("LeaseContracts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount_Of_Periods = 1,
                            Bkr_Check = false,
                            Date_Created = new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6495),
                            End_Date = new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6495),
                            Payment_Status = "Unpaid",
                            Price_Per_Period = 100.0,
                            ProductId = 1,
                            Time_Per_Period = 1,
                            Total_Price = 1000.0,
                            Type_Of_Time = "Monthly",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount_Of_Periods = 1,
                            Bkr_Check = false,
                            Date_Created = new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6595),
                            End_Date = new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6595),
                            Payment_Status = "Unpaid",
                            Price_Per_Period = 200.0,
                            ProductId = 1,
                            Time_Per_Period = 1,
                            Total_Price = 2000.0,
                            Type_Of_Time = "Monthly",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Amount_Of_Periods = 1,
                            Bkr_Check = false,
                            Date_Created = new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6601),
                            End_Date = new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6601),
                            Payment_Status = "Unpaid",
                            Price_Per_Period = 300.0,
                            ProductId = 1,
                            Time_Per_Period = 1,
                            Total_Price = 3000.0,
                            Type_Of_Time = "Monthly",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Amount_Of_Periods = 1,
                            Bkr_Check = false,
                            Date_Created = new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6606),
                            End_Date = new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6606),
                            Payment_Status = "Unpaid",
                            Price_Per_Period = 400.0,
                            ProductId = 1,
                            Time_Per_Period = 1,
                            Total_Price = 4000.0,
                            Type_Of_Time = "Monthly",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDelivered")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 1,
                            Description = "Delivery to Cafe Aroma",
                            IsDelivered = false,
                            Name = "La Marzocco Linea Mini",
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Amount = 3,
                            Description = "Delivery of 3 units to Office Central",
                            IsDelivered = false,
                            Name = "Breville Barista Pro",
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            Amount = 1,
                            Description = "Delivery to Small Bean Coffee Shop",
                            IsDelivered = false,
                            Name = "Keurig K-Elite Brewer",
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            Amount = 2,
                            Description = "Two units for University Campus Cafe",
                            IsDelivered = false,
                            Name = "De'Longhi La Specialista",
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            Amount = 10,
                            Description = "Bulk order of 10 units for Hotel Deluxe",
                            IsDelivered = false,
                            Name = "Jura E8 Automatic Coffee Machine",
                            Status = 0
                        },
                        new
                        {
                            Id = 6,
                            Amount = 1,
                            Description = "Shipped to Coffee House",
                            IsDelivered = false,
                            Name = "La Marzocco GS3",
                            Status = 1
                        },
                        new
                        {
                            Id = 7,
                            Amount = 1,
                            Description = "Shipped to Gourmet Coffee Roasters",
                            IsDelivered = false,
                            Name = "Gaggia Classic Pro",
                            Status = 1
                        },
                        new
                        {
                            Id = 8,
                            Amount = 1,
                            Description = "Shipped to Riverside Cafe",
                            IsDelivered = false,
                            Name = "Nespresso VertuoPlus Deluxe",
                            Status = 1
                        },
                        new
                        {
                            Id = 9,
                            Amount = 2,
                            Description = "Shipped to Downtown Coffee Hub",
                            IsDelivered = false,
                            Name = "Philips 3200 Series",
                            Status = 1
                        },
                        new
                        {
                            Id = 10,
                            Amount = 4,
                            Description = "Shipped to Green Leaf Hotel",
                            IsDelivered = false,
                            Name = "Miele CM5310 Silence",
                            Status = 1
                        },
                        new
                        {
                            Id = 11,
                            Amount = 2,
                            Description = "Delivered to The Daily Grind",
                            IsDelivered = true,
                            Name = "Breville Bambino Plus",
                            Status = 2
                        },
                        new
                        {
                            Id = 12,
                            Amount = 1,
                            Description = "Delivered to Tech Corp Office",
                            IsDelivered = true,
                            Name = "Saeco Xelsis",
                            Status = 2
                        },
                        new
                        {
                            Id = 13,
                            Amount = 3,
                            Description = "Delivered to The Roastery",
                            IsDelivered = true,
                            Name = "Rancilio Silvia",
                            Status = 2
                        },
                        new
                        {
                            Id = 14,
                            Amount = 2,
                            Description = "Delivered to Cozy Corner Cafe",
                            IsDelivered = true,
                            Name = "De'Longhi Dinamica Plus",
                            Status = 2
                        },
                        new
                        {
                            Id = 15,
                            Amount = 1,
                            Description = "Delivered to Bella's Bistro",
                            IsDelivered = true,
                            Name = "Rocket Appartamento",
                            Status = 2
                        },
                        new
                        {
                            Id = 16,
                            Amount = 1,
                            Description = "Order canceled for The Brew House",
                            IsDelivered = false,
                            Name = "Ascaso Dream PID",
                            Status = 3
                        },
                        new
                        {
                            Id = 17,
                            Amount = 1,
                            Description = "Order canceled for Java Junction",
                            IsDelivered = false,
                            Name = "Nuova Simonelli Oscar II",
                            Status = 3
                        },
                        new
                        {
                            Id = 18,
                            Amount = 2,
                            Description = "Order canceled for Bites & Brews",
                            IsDelivered = false,
                            Name = "Smeg ECF01",
                            Status = 3
                        },
                        new
                        {
                            Id = 19,
                            Amount = 1,
                            Description = "Order canceled for Sunset Cafe",
                            IsDelivered = false,
                            Name = "Breville Oracle Touch",
                            Status = 3
                        },
                        new
                        {
                            Id = 20,
                            Amount = 1,
                            Description = "Order canceled for The Coffee Spot",
                            IsDelivered = false,
                            Name = "De'Longhi Magnifica S",
                            Status = 3
                        });
                });

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
                            RoleName = "Customer"
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
                            Password = "$2a$11$N2yBIyO9xot.sR6GzuSpwulvYANUGZdd.IIxY4.mzNUwVsItgYUpe",
                            RoleId = 4,
                            Username = "customer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Finance User",
                            Password = "$2a$11$7BkYyT9zTpNQLKAXBpVQcuytFqksMdjEYYjUF7ouPHxnXFRp5edL2",
                            RoleId = 2,
                            Username = "finance"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sales User",
                            Password = "$2a$11$De8nOWc9d/m/gTt6Js03Juz.BlzhYdqeIwm5YLoM7k4Tkvhi7.Ox2",
                            RoleId = 3,
                            Username = "sales"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Maintenance User",
                            Password = "$2a$11$p3BpXjddK/oIErrOsCQc3OXZHuve5pll9uwmLe5.f9lTVJ3Va6DF6",
                            RoleId = 1,
                            Username = "maintenance"
                        });
                });

            modelBuilder.Entity("E3_BarrocIntens.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .HasColumnType("longtext");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description 1",
                            Status = "Delivered",
                            Stock = 10,
                            Title = "Product 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description 2",
                            Status = "On The Way",
                            Stock = 20,
                            Title = "Product 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description 3",
                            Status = "Pending",
                            Stock = 30,
                            Title = "Product 3"
                        });
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.LeaseContract", b =>
                {
                    b.HasOne("E3_BarrocIntens.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E3_BarrocIntens.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
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
