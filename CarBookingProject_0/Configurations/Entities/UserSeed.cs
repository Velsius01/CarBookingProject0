
using Microsoft.EntityFrameworkCore;
using CarBookingProject_0.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CarBookingProject_0.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    Name = "Jordan",
                    Email = "Jordan01239@gmail.com",
                    PhoneNumber = "97593043",
                    DateOfBirth = "05/03/2001",
                    Gender = "Male",
                    Address = "Jurong East",
                    CarLicense = "",
                    AcceptanceRate = "",
                    DrivingExperience = "",
                    FrequentLocations = "Jurong East, Clementi",
                    PreferredPickupTime = "Morning",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new User
                {
                    Id = 2,
                    Name = "Jeff",
                    Email = "Jeff019231@gmail.com",
                    PhoneNumber = "93843943",
                    DateOfBirth = "22/10/2000",
                    Gender = "Male",
                    Address = "Jurong West",
                    CarLicense = "SGX1234A",
                    AcceptanceRate = "75.5%",
                    DrivingExperience = "2 years",
                    FrequentLocations = "Jurong West, Pioneer",
                    PreferredPickupTime = "Morning",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
        );
        }
    }
}
