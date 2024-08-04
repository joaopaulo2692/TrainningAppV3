using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Entities;

namespace TrainningApp.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
        {
        }
        public DbSet<Trainning> Trainnings { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            modelBuilder.Entity<ApplicationUser>()
               .HasMany(u => u.Trainnings)
               .WithMany(t => t.Users)
               .UsingEntity(j => j.ToTable("UserTrainnings"));

            modelBuilder.Entity<ApplicationUser>()
              .HasMany(u => u.Managements)
              .WithMany(t => t.Users)
              .UsingEntity(j => j.ToTable("UserManagements"));

            //modelBuilder.Entity<ApplicationUser>().HasMany(t => t.Trainnings).WithMany(x => x.Users);
            //modelBuilder.Entity<Trainning>().HasMany(x => x.Users).WithMany(x => x.Trainnings).UsingEntity(j => j.ToTable("UserTrainning"));
        }
    }
}
