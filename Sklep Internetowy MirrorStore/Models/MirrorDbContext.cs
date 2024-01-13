
using Microsoft.EntityFrameworkCore;

namespace Sklep_Internetowy_MirrorStore.Models
{
    public class MirrorDbContext : DbContext
    {
        public MirrorDbContext(DbContextOptions<MirrorDbContext> options) :
       base(options)
        {
        }
        public DbSet<Mirror> Mirrors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DevConnection");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Konfiguracje relacji
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User);

            modelBuilder.Entity<OrderDetail>()
                .HasKey(od => new { od.OrderId, od.MirrorId });
        }
    }
}

