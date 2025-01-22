using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarBookingProject_0.Configurations.Entities;
using CarBookingProject_0.Domain;

namespace CarBookingProject_0.Data
{
    public class CarBookingProject_0Context : IdentityDbContext<CarBookingProject_0User>
    {
        public CarBookingProject_0Context(DbContextOptions<CarBookingProject_0Context> options)
            : base(options)
        {
        }

        public DbSet<Feedback> Feedback { get; set; } = default!;
        public DbSet<Location> Location { get; set; } = default!;
        public DbSet<Payment> Payment { get; set; } = default!;
        public DbSet<Promotion> Promotion { get; set; } = default!;
        public DbSet<Ride> Ride { get; set; } = default!;
        public DbSet<Role> Role { get; set; } = default!;
        public DbSet<User> User { get; set; } = default!;
        public DbSet<Vehicle> Vehicle { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>()
                .Property(l => l.Latitude)
                .HasPrecision(10, 6);
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
            modelBuilder.ApplyConfiguration(new RolesListSeed());
            modelBuilder.ApplyConfiguration(new UsersListSeed());
            modelBuilder.ApplyConfiguration(new VehicleSeed());
        }
    }
}

