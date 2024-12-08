using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarBookingProject_0.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "Comments", "CreatedBy", "DateCreated", "DateUpdated", "FeedbackDateTime", "Rating", "RideId", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "Great ride! The driver was very professional.", "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4825), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4826), new DateTime(2024, 12, 6, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4810), 5, 1, "System", 1 },
                    { 2, "The ride was okay, but the car was a bit dirty.", "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4830), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4830), new DateTime(2024, 12, 7, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4829), 3, 2, "System", 2 }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Address", "City", "CreatedBy", "DateCreated", "DateUpdated", "Latitude", "Longitude", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Marina Bay Sands, 10 Bayfront Ave", "Singapore", "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4986), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4987), 1.290270m, 103.851959m, "System" },
                    { 2, "Sentosa Island", "Singapore", "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4989), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4989), 1.352083m, 103.819836m, "System" }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "AmountPaid", "CreatedBy", "DateCreated", "DateUpdated", "PaymentStatus", "PaymentType", "RideId", "TransactionDateTime", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, 25.50m, "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5064), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5065), "Completed", "Credit Card", 1, new DateTime(2024, 12, 8, 20, 33, 35, 863, DateTimeKind.Local).AddTicks(5063), "System", 1 },
                    { 2, 30.00m, "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5067), "Pending", "Cash", 2, new DateTime(2024, 12, 8, 20, 53, 35, 863, DateTimeKind.Local).AddTicks(5066), "System", 2 }
                });

            migrationBuilder.InsertData(
                table: "Promotion",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DiscountAmount", "EndDate", "PromotionCode", "StartDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5121), 10.00m, new DateTime(2024, 12, 28, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5120), "SAVE10", new DateTime(2024, 11, 28, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5118), "System" },
                    { 2, "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5124), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5124), 20.00m, new DateTime(2024, 12, 23, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5123), "WELCOME20", new DateTime(2024, 12, 3, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5123), "System" }
                });

            migrationBuilder.InsertData(
                table: "Ride",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DropoffTime", "LocationId", "PickupTime", "PromotionId", "RideCost", "RideStatus", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5174), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5174), new DateTime(2024, 12, 8, 20, 3, 35, 863, DateTimeKind.Local).AddTicks(5172), 1, new DateTime(2024, 12, 8, 19, 3, 35, 863, DateTimeKind.Local).AddTicks(5171), 1, 25.50m, "Completed", "System", 1 },
                    { 2, "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5177), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5177), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5176), 2, new DateTime(2024, 12, 8, 20, 3, 35, 863, DateTimeKind.Local).AddTicks(5175), 2, 30.00m, "Ongoing", "System", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5225), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5227), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AcceptanceRate", "Address", "CarLicense", "CreatedBy", "DateCreated", "DateOfBirth", "DateUpdated", "DrivingExperience", "Email", "FrequentLocations", "Gender", "Name", "PhoneNumber", "PreferredPickupTime", "RoleId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "", "Jurong East", "", "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5279), "05/03/2001", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5280), "", "Jordan01239@gmail.com", "Jurong East, Clementi", "Male", "Jordan", "97593043", "Morning", 0, "System" },
                    { 2, "75.5%", "Jurong West", "SGX1234A", "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5282), "22/10/2000", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5283), "2 years", "Jeff019231@gmail.com", "Jurong West, Pioneer", "Male", "Jeff", "93843943", "Morning", 0, "System" }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "LicensePlate", "Manufacturer", "MaximumPassengers", "Model", "Status", "UpdatedBy", "UserId", "Year" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5335), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5335), "MBX3829B", "Honda", "4", "Corolla", "Active", "System", 0, "2020" },
                    { 2, "System", new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5337), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5338), "JKX8273C", "Toyota", "4", "Civic", "Active", "System", 0, "2017" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 0, 39, 840, DateTimeKind.Local).AddTicks(7251), new DateTime(2024, 12, 8, 21, 0, 39, 840, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 0, 39, 840, DateTimeKind.Local).AddTicks(7264), new DateTime(2024, 12, 8, 21, 0, 39, 840, DateTimeKind.Local).AddTicks(7264) });
        }
    }
}
