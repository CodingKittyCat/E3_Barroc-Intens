using E3_BarrocIntens.Data.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3_BarrocIntens.Data.Lists;

namespace E3_BarrocIntens.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }

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

            List<Invoice> invoices = InvoiceList.GetInvoices();
            modelBuilder.Entity<Invoice>().HasData(invoices.ToArray());
        }

    }
}
