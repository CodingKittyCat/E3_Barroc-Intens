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
    [Migration("20241202085839_InitialCreate")]
    partial class InitialCreate
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
                            DueDate = new DateTime(2024, 11, 22, 9, 58, 38, 175, DateTimeKind.Local).AddTicks(6),
                            InvoiceDate = new DateTime(2024, 11, 2, 9, 58, 38, 174, DateTimeKind.Local).AddTicks(9948),
                            IsPayed = true,
                            TotalAmount = 1200.5f
                        },
                        new
                        {
                            Id = 2,
                            CustomerName = "Jane Smith",
                            DueDate = new DateTime(2024, 12, 17, 9, 58, 38, 175, DateTimeKind.Local).AddTicks(19),
                            InvoiceDate = new DateTime(2024, 11, 17, 9, 58, 38, 175, DateTimeKind.Local).AddTicks(18),
                            IsPayed = false,
                            TotalAmount = 800.75f
                        },
                        new
                        {
                            Id = 3,
                            CustomerName = "Acme Corp",
                            DueDate = new DateTime(2024, 11, 27, 9, 58, 38, 175, DateTimeKind.Local).AddTicks(41),
                            InvoiceDate = new DateTime(2024, 10, 18, 9, 58, 38, 175, DateTimeKind.Local).AddTicks(21),
                            IsPayed = true,
                            TotalAmount = 2500f
                        },
                        new
                        {
                            Id = 4,
                            CustomerName = "Global Industries",
                            DueDate = new DateTime(2024, 12, 12, 9, 58, 38, 175, DateTimeKind.Local).AddTicks(44),
                            InvoiceDate = new DateTime(2024, 11, 12, 9, 58, 38, 175, DateTimeKind.Local).AddTicks(43),
                            IsPayed = false,
                            TotalAmount = 1500.3f
                        },
                        new
                        {
                            Id = 5,
                            CustomerName = "Tech Solutions",
                            DueDate = new DateTime(2024, 12, 22, 9, 58, 38, 175, DateTimeKind.Local).AddTicks(48),
                            InvoiceDate = new DateTime(2024, 11, 22, 9, 58, 38, 175, DateTimeKind.Local).AddTicks(45),
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
                            Date_Created = new DateTime(2024, 12, 2, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6145),
                            End_Date = new DateTime(2024, 12, 2, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6145),
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
                            Date_Created = new DateTime(2024, 12, 2, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6252),
                            End_Date = new DateTime(2024, 12, 2, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6252),
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
                            Date_Created = new DateTime(2024, 12, 2, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6259),
                            End_Date = new DateTime(2024, 12, 2, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6259),
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
                            Date_Created = new DateTime(2024, 12, 2, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6262),
                            End_Date = new DateTime(2024, 12, 2, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6262),
                            Payment_Status = "Unpaid",
                            Price_Per_Period = 400.0,
                            ProductId = 1,
                            Time_Per_Period = 1,
                            Total_Price = 4000.0,
                            Type_Of_Time = "Monthly",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.MaintenanceRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("PlannedDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestedDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkReceiptId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkReceiptId");

                    b.ToTable("maintenanceRequests");
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This plank is made from wood, I promise, no deceptions here.",
                            Name = "Wooden Plank 50cm"
                        },
                        new
                        {
                            Id = 2,
                            Description = "This plank is made from wood, I promise, deceptions here.",
                            Name = "Wooden Plink 75cm"
                        },
                        new
                        {
                            Id = 3,
                            Description = "This plank is made from iron, I swear, no deceptions here.",
                            Name = "Wooden Plonk 25cm"
                        },
                        new
                        {
                            Id = 4,
                            Description = "This 20cm is made from wood, I promise, deceptions here.",
                            Name = "Wooden Plunk 20cm"
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

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.Product", b =>
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

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("QuoteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .HasColumnType("longtext");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            ExpirationDate = new DateTime(2025, 1, 1, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6336),
                            QuoteDate = new DateTime(2024, 12, 2, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6334),
                            Status = "Pending",
                            TotalAmount = 1000m
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            ExpirationDate = new DateTime(2025, 1, 1, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6372),
                            QuoteDate = new DateTime(2024, 12, 2, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6370),
                            Status = "Pending",
                            TotalAmount = 2000m
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            ExpirationDate = new DateTime(2025, 1, 1, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6387),
                            QuoteDate = new DateTime(2024, 12, 2, 9, 58, 39, 90, DateTimeKind.Local).AddTicks(6380),
                            Status = "Pending",
                            TotalAmount = 3000m
                        });
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.ReceiptMaterial", b =>
                {
                    b.Property<int>("ReceiptId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ReceiptId", "MaterialId");

                    b.HasIndex("MaterialId");

                    b.ToTable("ReceiptMaterials");

                    b.HasData(
                        new
                        {
                            ReceiptId = 1,
                            MaterialId = 1,
                            Quantity = 3
                        },
                        new
                        {
                            ReceiptId = 1,
                            MaterialId = 2,
                            Quantity = 3
                        },
                        new
                        {
                            ReceiptId = 1,
                            MaterialId = 3,
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsFirstLogin")
                        .HasColumnType("tinyint(1)");

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
                            Email = "D295372@edu.curio.nl",
                            IsFirstLogin = true,
                            Name = "Customer User1",
                            Password = "$2a$11$Omx0CBHwLzAOlmJ1i/jZ.OSsARma53s5Kg8u0bB1lnp4D0bGzP/T2",
                            RoleId = 4,
                            Username = "customer1"
                        },
                        new
                        {
                            Id = 2,
                            Email = "customer2@example.com",
                            IsFirstLogin = true,
                            Name = "Customer User2",
                            Password = "$2a$11$HyyjzZy7JfSczBfAvvZhM.2Z4XA6IUF3eSVBbZXJUBx8yi97lCfbC",
                            RoleId = 4,
                            Username = "customer2"
                        },
                        new
                        {
                            Id = 3,
                            Email = "customer3@example.com",
                            IsFirstLogin = true,
                            Name = "Customer User3",
                            Password = "$2a$11$oLLupnLTqX37PpMuNUNjrON2N5yEMi1fzeRRvqOCQBdhpsXqmFHHO",
                            RoleId = 4,
                            Username = "customer3"
                        },
                        new
                        {
                            Id = 4,
                            Email = "finance@example.com",
                            IsFirstLogin = true,
                            Name = "Finance User",
                            Password = "$2a$11$u/yL3XnqCvA0st2XDc0FTeYlFnlWf6PC8GmFbqMJBytWoyMnrAU1O",
                            RoleId = 2,
                            Username = "finance"
                        },
                        new
                        {
                            Id = 5,
                            Email = "sales@example.com",
                            IsFirstLogin = true,
                            Name = "Sales User",
                            Password = "$2a$11$tPo8HtDb36vh/A8S9m4DfOSVm6AUTCv3P/s7tjWcSjxPaPlKnfgqS",
                            RoleId = 3,
                            Username = "sales"
                        },
                        new
                        {
                            Id = 6,
                            Email = "maintenance@example.com",
                            IsFirstLogin = true,
                            Name = "Maintenance User",
                            Password = "$2a$11$U5wZi4HlrGXRbAQMaEti0ODy5z4ImJBEFIqomxTaALUOiqJyu4EHC",
                            RoleId = 1,
                            Username = "maintenance"
                        },
                        new
                        {
                            Id = 7,
                            Email = "georgecassel@example.com",
                            IsFirstLogin = true,
                            Name = "George Cassel",
                            Password = "$2a$11$y6pZALn5g1V7t1j5NBf0SuCEYu8rPmKRhYEoxUvthKR6wB8Pyc6GC",
                            RoleId = 1,
                            Username = "georgecassel"
                        },
                        new
                        {
                            Id = 8,
                            Email = "stanbaker@example.com",
                            IsFirstLogin = true,
                            Name = "Stan Baker",
                            Password = "$2a$11$.4OfgKwqvjbpmAZzDcum2O93FoOZ8aypFvc.uawCV7iRC8uIlxAlm",
                            RoleId = 1,
                            Username = "stanbaker"
                        });
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.UserNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Note")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserNotes");
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.WorkReceipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("WorkReceipts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is most definitely a work receipt"
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

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.LeaseContract", b =>
                {
                    b.HasOne("E3_BarrocIntens.Data.Classes.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E3_BarrocIntens.Data.Classes.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.MaintenanceRequest", b =>
                {
                    b.HasOne("E3_BarrocIntens.Data.Classes.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E3_BarrocIntens.Data.Classes.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("E3_BarrocIntens.Data.Classes.WorkReceipt", "WorkReceipt")
                        .WithMany()
                        .HasForeignKey("WorkReceiptId");

                    b.Navigation("Product");

                    b.Navigation("User");

                    b.Navigation("WorkReceipt");
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.Quote", b =>
                {
                    b.HasOne("E3_BarrocIntens.Data.Classes.User", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.ReceiptMaterial", b =>
                {
                    b.HasOne("E3_BarrocIntens.Data.Classes.Material", "Material")
                        .WithMany("ReceiptMaterials")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E3_BarrocIntens.Data.Classes.WorkReceipt", "WorkReceipt")
                        .WithMany("ReceiptMaterials")
                        .HasForeignKey("ReceiptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("WorkReceipt");
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.User", b =>
                {
                    b.HasOne("E3_BarrocIntens.Data.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.UserNote", b =>
                {
                    b.HasOne("E3_BarrocIntens.Data.Classes.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.Material", b =>
                {
                    b.Navigation("ReceiptMaterials");
                });

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.WorkReceipt", b =>
                {
                    b.Navigation("ReceiptMaterials");
                });
#pragma warning restore 612, 618
        }
    }
}