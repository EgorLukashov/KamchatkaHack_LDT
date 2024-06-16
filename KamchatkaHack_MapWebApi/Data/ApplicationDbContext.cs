using KamchatkaHack_MapWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace KamchatkaHack_MapWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Park> park { get; set; }
        public DbSet<Models.Route> route { get; set; }
        public DbSet<Admin> Admin { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Указываем, что свойство IDPark является первичным ключом
            modelBuilder.Entity<Park>().HasKey(p => p.IDPark);
            modelBuilder.Entity<Models.Route>().HasKey(p => p.IDRoute);
            modelBuilder.Entity<Models.Route>()
               .HasOne(r => r.Park)        // Указываем, что у маршрута есть один парк
               .WithMany()                 // Предполагаем, что у парка может быть много маршрутов
               .HasForeignKey(r => r.ParkID);
        }
        
        //public DbSet<Admin> admins { get; set; }
    }
}
