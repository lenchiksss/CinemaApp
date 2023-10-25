using CinemaApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaApp.Data.Configuration;

public class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).ValueGeneratedOnAdd();
        builder.Property(u => u.Title).HasColumnType("VARCHAR(100)").IsRequired();
        builder.Property(u => u.Director).HasColumnType("VARCHAR(50)").IsRequired();
        builder.Property(u => u.Genre).HasColumnType("VARCHAR(50)").IsRequired();
        builder.Property(u => u.Description).HasColumnType("VARCHAR(500)").IsRequired();
        builder.Property(u => u.Showtime).HasColumnType("DATETIME").IsRequired();
    }
}