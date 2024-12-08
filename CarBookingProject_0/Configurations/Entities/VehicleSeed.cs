using CarBookingProject_0.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBookingProject_0.Configurations.Entities
{
    public class VehicleSeed : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData(
                new Vehicle
                {
                    Id = 1,
                    LicensePlate = "MBX3829B",
                    Model = "Corolla",
                    Manufacturer = "Honda",
                    Year = "2020",
                    Status = "Active",
                    MaximumPassengers = "4",

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Vehicle
                {
                    Id = 2,
                    LicensePlate = "JKX8273C",
                    Model = "Civic",
                    Manufacturer = "Toyota",
                    Year = "2017",
                    Status = "Active",
                    MaximumPassengers = "4",

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
        );
        }
    }
}
