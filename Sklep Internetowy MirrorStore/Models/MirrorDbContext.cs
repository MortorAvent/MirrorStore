
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
    }
}

