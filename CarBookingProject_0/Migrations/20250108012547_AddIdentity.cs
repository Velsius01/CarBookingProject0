using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBookingProject_0.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "FeedbackDateTime" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4825), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4826), new DateTime(2024, 12, 6, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "FeedbackDateTime" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4830), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4830), new DateTime(2024, 12, 7, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4986), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4989), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "TransactionDateTime" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5064), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5065), new DateTime(2024, 12, 8, 20, 33, 35, 863, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "TransactionDateTime" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 12, 8, 20, 53, 35, 863, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 12, 28, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5120), new DateTime(2024, 11, 28, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5124), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5124), new DateTime(2024, 12, 23, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5123), new DateTime(2024, 12, 3, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "DropoffTime", "PickupTime" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5174), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5174), new DateTime(2024, 12, 8, 20, 3, 35, 863, DateTimeKind.Local).AddTicks(5172), new DateTime(2024, 12, 8, 19, 3, 35, 863, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "DropoffTime", "PickupTime" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5177), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5177), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5176), new DateTime(2024, 12, 8, 20, 3, 35, 863, DateTimeKind.Local).AddTicks(5175) });

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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5279), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5282), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5335), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5337), new DateTime(2024, 12, 8, 21, 3, 35, 863, DateTimeKind.Local).AddTicks(5338) });
        }
    }
}
