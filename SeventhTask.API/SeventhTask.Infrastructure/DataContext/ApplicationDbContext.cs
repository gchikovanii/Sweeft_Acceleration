using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SeventhTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhTask.infrastucture.DataContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Pupil> Pupils { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Teacher>()
                .HasMany<Pupil>(i => i.Pupils)
                .WithMany(i => i.Teachers);
        }

        public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
        {
            public ApplicationDbContext CreateDbContext(string[] args)
            {
                var option = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer("Server=DESKTOP-POBH6I3; Database=SeventhTask; Trusted_Connection=True;TrustServerCertificate=True");
                return new ApplicationDbContext(option.Options);
            }
        }
    }
}
