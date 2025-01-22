﻿// <auto-generated />
using System;
using CarBookingProject_0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarBookingProject_0.Migrations
{
    [DbContext(typeof(CarBookingProject_0Context))]
    [Migration("20250122012340_SeedUserRole")]
    partial class SeedUserRole
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarBookingProject_0.Data.CarBookingProject_0User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("CarBookingProject_0.Domain.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FeedbackDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("RideId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Feedback");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comments = "Great ride! The driver was very professional.",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9540),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9541),
                            FeedbackDateTime = new DateTime(2025, 1, 20, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9516),
                            Rating = 5,
                            RideId = 1,
                            UpdatedBy = "System",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Comments = "The ride was okay, but the car was a bit dirty.",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9544),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9544),
                            FeedbackDateTime = new DateTime(2025, 1, 21, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9543),
                            Rating = 3,
                            RideId = 2,
                            UpdatedBy = "System",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("CarBookingProject_0.Domain.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Latitude")
                        .HasPrecision(10, 6)
                        .HasColumnType("decimal(10,6)");

                    b.Property<decimal?>("Longitude")
                        .HasPrecision(10, 6)
                        .HasColumnType("decimal(10,6)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Marina Bay Sands, 10 Bayfront Ave",
                            City = "Singapore",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9740),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9741),
                            Latitude = 1.290270m,
                            Longitude = 103.851959m,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Sentosa Island",
                            City = "Singapore",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9744),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9745),
                            Latitude = 1.352083m,
                            Longitude = 103.819836m,
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("CarBookingProject_0.Domain.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AmountPaid")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RideId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Payment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AmountPaid = 25.50m,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9844),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9845),
                            PaymentStatus = "Completed",
                            PaymentType = "Credit Card",
                            RideId = 1,
                            TransactionDateTime = new DateTime(2025, 1, 22, 8, 53, 39, 684, DateTimeKind.Local).AddTicks(9842),
                            UpdatedBy = "System",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AmountPaid = 30.00m,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9848),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9849),
                            PaymentStatus = "Pending",
                            PaymentType = "Cash",
                            RideId = 2,
                            TransactionDateTime = new DateTime(2025, 1, 22, 9, 13, 39, 684, DateTimeKind.Local).AddTicks(9847),
                            UpdatedBy = "System",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("CarBookingProject_0.Domain.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DiscountAmount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PromotionCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Promotion");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9941),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9942),
                            DiscountAmount = 10.00m,
                            EndDate = new DateTime(2025, 2, 11, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9940),
                            PromotionCode = "SAVE10",
                            StartDate = new DateTime(2025, 1, 12, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9938),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9945),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9945),
                            DiscountAmount = 20.00m,
                            EndDate = new DateTime(2025, 2, 6, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9944),
                            PromotionCode = "WELCOME20",
                            StartDate = new DateTime(2025, 1, 17, 9, 23, 39, 684, DateTimeKind.Local).AddTicks(9943),
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("CarBookingProject_0.Domain.Ride", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DropoffTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PickupTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("PromotionId")
                        .HasColumnType("int");

                    b.Property<decimal>("RideCost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RideStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ride");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(65),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(65),
                            DropoffTime = new DateTime(2025, 1, 22, 8, 23, 39, 685, DateTimeKind.Local).AddTicks(63),
                            LocationId = 1,
                            PickupTime = new DateTime(2025, 1, 22, 7, 23, 39, 685, DateTimeKind.Local).AddTicks(59),
                            PromotionId = 1,
                            RideCost = 25.50m,
                            RideStatus = "Completed",
                            UpdatedBy = "System",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(69),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(70),
                            DropoffTime = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(68),
                            LocationId = 2,
                            PickupTime = new DateTime(2025, 1, 22, 8, 23, 39, 685, DateTimeKind.Local).AddTicks(67),
                            PromotionId = 2,
                            RideCost = 30.00m,
                            RideStatus = "Ongoing",
                            UpdatedBy = "System",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("CarBookingProject_0.Domain.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(151),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(152),
                            RoleType = "Driver",
                            UpdatedBy = "System",
                            UserId = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(153),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(154),
                            RoleType = "Passenger",
                            UpdatedBy = "System",
                            UserId = 0
                        });
                });

            modelBuilder.Entity("CarBookingProject_0.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AcceptanceRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("DrivingExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrequentLocations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferredPickupTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AcceptanceRate = "",
                            Address = "Jurong East",
                            CarLicense = "",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(249),
                            DateOfBirth = "05/03/2001",
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(250),
                            DrivingExperience = "",
                            Email = "Jordan01239@gmail.com",
                            FrequentLocations = "Jurong East, Clementi",
                            Gender = "Male",
                            Name = "Jordan",
                            PhoneNumber = "97593043",
                            PreferredPickupTime = "Morning",
                            RoleId = 0,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            AcceptanceRate = "75.5%",
                            Address = "Jurong West",
                            CarLicense = "SGX1234A",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(253),
                            DateOfBirth = "22/10/2000",
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(254),
                            DrivingExperience = "2 years",
                            Email = "Jeff019231@gmail.com",
                            FrequentLocations = "Jurong West, Pioneer",
                            Gender = "Male",
                            Name = "Jeff",
                            PhoneNumber = "93843943",
                            PreferredPickupTime = "Morning",
                            RoleId = 0,
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("CarBookingProject_0.Domain.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LicensePlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaximumPassengers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(371),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(372),
                            LicensePlate = "MBX3829B",
                            Manufacturer = "Honda",
                            MaximumPassengers = "4",
                            Model = "Corolla",
                            Status = "Active",
                            UpdatedBy = "System",
                            UserId = 0,
                            Year = "2020"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(374),
                            DateUpdated = new DateTime(2025, 1, 22, 9, 23, 39, 685, DateTimeKind.Local).AddTicks(375),
                            LicensePlate = "JKX8273C",
                            Manufacturer = "Toyota",
                            MaximumPassengers = "4",
                            Model = "Civic",
                            Status = "Active",
                            UpdatedBy = "System",
                            UserId = 0,
                            Year = "2017"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CarBookingProject_0.Data.CarBookingProject_0User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CarBookingProject_0.Data.CarBookingProject_0User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBookingProject_0.Data.CarBookingProject_0User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CarBookingProject_0.Data.CarBookingProject_0User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
