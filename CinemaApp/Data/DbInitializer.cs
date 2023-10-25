using CinemaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Data;

public class DbInitializer
{
    private readonly ModelBuilder _modelBuilder;

    public DbInitializer(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        _modelBuilder.Entity<Movie>(x =>
        {
            x.HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Blade Runner 2049",
                    Director = "Denis Villeneuve",
                    Genre = "SciFi",
                    Description = "\"Blade Runner 2049\" is a sci-fi sequel directed by Denis Villeneuve, exploring a dystopian future where a police officer uncovers a long-buried secret that could change society. It delves into themes of identity and the blurred line between human and artificial.",
                    Showtime = DateTime.Now,
                });
            x.HasData(
                new Movie
                {
                    Id = 2,
                    Title = "Skyscraper",
                    Director = "Rawson Marshall Thurber",
                    Genre = "Action",
                    Description ="The movie features Dwayne Johnson as a former FBI hostage rescue team leader, who now assesses security for skyscrapers. When the tallest and safest building in the world suddenly catches fire, he finds himself framed for the catastrophe and must clear his name, rescue his family from the building's top floor, and take down the criminals responsible.",
                    Showtime = DateTime.Now,
                });
        });
    }
}