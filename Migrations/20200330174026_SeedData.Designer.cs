﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

namespace travelapi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20200330174026_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            City = "Venice",
                            Country = "Italy"
                        },
                        new
                        {
                            DestinationId = 2,
                            City = "Madrid",
                            Country = "Spain"
                        },
                        new
                        {
                            DestinationId = 3,
                            City = "Berin",
                            Country = "Germany"
                        },
                        new
                        {
                            DestinationId = 4,
                            City = "Lagos",
                            Country = "Africa"
                        },
                        new
                        {
                            DestinationId = 5,
                            City = "Washington",
                            Country = "United States"
                        },
                        new
                        {
                            DestinationId = 6,
                            City = "Paris",
                            Country = "France"
                        });
                });

            modelBuilder.Entity("TravelApi.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewerName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ReviewId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Description = "Awesome place",
                            DestinationId = 1,
                            Rating = 5,
                            ReviewerName = "Andriy"
                        },
                        new
                        {
                            ReviewId = 2,
                            Description = "Better places",
                            DestinationId = 2,
                            Rating = 3,
                            ReviewerName = "Andriy"
                        },
                        new
                        {
                            ReviewId = 3,
                            Description = "Great except for...",
                            DestinationId = 3,
                            Rating = 4,
                            ReviewerName = "Andrew"
                        },
                        new
                        {
                            ReviewId = 4,
                            Description = "Awesome place",
                            DestinationId = 3,
                            Rating = 5,
                            ReviewerName = "Andrew"
                        },
                        new
                        {
                            ReviewId = 5,
                            Description = "Awesome place",
                            DestinationId = 4,
                            Rating = 5,
                            ReviewerName = "Andriy"
                        },
                        new
                        {
                            ReviewId = 6,
                            Description = "Awesome place",
                            DestinationId = 5,
                            Rating = 5,
                            ReviewerName = "Andriy"
                        });
                });

            modelBuilder.Entity("TravelApi.Models.Review", b =>
                {
                    b.HasOne("TravelApi.Models.Destination", "Destination")
                        .WithMany("Reviews")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}