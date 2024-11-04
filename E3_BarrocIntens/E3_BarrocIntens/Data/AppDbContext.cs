using System;
using System.Collections.Generic;
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
        public DbSet<Order> Orders { get; set; }

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

            OrderList orderList = new OrderList();

            List<Order> orders = orderList.GetOrders();
            
            modelBuilder.Entity<Order>().HasData(orders.ToArray());
        }

    }
}
