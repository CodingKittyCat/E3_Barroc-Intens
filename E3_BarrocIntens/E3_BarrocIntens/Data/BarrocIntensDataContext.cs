using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace E3_BarrocIntens.Data
{
    class BarrocIntensDataContext : DbContext
    {
        public DbSet<Lease_Contracts> Lease_Contracts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;" +
                "port=3306;" +
                "user=root;" +
                "password=;" +
                "database=barrocintens",
                ServerVersion.Parse("10.4.17-mariadb")
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lease_Contracts>().HasData(
                new Lease_Contracts
                {
                    Id = 1,
                    Type_Of_Time = "Monthly",
                    Time_Per_Period = 1,
                    Total_Price = 1000,
                    Price_Per_Period = 100,
                    Product_Id = 1,
                    Company_Id = 1
                },
                new Lease_Contracts
                {
                    Id = 2,
                    Type_Of_Time = "Monthly",
                    Time_Per_Period = 1,
                    Total_Price = 2000,
                    Price_Per_Period = 200,
                    Product_Id = 2,
                    Company_Id = 2
                },
                new Lease_Contracts
                {
                    Id = 3,
                    Type_Of_Time = "Monthly",
                    Time_Per_Period = 1,
                    Total_Price = 3000,
                    Price_Per_Period = 300,
                    Product_Id = 3,
                    Company_Id = 3
                },
                new Lease_Contracts
                {
                    Id = 4,
                    Type_Of_Time = "Monthly",
                    Time_Per_Period = 1,
                    Total_Price = 4000,
                    Price_Per_Period = 400,
                    Product_Id = 4,
                    Company_Id = 4
                }
            );
        }
    }
}
