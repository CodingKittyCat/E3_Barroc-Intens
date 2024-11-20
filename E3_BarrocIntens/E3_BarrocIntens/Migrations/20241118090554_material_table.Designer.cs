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
    [Migration("20241118090554_material_table")]
    partial class material_table
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
                            DueDate = new DateTime(2024, 11, 8, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7044),
                            InvoiceDate = new DateTime(2024, 10, 19, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(6972),
                            IsPayed = true,
                            TotalAmount = 1200.5f
                        },
                        new
                        {
                            Id = 2,
                            CustomerName = "Jane Smith",
                            DueDate = new DateTime(2024, 12, 3, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7067),
                            InvoiceDate = new DateTime(2024, 11, 3, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7065),
                            IsPayed = false,
                            TotalAmount = 800.75f
                        },
                        new
                        {
                            Id = 3,
                            CustomerName = "Acme Corp",
                            DueDate = new DateTime(2024, 11, 13, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7075),
                            InvoiceDate = new DateTime(2024, 10, 4, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7074),
                            IsPayed = true,
                            TotalAmount = 2500f
                        },
                        new
                        {
                            Id = 4,
                            CustomerName = "Global Industries",
                            DueDate = new DateTime(2024, 11, 28, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7083),
                            InvoiceDate = new DateTime(2024, 10, 29, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7082),
                            IsPayed = false,
                            TotalAmount = 1500.3f
                        },
                        new
                        {
                            Id = 5,
                            CustomerName = "Tech Solutions",
                            DueDate = new DateTime(2024, 12, 8, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7086),
                            InvoiceDate = new DateTime(2024, 11, 8, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7085),
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
                            Date_Created = new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(982),
                            End_Date = new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(982),
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
                            Date_Created = new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(1105),
                            End_Date = new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(1105),
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
                            Date_Created = new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(1109),
                            End_Date = new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(1109),
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
                            Date_Created = new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(1113),
                            End_Date = new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(1113),
                            Payment_Status = "Unpaid",
                            Price_Per_Period = 400.0,
                            ProductId = 1,
                            Time_Per_Period = 1,
                            Total_Price = 4000.0,
                            Type_Of_Time = "Monthly",
                            UserId = 4
                        });
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

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.Role", b =>
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

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.User", b =>
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
                            Password = "$2a$11$gB/W4hyd.wPD2s77gFefbuobd5lrLxqyar5o60pNHTcP2opAt7fYq",
                            RoleId = 4,
                            Username = "customer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Finance User",
                            Password = "$2a$11$GvAoeuyBpSLZEb9dvLrrWOCNh1h6q.I1u.pjt3W5qzMPT66e55ucK",
                            RoleId = 2,
                            Username = "finance"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sales User",
                            Password = "$2a$11$N9YWJzfyy8MFe6LUpfmW.eIT43gRMbHr5dfLFt0e3ZVin7iC7XdHu",
                            RoleId = 3,
                            Username = "sales"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Maintenance User",
                            Password = "$2a$11$Rutpw7yKt9gLXBCmtvpZUezB1HEw0tvP5adG8G7FeNpF00x2RfJr6",
                            RoleId = 1,
                            Username = "maintenance"
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

            modelBuilder.Entity("E3_BarrocIntens.Data.Classes.User", b =>
                {
                    b.HasOne("E3_BarrocIntens.Data.Classes.Role", "Role")
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
