using CinemaApp.Models;
using CinemaApp.Repositories.Interfaces;
using CinemaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(movieRepository.GetAllMovies());
        }

        public IActionResult Details(int id)
        {
            var movie = movieRepository.GetMovie(id);

            if (movie != null)
            {
                return View(movie);
            }

            return View("doesNotExist");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MovieViewModel movieVM)
        {
            if (ModelState.IsValid)
            {
                var newMovie = new Movie
                {
                    Title = movieVM.Title,
                    Director = movieVM.Director,
                    Genre = movieVM.Genre,
                    Description = movieVM.Description,
                    Showtime = DateTime.Now,
                };
                movieRepository.Add(newMovie);
                return RedirectToAction("Index");
            }

            return View("Create", movieVM);
        }

        public IActionResult Edit(int id)
        {
            return View(movieRepository.GetMovie(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Movie movie)
        {
            if (ModelState.IsValid)
            {
                movieRepository.Edit(movie);
            }

            return RedirectToAction("Index");
        }

        //public IActionResult Delete(int id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    var movie = movieRepository.GetMovie(id);

        //    if (movie == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(movie);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    var movie = movieRepository.GetMovie(id);

        //    if (movie == null)
        //    {
        //        return NotFound();
        //    }

        //    movieRepository.Delete(id);

        //    return RedirectToAction("Index");
        //}

        public IActionResult Delete(int id)
        {
            var movie = movieRepository.GetMovie(id);

            if (movie != null)
            {
                return View(movie);
            }

            return View("doesNotExists");
        }

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var movie = movieRepository.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }

            movieRepository.Delete(id);

            return RedirectToAction("Index");
        }
    }
}