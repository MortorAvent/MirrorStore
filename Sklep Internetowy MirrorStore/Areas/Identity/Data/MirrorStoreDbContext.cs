using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sklep_Internetowy_MirrorStore.Areas.Identity.Data;
using Sklep_Internetowy_MirrorStore.Models;

namespace Sklep_Internetowy_MirrorStore.Areas.Identity.Data;

public class MirrorStoreDbContext : IdentityDbContext<MirrorStoreUser>
{

    public MirrorStoreDbContext(DbContextOptions<MirrorStoreDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
    private class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<MirrorStoreUser>
    {
        public void Configure(EntityTypeBuilder<MirrorStoreUser> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(255);
            builder.Property(x => x.LastName).HasMaxLength(255);
        }
    }
}
