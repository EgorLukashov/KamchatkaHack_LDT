using KamchatkaHack_MapWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace KamchatkaHack_MapWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Models.Route> route { get; set; }
        public DbSet<Park> park { get; set; }
        //public DbSet<Admin> admins { get; set; }
    }
}
