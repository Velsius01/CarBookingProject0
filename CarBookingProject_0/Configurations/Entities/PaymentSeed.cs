using CarBookingProject_0.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBookingProject_0.Configurations.Entities
{
    public class PaymentSeed : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasData(
            new Payment
            {
                Id = 1,
                PaymentType = "Credit Card",
                AmountPaid = 25.50m,
                PaymentStatus = "Completed",
                TransactionDateTime = DateTime.Now.AddMinutes(-30), // 30 minutes ago
                RideId = 1, 
                UserId = 1, 
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Payment
            {
                Id = 2,
                PaymentType = "Cash",
                AmountPaid = 30.00m,
                PaymentStatus = "Pending",
                TransactionDateTime = DateTime.Now.AddMinutes(-10), // 10 minutes ago
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
