using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace E3_BarrocIntens.Data
{
  
    internal class AppDbContext : DbContext
    {
        string connectionString = "server=localhost;port=3306;user=root;password=;database=pra_barroc-intens";
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.Parse("8.0.30"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
                }
            );
        }


    }
}
