using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3_BarrocIntens.Data.Classes;
using E3_BarrocIntens.Data.Lists;
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
        public DbSet<WorkReceipt> WorkReceipts { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<ReceiptMaterial> ReceiptMaterials { get; set; }
        public DbSet <UserNote> UserNotes { get; set; }
        public DbSet<MaintenanceRequest> maintenanceRequests { get; set; }
        public DbSet<LeaseContract> LeaseContracts { get; set; }
        public DbSet<Quote> Quotes { get; set; }

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

            WorkReceiptList workReceiptList = new WorkReceiptList();
            List<WorkReceipt> workReceipts = workReceiptList.GetWorkReceipts();
            modelBuilder.Entity<WorkReceipt>().HasData(workReceipts.ToArray());

            ReceiptMaterialsList receiptMaterialsList = new ReceiptMaterialsList();
            List<ReceiptMaterial> receiptMaterials = receiptMaterialsList.GetReceiptMaterials();
            modelBuilder.Entity<ReceiptMaterial>().HasData(receiptMaterials.ToArray());

            InvoiceList InvoiceList = new InvoiceList();
            List<Classes.Invoice> invoices = InvoiceList.GetInvoices();
            modelBuilder.Entity<Classes.Invoice>().HasData(invoices.ToArray());

            OrderList orderList = new OrderList();
            List<Order> orders = orderList.GetOrders();
            modelBuilder.Entity<Order>().HasData(orders.ToArray());

            MaterialList materialList = new MaterialList();
            List<Material> materials = materialList.GetMaterials();
            modelBuilder.Entity<Material>().HasData(materials.ToArray());

            modelBuilder.Entity<ReceiptMaterial>()
               .HasKey(rm => new { rm.ReceiptId, rm.MaterialId }); // Composite key

                    modelBuilder.Entity<ReceiptMaterial>()
                        .HasOne(rm => rm.WorkReceipt)
                        .WithMany(wr => wr.ReceiptMaterials)
                        .HasForeignKey(rm => rm.ReceiptId);

                    modelBuilder.Entity<ReceiptMaterial>()
                        .HasOne(rm => rm.Material)
                        .WithMany(m => m.ReceiptMaterials)
                        .HasForeignKey(rm => rm.MaterialId);


            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, RoleName = "Maintenance" },
                new Role { Id = 2, RoleName = "Finance" },
                new Role { Id = 3, RoleName = "Sales" },
                new Role { Id = 4, RoleName = "Customer"},
                new Role { Id = 99, RoleName = "Admin" }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Customer User1",
                    Username = "customer1",
                    Email = "D295372@edu.curio.nl",
                    Password = BCrypt.Net.BCrypt.HashPassword("123"),
                    RoleId = 4,
                    IsFirstLogin = true
                },
                new User
                {
                    Id = 2,
                    Name = "Customer User2",
                    Username = "customer2",
                    Email = "customer2@example.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("123"),
                    RoleId = 4,
                    IsFirstLogin = true
                },
                new User
                {
                    Id = 3,
                    Name = "Customer User3",
                    Username = "customer3",
                    Email = "customer3@example.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("123"),
                    RoleId = 4,
                    IsFirstLogin = true
                },
                new User
                {
                    Id = 4,
                    Name = "Finance User",
                    Username = "finance",
                    Email = "finance@example.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("123"),
                    RoleId = 2,
                    IsFirstLogin = true
                },
                new User
                {
                    Id = 5,
                    Name = "Sales User",
                    Username = "sales",
                    Email = "sales@example.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("123"),
                    RoleId = 3,
                    IsFirstLogin = true
                },
                new User
                {
                    Id = 6,
                    Name = "Maintenance User",
                    Username = "maintenance",
                    Email = "maintenance@example.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("123"),
                    RoleId = 1,
                    IsFirstLogin = true
                },
                new User
                {
                    Id = 7,
                    Name = "George Cassel",
                    Username = "georgecassel",
                    Email = "georgecassel@example.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("123"),
                    RoleId = 1,
                    IsFirstLogin = true
                },
                new User
                {
                    Id = 8,
                    Name = "Stan Baker",
                    Email = "stanbaker@example.com",
                    Username = "stanbaker",
                    Password = BCrypt.Net.BCrypt.HashPassword("123"),
                    RoleId = 1,
                    IsFirstLogin = true
                },
                new User
                {
                    Id = 9,
                    Name = "Dhr. Maintenance",
                    Email = "d295372@edu.curio.nl", // martijn mail
                    Username = "headmaintenance",
                    Password = BCrypt.Net.BCrypt.HashPassword("123"),
                    RoleId = 1,
                    IsFirstLogin = true
                },
                new User
                {
                    Id = 10,
                    Name = "Admin",
                    Email = "admin@barrocintens.com",
                    Username = "admin",
                    Password = BCrypt.Net.BCrypt.HashPassword("123"),
                    RoleId = 99,
                    IsFirstLogin = false
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

            modelBuilder.Entity<Quote>().HasData(
                new Quote
                {
                    Id = 1,
                    CustomerId = 1,
                    QuoteDate = DateTime.Now,
                    ExpirationDate = DateTime.Now.AddDays(30),
                    TotalAmount = 1000,
                    Status = "Pending"
                },
                new Quote
                {
                    Id = 2,
                    CustomerId = 2,
                    QuoteDate = DateTime.Now,
                    ExpirationDate = DateTime.Now.AddDays(30),
                    TotalAmount = 2000,
                    Status = "Pending"
                },
                new Quote
                {
                    Id = 3,
                    CustomerId = 3,
                    QuoteDate = DateTime.Now,
                    ExpirationDate = DateTime.Now.AddDays(30),
                    TotalAmount = 3000,
                    Status = "Pending"
                }
            );
        }
    }
}
