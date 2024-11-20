using System;
using System.Collections.Generic;
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
        public DbSet<Classes.Invoice> Invoices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet <UserNote> UserNotes { get; set; }

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
                    Name = "Customer2",
                    Username = "customer2",
                    Password = BCrypt.Net.BCrypt.HashPassword("customer123"),
                    RoleId = 4
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
        }
    }
}
