using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarBookingProject_0.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "RoleType", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 8, 21, 0, 39, 840, DateTimeKind.Local).AddTicks(7251), new DateTime(2024, 12, 8, 21, 0, 39, 840, DateTimeKind.Local).AddTicks(7262), "Driver", "System", 0 },
                    { 2, "System", new DateTime(2024, 12, 8, 21, 0, 39, 840, DateTimeKind.Local).AddTicks(7264), new DateTime(2024, 12, 8, 21, 0, 39, 840, DateTimeKind.Local).AddTicks(7264), "Passenger", "System", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
