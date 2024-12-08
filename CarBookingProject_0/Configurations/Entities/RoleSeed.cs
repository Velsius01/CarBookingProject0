using Microsoft.EntityFrameworkCore;
using CarBookingProject_0.Domain;
using System.Drawing;

namespace CarBookingProject_0.Configurations.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<Role>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    Id = 1,
                    RoleType = "Driver",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Role
                {
                    Id = 2,
                    RoleType = "Passenger",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
        );
        }
    }
}
