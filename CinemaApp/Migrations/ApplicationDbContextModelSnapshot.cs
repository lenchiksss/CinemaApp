﻿// <auto-generated />
using System;
using CinemaApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CinemaApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CinemaApp.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Showtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "\"Blade Runner 2049\" is a sci-fi sequel directed by Denis Villeneuve, exploring a dystopian future where a police officer uncovers a long-buried secret that could change society. It delves into themes of identity and the blurred line between human and artificial.",
                            Director = "Denis Villeneuve",
                            Genre = "SciFi",
                            Showtime = new DateTime(2023, 10, 26, 0, 48, 4, 713, DateTimeKind.Local).AddTicks(3),
                            Title = "Blade Runner 2049"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The movie features Dwayne Johnson as a former FBI hostage rescue team leader, who now assesses security for skyscrapers. When the tallest and safest building in the world suddenly catches fire, he finds himself framed for the catastrophe and must clear his name, rescue his family from the building's top floor, and take down the criminals responsible.",
                            Director = "Rawson Marshall Thurber",
                            Genre = "Action",
                            Showtime = new DateTime(2023, 10, 26, 0, 48, 4, 713, DateTimeKind.Local).AddTicks(174),
                            Title = "Skyscraper"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
