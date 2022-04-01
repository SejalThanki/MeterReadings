﻿// <auto-generated />
using System;
using MeterReading.WebAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeterReading.WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220331164346_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeterReading.WebAPI.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MeterReadValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("MeterReadingDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = 2344,
                            FirstName = "Tommy",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 2233,
                            FirstName = "Barry",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 8766,
                            FirstName = "Sally",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 2345,
                            FirstName = "Jerry",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 2346,
                            FirstName = "Ollie",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 2347,
                            FirstName = "Tara",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 2348,
                            FirstName = "Tammy",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 2349,
                            FirstName = "Simon",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 2350,
                            FirstName = "Colin",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 2351,
                            FirstName = "Gladys",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 2352,
                            FirstName = "Greg",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 2353,
                            FirstName = "Tony",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 2355,
                            FirstName = "Arthur",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 2356,
                            FirstName = "Craig",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 6776,
                            FirstName = "Laura",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 4534,
                            FirstName = "JOSH",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 1234,
                            FirstName = "Freya",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 1239,
                            FirstName = "Noddy",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 1240,
                            FirstName = "Archie",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 1241,
                            FirstName = "Lara",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 1242,
                            FirstName = "Tim",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 1243,
                            FirstName = "Graham",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 1244,
                            FirstName = "Tony",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 1245,
                            FirstName = "Neville",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 1246,
                            FirstName = "Jo",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 1247,
                            FirstName = "Jim",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AccountId = 1248,
                            FirstName = "Pam",
                            LastName = "Test",
                            MeterReadValue = 0,
                            MeterReadingDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
