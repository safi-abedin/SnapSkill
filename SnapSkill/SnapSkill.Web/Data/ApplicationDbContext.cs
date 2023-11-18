using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SnapSkill.Web.Areas.Admin.Models;
using System.Reflection.Emit;

namespace SnapSkill.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
               builder.Entity<Course>()
             . Property(c => c.startDate)
               .HasColumnType("Date");

               builder.Entity<IdentityUserLogin<string>>()
               .HasNoKey();

               builder.Entity<IdentityUserRole<string>>()
               .HasNoKey();

               builder.Entity<IdentityUserToken<string>>()
               .HasNoKey();
        }

        public DbSet<Course> Courses { get; set; }
    }
}