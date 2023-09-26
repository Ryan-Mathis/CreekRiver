﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CreekRiver.Migrations
{
    [DbContext(typeof(CreekRiverDbContext))]
    [Migration("20230926153345_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CreekRiver.Models.Campsite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CampsiteTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CampsiteTypeId");

                    b.ToTable("Campsites");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CampsiteTypeId = 1,
                            ImageUrl = "https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg",
                            Nickname = "Barred Owl"
                        },
                        new
                        {
                            Id = 2,
                            CampsiteTypeId = 2,
                            ImageUrl = "https://tnstateparks.com/assets/images/hero-images/big-hill-pond.jpg",
                            Nickname = "Big Hill Pond"
                        },
                        new
                        {
                            Id = 3,
                            CampsiteTypeId = 3,
                            ImageUrl = "https://tnstateparks.com/assets/images/hero-images/burgess-falls.jpg",
                            Nickname = "Burgess Falls"
                        },
                        new
                        {
                            Id = 4,
                            CampsiteTypeId = 4,
                            ImageUrl = "https://tnstateparks.com/assets/images/hero-images/chickasaw.jpg",
                            Nickname = "Chickasaw"
                        },
                        new
                        {
                            Id = 5,
                            CampsiteTypeId = 1,
                            ImageUrl = "https://tnstateparks.com/assets/images/hero-images/cove-lake.jpg",
                            Nickname = "Cove Lake"
                        });
                });

            modelBuilder.Entity("CreekRiver.Models.CampsiteType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CampsiteTypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("FeePerNight")
                        .HasColumnType("numeric");

                    b.Property<int>("MaxReservationDays")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("CampsiteTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CampsiteTypeName = "Tent",
                            FeePerNight = 15.99m,
                            MaxReservationDays = 7
                        },
                        new
                        {
                            Id = 2,
                            CampsiteTypeName = "RV",
                            FeePerNight = 26.50m,
                            MaxReservationDays = 14
                        },
                        new
                        {
                            Id = 3,
                            CampsiteTypeName = "Primitive",
                            FeePerNight = 10.00m,
                            MaxReservationDays = 3
                        },
                        new
                        {
                            Id = 4,
                            CampsiteTypeName = "Hammock",
                            FeePerNight = 12m,
                            MaxReservationDays = 7
                        });
                });

            modelBuilder.Entity("CreekRiver.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CampsiteId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CheckinDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CheckoutDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserProfileId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CampsiteId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CampsiteId = 3,
                            CheckinDate = new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckoutDate = new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 2,
                            CampsiteId = 4,
                            CheckinDate = new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckoutDate = new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserProfileId = 2
                        });
                });

            modelBuilder.Entity("CreekRiver.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "ryannoahm@live.com",
                            FirstName = "Ryan",
                            LastName = "Mathis"
                        },
                        new
                        {
                            Id = 2,
                            Email = "ecm@gmail.com",
                            FirstName = "Ethan",
                            LastName = "Chaz"
                        });
                });

            modelBuilder.Entity("CreekRiver.Models.Campsite", b =>
                {
                    b.HasOne("CreekRiver.Models.CampsiteType", "CampsiteType")
                        .WithMany()
                        .HasForeignKey("CampsiteTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CampsiteType");
                });

            modelBuilder.Entity("CreekRiver.Models.Reservation", b =>
                {
                    b.HasOne("CreekRiver.Models.Campsite", "Campsite")
                        .WithMany("Reservations")
                        .HasForeignKey("CampsiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CreekRiver.Models.UserProfile", "UserProfile")
                        .WithMany("Reservations")
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campsite");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("CreekRiver.Models.Campsite", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("CreekRiver.Models.UserProfile", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
