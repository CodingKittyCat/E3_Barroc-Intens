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
#pragma warning restore 612, 618
        }
    }
}
