using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBookingProject_0.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "FeedbackDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9540), new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9541), new DateTime(2025, 1, 20, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "FeedbackDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9544), new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9544), new DateTime(2025, 1, 21, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9740), new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9744), new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "TransactionDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9844), new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9845), new DateTime(2025, 1, 22, 8, 53, 39, 684, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "TransactionDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9848), new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9849), new DateTime(2025, 1, 22, 9, 13, 39, 684, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9941), new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9942), new DateTime(2025, 2, 11, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9940), new DateTime(2025, 1, 12, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9945), new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9945), new DateTime(2025, 2, 6, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9944), new DateTime(2025, 1, 17, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "DropoffTime", "PickupTime" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(65), new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(65), new DateTime(2025, 1, 22, 8, 23, 39, 685, DateTimeKind.Local).AddTicks(63), new DateTime(2025, 1, 22, 7, 23, 39, 685, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "DropoffTime", "PickupTime" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(69), new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(70), new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(68), new DateTime(2025, 1, 22, 8, 23, 39, 685, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(151), new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(153), new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(249), new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(253), new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(371), new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(374), new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(375) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "FeedbackDateTime" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6237), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6238), new DateTime(2025, 1, 6, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "FeedbackDateTime" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6243), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6244), new DateTime(2025, 1, 7, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6482), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6488), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "TransactionDateTime" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6603), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6604), new DateTime(2025, 1, 8, 8, 55, 46, 742, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "TransactionDateTime" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6609), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6610), new DateTime(2025, 1, 8, 9, 15, 46, 742, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6713), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6714), new DateTime(2025, 1, 28, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 12, 29, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6718), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6719), new DateTime(2025, 1, 23, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6717), new DateTime(2025, 1, 3, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "DropoffTime", "PickupTime" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6826), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6827), new DateTime(2025, 1, 8, 8, 25, 46, 742, DateTimeKind.Local).AddTicks(6823), new DateTime(2025, 1, 8, 7, 25, 46, 742, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "DropoffTime", "PickupTime" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6832), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6833), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6830), new DateTime(2025, 1, 8, 8, 25, 46, 742, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6928), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6931), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(7040), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(7046), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(7189), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(7194), new DateTime(2025, 1, 8, 9, 25, 46, 742, DateTimeKind.Local).AddTicks(7194) });
        }
    }
}
