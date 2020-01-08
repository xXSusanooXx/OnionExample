using Microsoft.EntityFrameworkCore;
using OnionExample.DAL.Entities;

namespace OnionExample.DAL.EF
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        public DbSet<Order> Orders { get; set; }

        public MobileContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GI1IQF7\\SQLEXPRESS;Database=MobilePhones;Trusted_Connection=True;");
        }
    }
}