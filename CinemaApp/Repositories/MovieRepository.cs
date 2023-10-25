using CinemaApp.Data;
using CinemaApp.Models;
using CinemaApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Movie> GetAllMovies()
        {
            return _context.Movies.AsNoTracking().ToList();
        }

        public Movie GetMovie(int id)
        {
            return _context.Movies
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == id);
        }

        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public Movie Edit(Movie movie)
        {
            var existingMovie = _context.Movies.FirstOrDefault(p => p.Id == movie.Id);

            if (existingMovie != null)
            {
                existingMovie.Title = movie.Title;
                existingMovie.Director = movie.Director;
                existingMovie.Genre = movie.Genre;
                existingMovie.Description = movie.Description;
                existingMovie.Showtime = movie.Showtime;
                _context.SaveChanges();
            }

            return existingMovie;
        }

        public void Delete(int id)
        {
            var existingMovie = _context.Movies.FirstOrDefault(p => p.Id == id);

            if (existingMovie != null)
            {
                _context.Movies.Remove(existingMovie);
                _context.SaveChanges();
            }
        }
    }
}