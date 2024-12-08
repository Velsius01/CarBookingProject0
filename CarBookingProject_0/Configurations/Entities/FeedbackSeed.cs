using CarBookingProject_0.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBookingProject_0.Configurations.Entities
{
    public class FeedbackSeed : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Feedback> builder)
        {
            builder.HasData(
                new Feedback
                {
                    Id = 1,
                    Rating = 5,
                    Comments = "Great ride! The driver was very professional.",
                    FeedbackDateTime = DateTime.Now.AddDays(-2), // 2 days ago
                    RideId = 1, 
                    UserId = 1, 
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Feedback
                {
                    Id = 2,
                    Rating = 3,
                    Comments = "The ride was okay, but the car was a bit dirty.",
                    FeedbackDateTime = DateTime.Now.AddDays(-1), // 1 day ago
                    RideId = 2, 
                    UserId = 2, 
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
