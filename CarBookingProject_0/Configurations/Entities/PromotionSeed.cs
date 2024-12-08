using CarBookingProject_0.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBookingProject_0.Configurations.Entities
{
    public class PromotionSeed : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Promotion> builder)
        {
            builder.HasData(
                new Promotion
                {
                    Id = 1,
                    PromotionCode = "SAVE10",
                    DiscountAmount = 10.00m, // Discount in dollars
                    StartDate = DateTime.Now.AddDays(-10), // Started 10 days ago
                    EndDate = DateTime.Now.AddDays(20), // Ends in 20 days

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Promotion
                {
                    Id = 2,
                    PromotionCode = "WELCOME20",
                    DiscountAmount = 20.00m,
                    StartDate = DateTime.Now.AddDays(-5), // Started 5 days ago
                    EndDate = DateTime.Now.AddDays(15), // Ends in 15 days

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
        );
        }
    }
}
