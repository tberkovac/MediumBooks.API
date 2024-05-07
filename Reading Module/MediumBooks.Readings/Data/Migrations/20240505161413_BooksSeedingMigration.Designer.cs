﻿// <auto-generated />
using MediumBooks.Readings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MediumBooks.Readings.Data.Migrations
{
    [DbContext(typeof(BooksDbContext))]
    [Migration("20240505161413_BooksSeedingMigration")]
    partial class BooksSeedingMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("reading")
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MediumBooks.Readings.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BookId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("BookId");

                    b.ToTable("Books", "reading");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 2,
                            AuthorName = "Name 2",
                            Name = "Interesting book 1"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 3,
                            AuthorName = "Name 3",
                            Name = "Interesting book 2"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 4,
                            AuthorName = "Name 4",
                            Name = "Interesting book 3"
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 5,
                            AuthorName = "Name 5",
                            Name = "Interesting book 4"
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 6,
                            AuthorName = "Name 6",
                            Name = "Interesting book 5"
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 7,
                            AuthorName = "Name 7",
                            Name = "Interesting book 6"
                        },
                        new
                        {
                            BookId = 7,
                            AuthorId = 8,
                            AuthorName = "Name 8",
                            Name = "Interesting book 7"
                        },
                        new
                        {
                            BookId = 8,
                            AuthorId = 9,
                            AuthorName = "Name 9",
                            Name = "Interesting book 8"
                        },
                        new
                        {
                            BookId = 9,
                            AuthorId = 10,
                            AuthorName = "Name 10",
                            Name = "Interesting book 9"
                        },
                        new
                        {
                            BookId = 10,
                            AuthorId = 1,
                            AuthorName = "Name 1",
                            Name = "Interesting book 10"
                        },
                        new
                        {
                            BookId = 11,
                            AuthorId = 2,
                            AuthorName = "Name 2",
                            Name = "Interesting book 11"
                        },
                        new
                        {
                            BookId = 12,
                            AuthorId = 3,
                            AuthorName = "Name 3",
                            Name = "Interesting book 12"
                        },
                        new
                        {
                            BookId = 13,
                            AuthorId = 4,
                            AuthorName = "Name 4",
                            Name = "Interesting book 13"
                        },
                        new
                        {
                            BookId = 14,
                            AuthorId = 5,
                            AuthorName = "Name 5",
                            Name = "Interesting book 14"
                        },
                        new
                        {
                            BookId = 15,
                            AuthorId = 6,
                            AuthorName = "Name 6",
                            Name = "Interesting book 15"
                        },
                        new
                        {
                            BookId = 16,
                            AuthorId = 7,
                            AuthorName = "Name 7",
                            Name = "Interesting book 16"
                        },
                        new
                        {
                            BookId = 17,
                            AuthorId = 8,
                            AuthorName = "Name 8",
                            Name = "Interesting book 17"
                        },
                        new
                        {
                            BookId = 18,
                            AuthorId = 9,
                            AuthorName = "Name 9",
                            Name = "Interesting book 18"
                        },
                        new
                        {
                            BookId = 19,
                            AuthorId = 10,
                            AuthorName = "Name 10",
                            Name = "Interesting book 19"
                        },
                        new
                        {
                            BookId = 20,
                            AuthorId = 1,
                            AuthorName = "Name 1",
                            Name = "Interesting book 20"
                        },
                        new
                        {
                            BookId = 21,
                            AuthorId = 2,
                            AuthorName = "Name 2",
                            Name = "Interesting book 21"
                        },
                        new
                        {
                            BookId = 22,
                            AuthorId = 3,
                            AuthorName = "Name 3",
                            Name = "Interesting book 22"
                        },
                        new
                        {
                            BookId = 23,
                            AuthorId = 4,
                            AuthorName = "Name 4",
                            Name = "Interesting book 23"
                        },
                        new
                        {
                            BookId = 24,
                            AuthorId = 5,
                            AuthorName = "Name 5",
                            Name = "Interesting book 24"
                        },
                        new
                        {
                            BookId = 25,
                            AuthorId = 6,
                            AuthorName = "Name 6",
                            Name = "Interesting book 25"
                        },
                        new
                        {
                            BookId = 26,
                            AuthorId = 7,
                            AuthorName = "Name 7",
                            Name = "Interesting book 26"
                        },
                        new
                        {
                            BookId = 27,
                            AuthorId = 8,
                            AuthorName = "Name 8",
                            Name = "Interesting book 27"
                        },
                        new
                        {
                            BookId = 28,
                            AuthorId = 9,
                            AuthorName = "Name 9",
                            Name = "Interesting book 28"
                        },
                        new
                        {
                            BookId = 29,
                            AuthorId = 10,
                            AuthorName = "Name 10",
                            Name = "Interesting book 29"
                        },
                        new
                        {
                            BookId = 30,
                            AuthorId = 1,
                            AuthorName = "Name 1",
                            Name = "Interesting book 30"
                        },
                        new
                        {
                            BookId = 31,
                            AuthorId = 2,
                            AuthorName = "Name 2",
                            Name = "Interesting book 31"
                        },
                        new
                        {
                            BookId = 32,
                            AuthorId = 3,
                            AuthorName = "Name 3",
                            Name = "Interesting book 32"
                        },
                        new
                        {
                            BookId = 33,
                            AuthorId = 4,
                            AuthorName = "Name 4",
                            Name = "Interesting book 33"
                        },
                        new
                        {
                            BookId = 34,
                            AuthorId = 5,
                            AuthorName = "Name 5",
                            Name = "Interesting book 34"
                        },
                        new
                        {
                            BookId = 35,
                            AuthorId = 6,
                            AuthorName = "Name 6",
                            Name = "Interesting book 35"
                        },
                        new
                        {
                            BookId = 36,
                            AuthorId = 7,
                            AuthorName = "Name 7",
                            Name = "Interesting book 36"
                        },
                        new
                        {
                            BookId = 37,
                            AuthorId = 8,
                            AuthorName = "Name 8",
                            Name = "Interesting book 37"
                        },
                        new
                        {
                            BookId = 38,
                            AuthorId = 9,
                            AuthorName = "Name 9",
                            Name = "Interesting book 38"
                        },
                        new
                        {
                            BookId = 39,
                            AuthorId = 10,
                            AuthorName = "Name 10",
                            Name = "Interesting book 39"
                        },
                        new
                        {
                            BookId = 40,
                            AuthorId = 1,
                            AuthorName = "Name 1",
                            Name = "Interesting book 40"
                        },
                        new
                        {
                            BookId = 41,
                            AuthorId = 2,
                            AuthorName = "Name 2",
                            Name = "Interesting book 41"
                        },
                        new
                        {
                            BookId = 42,
                            AuthorId = 3,
                            AuthorName = "Name 3",
                            Name = "Interesting book 42"
                        },
                        new
                        {
                            BookId = 43,
                            AuthorId = 4,
                            AuthorName = "Name 4",
                            Name = "Interesting book 43"
                        },
                        new
                        {
                            BookId = 44,
                            AuthorId = 5,
                            AuthorName = "Name 5",
                            Name = "Interesting book 44"
                        },
                        new
                        {
                            BookId = 45,
                            AuthorId = 6,
                            AuthorName = "Name 6",
                            Name = "Interesting book 45"
                        },
                        new
                        {
                            BookId = 46,
                            AuthorId = 7,
                            AuthorName = "Name 7",
                            Name = "Interesting book 46"
                        },
                        new
                        {
                            BookId = 47,
                            AuthorId = 8,
                            AuthorName = "Name 8",
                            Name = "Interesting book 47"
                        },
                        new
                        {
                            BookId = 48,
                            AuthorId = 9,
                            AuthorName = "Name 9",
                            Name = "Interesting book 48"
                        },
                        new
                        {
                            BookId = 49,
                            AuthorId = 10,
                            AuthorName = "Name 10",
                            Name = "Interesting book 49"
                        },
                        new
                        {
                            BookId = 50,
                            AuthorId = 1,
                            AuthorName = "Name 1",
                            Name = "Interesting book 50"
                        },
                        new
                        {
                            BookId = 51,
                            AuthorId = 2,
                            AuthorName = "Name 2",
                            Name = "Interesting book 51"
                        },
                        new
                        {
                            BookId = 52,
                            AuthorId = 3,
                            AuthorName = "Name 3",
                            Name = "Interesting book 52"
                        },
                        new
                        {
                            BookId = 53,
                            AuthorId = 4,
                            AuthorName = "Name 4",
                            Name = "Interesting book 53"
                        },
                        new
                        {
                            BookId = 54,
                            AuthorId = 5,
                            AuthorName = "Name 5",
                            Name = "Interesting book 54"
                        },
                        new
                        {
                            BookId = 55,
                            AuthorId = 6,
                            AuthorName = "Name 6",
                            Name = "Interesting book 55"
                        },
                        new
                        {
                            BookId = 56,
                            AuthorId = 7,
                            AuthorName = "Name 7",
                            Name = "Interesting book 56"
                        },
                        new
                        {
                            BookId = 57,
                            AuthorId = 8,
                            AuthorName = "Name 8",
                            Name = "Interesting book 57"
                        },
                        new
                        {
                            BookId = 58,
                            AuthorId = 9,
                            AuthorName = "Name 9",
                            Name = "Interesting book 58"
                        },
                        new
                        {
                            BookId = 59,
                            AuthorId = 10,
                            AuthorName = "Name 10",
                            Name = "Interesting book 59"
                        },
                        new
                        {
                            BookId = 60,
                            AuthorId = 1,
                            AuthorName = "Name 1",
                            Name = "Interesting book 60"
                        },
                        new
                        {
                            BookId = 61,
                            AuthorId = 2,
                            AuthorName = "Name 2",
                            Name = "Interesting book 61"
                        },
                        new
                        {
                            BookId = 62,
                            AuthorId = 3,
                            AuthorName = "Name 3",
                            Name = "Interesting book 62"
                        },
                        new
                        {
                            BookId = 63,
                            AuthorId = 4,
                            AuthorName = "Name 4",
                            Name = "Interesting book 63"
                        },
                        new
                        {
                            BookId = 64,
                            AuthorId = 5,
                            AuthorName = "Name 5",
                            Name = "Interesting book 64"
                        },
                        new
                        {
                            BookId = 65,
                            AuthorId = 6,
                            AuthorName = "Name 6",
                            Name = "Interesting book 65"
                        },
                        new
                        {
                            BookId = 66,
                            AuthorId = 7,
                            AuthorName = "Name 7",
                            Name = "Interesting book 66"
                        },
                        new
                        {
                            BookId = 67,
                            AuthorId = 8,
                            AuthorName = "Name 8",
                            Name = "Interesting book 67"
                        },
                        new
                        {
                            BookId = 68,
                            AuthorId = 9,
                            AuthorName = "Name 9",
                            Name = "Interesting book 68"
                        },
                        new
                        {
                            BookId = 69,
                            AuthorId = 10,
                            AuthorName = "Name 10",
                            Name = "Interesting book 69"
                        },
                        new
                        {
                            BookId = 70,
                            AuthorId = 1,
                            AuthorName = "Name 1",
                            Name = "Interesting book 70"
                        },
                        new
                        {
                            BookId = 71,
                            AuthorId = 2,
                            AuthorName = "Name 2",
                            Name = "Interesting book 71"
                        },
                        new
                        {
                            BookId = 72,
                            AuthorId = 3,
                            AuthorName = "Name 3",
                            Name = "Interesting book 72"
                        },
                        new
                        {
                            BookId = 73,
                            AuthorId = 4,
                            AuthorName = "Name 4",
                            Name = "Interesting book 73"
                        },
                        new
                        {
                            BookId = 74,
                            AuthorId = 5,
                            AuthorName = "Name 5",
                            Name = "Interesting book 74"
                        },
                        new
                        {
                            BookId = 75,
                            AuthorId = 6,
                            AuthorName = "Name 6",
                            Name = "Interesting book 75"
                        },
                        new
                        {
                            BookId = 76,
                            AuthorId = 7,
                            AuthorName = "Name 7",
                            Name = "Interesting book 76"
                        },
                        new
                        {
                            BookId = 77,
                            AuthorId = 8,
                            AuthorName = "Name 8",
                            Name = "Interesting book 77"
                        },
                        new
                        {
                            BookId = 78,
                            AuthorId = 9,
                            AuthorName = "Name 9",
                            Name = "Interesting book 78"
                        },
                        new
                        {
                            BookId = 79,
                            AuthorId = 10,
                            AuthorName = "Name 10",
                            Name = "Interesting book 79"
                        },
                        new
                        {
                            BookId = 80,
                            AuthorId = 1,
                            AuthorName = "Name 1",
                            Name = "Interesting book 80"
                        },
                        new
                        {
                            BookId = 81,
                            AuthorId = 2,
                            AuthorName = "Name 2",
                            Name = "Interesting book 81"
                        },
                        new
                        {
                            BookId = 82,
                            AuthorId = 3,
                            AuthorName = "Name 3",
                            Name = "Interesting book 82"
                        },
                        new
                        {
                            BookId = 83,
                            AuthorId = 4,
                            AuthorName = "Name 4",
                            Name = "Interesting book 83"
                        },
                        new
                        {
                            BookId = 84,
                            AuthorId = 5,
                            AuthorName = "Name 5",
                            Name = "Interesting book 84"
                        },
                        new
                        {
                            BookId = 85,
                            AuthorId = 6,
                            AuthorName = "Name 6",
                            Name = "Interesting book 85"
                        },
                        new
                        {
                            BookId = 86,
                            AuthorId = 7,
                            AuthorName = "Name 7",
                            Name = "Interesting book 86"
                        },
                        new
                        {
                            BookId = 87,
                            AuthorId = 8,
                            AuthorName = "Name 8",
                            Name = "Interesting book 87"
                        },
                        new
                        {
                            BookId = 88,
                            AuthorId = 9,
                            AuthorName = "Name 9",
                            Name = "Interesting book 88"
                        },
                        new
                        {
                            BookId = 89,
                            AuthorId = 10,
                            AuthorName = "Name 10",
                            Name = "Interesting book 89"
                        },
                        new
                        {
                            BookId = 90,
                            AuthorId = 1,
                            AuthorName = "Name 1",
                            Name = "Interesting book 90"
                        },
                        new
                        {
                            BookId = 91,
                            AuthorId = 2,
                            AuthorName = "Name 2",
                            Name = "Interesting book 91"
                        },
                        new
                        {
                            BookId = 92,
                            AuthorId = 3,
                            AuthorName = "Name 3",
                            Name = "Interesting book 92"
                        },
                        new
                        {
                            BookId = 93,
                            AuthorId = 4,
                            AuthorName = "Name 4",
                            Name = "Interesting book 93"
                        },
                        new
                        {
                            BookId = 94,
                            AuthorId = 5,
                            AuthorName = "Name 5",
                            Name = "Interesting book 94"
                        },
                        new
                        {
                            BookId = 95,
                            AuthorId = 6,
                            AuthorName = "Name 6",
                            Name = "Interesting book 95"
                        },
                        new
                        {
                            BookId = 96,
                            AuthorId = 7,
                            AuthorName = "Name 7",
                            Name = "Interesting book 96"
                        },
                        new
                        {
                            BookId = 97,
                            AuthorId = 8,
                            AuthorName = "Name 8",
                            Name = "Interesting book 97"
                        },
                        new
                        {
                            BookId = 98,
                            AuthorId = 9,
                            AuthorName = "Name 9",
                            Name = "Interesting book 98"
                        },
                        new
                        {
                            BookId = 99,
                            AuthorId = 10,
                            AuthorName = "Name 10",
                            Name = "Interesting book 99"
                        },
                        new
                        {
                            BookId = 100,
                            AuthorId = 1,
                            AuthorName = "Name 1",
                            Name = "Interesting book 100"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}