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
        public DbSet<TrainningDay> TrainningDays{ get; set; } 
        public DbSet<Exercise> Exercises{ get; set; } 
        public DbSet<Muscle> Muscles {get; set; } 
        public DbSet<TrainningExercise> TrainningExercises { get; set; }
        public DbSet<Management> Managements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            //modelBuilder.Entity<ApplicationUser>()
            //   .HasMany(u => u.UsersTrainings)
            //   .WithMany(t => t.Users)
            //   .UsingEntity(j => j.ToTable("UserTrainnings"));

            modelBuilder.Entity<ApplicationUser>()
              .HasMany(u => u.Managements)
              .WithMany(t => t.Users)
              .UsingEntity(j => j.ToTable("UserManagements"));

            modelBuilder.Entity<Exercise>()
                .HasMany(x => x.Muscles)
                .WithMany(x => x.Exercises);

            modelBuilder.Entity<TrainningExercise>()
                .HasOne(x => x.Exercise)
                .WithMany(x => x.TrainningExercises);

            modelBuilder.Entity<TrainningExercise>()
                .HasOne(x => x.TrainningDay)
                .WithMany(x => x.TrainningExercises);

            modelBuilder.Entity<Trainning>()
                .HasMany(x => x.TrainningDays)
                .WithOne(x => x.Trainning);

            modelBuilder.Entity<Trainning>()
               .HasMany(x => x.Users)
               .WithMany(x => x.Trainings);


            modelBuilder.Entity<Trainning>()
                .HasOne(t => t.Gym)
                .WithMany(u => u.Trainnings)
                .HasForeignKey(t => t.GymId);

            modelBuilder.Entity<Trainning>()
                .HasOne(t => t.Management)
                .WithMany(u => u.Trainnings)
                .HasForeignKey(t => t.ManagementId);

            //modelBuilder.Entity<Gym>()
            //    .HasMany(t => t.Users)
            //    .WithOne(u => u.Gym)
            //    .HasForeignKey(t => t.GymId);

            //modelBuilder.Entity<Gym>()
            //    .HasMany(t => t.Personals)
            //    .WithOne(u => u.Gym)
            //    .HasForeignKey(t => t.GymId);

            //modelBuilder.Entity<Gym>()
            //    .HasMany(t => t.Administrators)
            //    .WithOne(u => u.Gym)
            //    .HasForeignKey(t => t.GymId);

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(u => u.Gym)
                .WithMany(g => g.Users)
                .HasForeignKey(u => u.GymId)
                .OnDelete(DeleteBehavior.Restrict);



            //modelBuilder.Entity<ApplicationUser>().HasMany(t => t.Trainnings).WithMany(x => x.Users);
            //modelBuilder.Entity<Trainning>().HasMany(x => x.Users).WithMany(x => x.Trainnings).UsingEntity(j => j.ToTable("UserTrainning"));
        }
    }
}
