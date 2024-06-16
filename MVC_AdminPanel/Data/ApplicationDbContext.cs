using MVC_AdminPanel.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC_AdminPanel.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Admin> Admin { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Указываем, что свойство IDPark является первичным ключом
            modelBuilder.Entity<Admin>().HasKey(p => p.IDAdmin);
        }

        //public DbSet<Admin> admins { get; set; }
    }
}
