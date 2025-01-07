using CQRSProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.Context
{
    public class CQRSContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DD\\SQLEXPRESS01;database=CQRSDb;integrated security=true;TrustServerCertificate=True;");


        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
