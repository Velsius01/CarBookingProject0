using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarBookingProject_0.Domain;
using CarBookingProject_0.Configurations.Entities;

namespace CarBookingProject_0.Data
{
    public class CarBookingProject_0Context : DbContext
    {
        public CarBookingProject_0Context (DbContextOptions<CarBookingProject_0Context> options)
            : base(options)
        {
        }

        public DbSet<CarBookingProject_0.Domain.Feedback> Feedback { get; set; } = default!;
        public DbSet<CarBookingProject_0.Domain.Location> Location { get; set; } = default!;
        public DbSet<CarBookingProject_0.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<CarBookingProject_0.Domain.Promotion> Promotion { get; set; } = default!;
        public DbSet<CarBookingProject_0.Domain.Ride> Ride { get; set; } = default!;
        public DbSet<CarBookingProject_0.Domain.Role> Role { get; set; } = default!;
        public DbSet<CarBookingProject_0.Domain.User> User { get; set; } = default!;
        public DbSet<CarBookingProject_0.Domain.Vehicle> Vehicle { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure precision and scale for decimal properties
            modelBuilder.Entity<Location>()
                .Property(l => l.Latitude)
                .HasPrecision(10, 6); // Adjust to your required precision and scale
            modelBuilder.Entity<Location>()
                .Property(l => l.Longitude)
                .HasPrecision(10, 6);

            modelBuilder.Entity<Payment>()
                .Property(p => p.AmountPaid)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Promotion>()
                .Property(pr => pr.DiscountAmount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Ride>()
                .Property(r => r.RideCost)
                .HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new FeedbackSeed());
            modelBuilder.ApplyConfiguration(new LocationSeed());
            modelBuilder.ApplyConfiguration(new PaymentSeed());
            modelBuilder.ApplyConfiguration(new PromotionSeed());
            modelBuilder.ApplyConfiguration(new RideSeed());
            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new VehicleSeed());


        }
        
    }
}
