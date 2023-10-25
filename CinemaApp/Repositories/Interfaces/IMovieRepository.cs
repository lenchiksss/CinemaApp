using CinemaApp.Models;

namespace CinemaApp.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();

        Movie GetMovie(int id);

        void Add(Movie movie);

        Movie Edit(Movie movie);

        void Delete(int id);
    }
}