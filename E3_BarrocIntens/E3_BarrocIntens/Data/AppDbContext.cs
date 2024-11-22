using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3_BarrocIntens.Data.Classes;
using E3_BarrocIntens.Data.Lists;
using E3_BarrocIntens.Model;
using Microsoft.EntityFrameworkCore;

namespace E3_BarrocIntens.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet <UserNote> UserNotes { get; set; }
        public DbSet<MaintenanceRequest> maintenanceRequests { get; set; }
        public DbSet<LeaseContract> LeaseContracts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;" +
                "port=3306;" +
                "user=root;" +
                "password=;" +
                "database=csd_BarrocIntens",
                ServerVersion.Parse("10.4.17-mariadb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            InvoiceList InvoiceList = new InvoiceList();

            List<Classes.Invoice> invoices = InvoiceList.GetInvoices();
            modelBuilder.Entity<Classes.Invoice>().HasData(invoices.ToArray());

            OrderList orderList = new OrderList();

            List<Order> orders = orderList.GetOrders();
            
            modelBuilder.Entity<Order>().HasData(orders.ToArray());

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, RoleName = "Maintenance" },
                new Role { Id = 2, RoleName = "Finance" },
                new Role { Id = 3, RoleName = "Sales" },
                new Role { Id = 4, RoleName = "Customer"}
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Customer User",
                    Username = "customer",
                    Password = BCrypt.Net.BCrypt.HashPassword("customer123"),
                    RoleId = 4
                },
                new User
                {
                    Id = 2,
                    Name = "Finance User",
                    Username = "finance",
                    Password = BCrypt.Net.BCrypt.HashPassword("finance123"),
                    RoleId = 2
                },
                new User
                {
                    Id = 3,
                    Name = "Sales User",
                    Username = "sales",
                    Password = BCrypt.Net.BCrypt.HashPassword("sales123"),
                    RoleId = 3 
                },
                new User
                {
                    Id = 4,
                    Name = "Maintenance User",
                    Username = "maintenance",
                    Password = BCrypt.Net.BCrypt.HashPassword("maintenance123"),
                    RoleId = 1
                },
                new User
                {
                    Id = 5,
                    Name = "George Cassel",
                    Username = "maintenance",
                    Password = BCrypt.Net.BCrypt.HashPassword("maintenance1234"),
                    RoleId = 1
                },
                new User
                {
                    Id = 6,
                    Name = "Stan Baker",
                    Username = "maintenance",
                    Password = BCrypt.Net.BCrypt.HashPassword("maintenance12345"),
                    RoleId = 1
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Product 1",
                    Description = "Description 1",
                    Stock = 10,
                    Status = "Delivered"
                },
                new Product
                {
                    Id = 2,
                    Title = "Product 2",
                    Description = "Description 2",
                    Stock = 20,
                    Status = "On The Way"
                },
                new Product
                {
                    Id = 3,
                    Title = "Product 3",
                    Description = "Description 3",
                    Stock = 30,
                    Status = "Pending"
                }
            );

            modelBuilder.Entity<LeaseContract>().HasData(
                new LeaseContract
                {
                    Id = 1,
                    Type_Of_Time = "Monthly",
                    Time_Per_Period = 1,
                    Total_Price = 1000,
                    Price_Per_Period = 100,
                    ProductId = 1,
                    UserId = 1,
                    Bkr_Check = false,
                    Amount_Of_Periods = 1,
                },
                new LeaseContract
                {
                    Id = 2,
                    Type_Of_Time = "Monthly",
                    Time_Per_Period = 1,
                    Total_Price = 2000,
                    Price_Per_Period = 200,
                    ProductId = 1,
                    UserId = 2,
                    Bkr_Check = false,
                    Amount_Of_Periods = 1,
                },
                new LeaseContract
                {
                    Id = 3,
                    Type_Of_Time = "Monthly",
                    Time_Per_Period = 1,
                    Total_Price = 3000,
                    Price_Per_Period = 300,
                    ProductId = 1,
                    UserId = 3,
                    Bkr_Check = false,
                    Amount_Of_Periods = 1,
                },
                new LeaseContract
                {
                    Id = 4,
                    Type_Of_Time = "Monthly",
                    Time_Per_Period = 1,
                    Total_Price = 4000,
                    Price_Per_Period = 400,
                    ProductId = 1,
                    UserId = 4,
                    Bkr_Check = false,
                    Amount_Of_Periods = 1,
                }
            );

        }
    }
}
