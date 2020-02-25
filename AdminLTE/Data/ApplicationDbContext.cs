using AdminLTE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<UserAudit> UserAuditEvents { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserAndDocs>()
              .HasKey(c => new { c.Id_Documento, c.Id_Usuario });

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
           
        }

        public DbSet<Docs> AspNetUserDocuments { get; set; }

        public DbSet<UserAndDocs> AspNetUserAndDocs { get; set; }

        public DbSet<ApplicationUser> AspNetUsers { get; set; }
    }
}
