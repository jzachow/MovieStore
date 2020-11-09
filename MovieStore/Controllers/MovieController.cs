using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data;
using MovieStore.Data.Models;
using MovieStore.Services;

namespace MovieStore.Controllers
{
    [Authorize]
    public class MovieController : Controller
    {
        private readonly IContextProvider _contextProvider;

        public MovieController(IContextProvider contextProvider)
        {
            _contextProvider = contextProvider;  
            
        }

        public IActionResult Index()
        {
            var movies = _contextProvider.GetMovies();           

            return View(movies);
           
        }

        public IActionResult RegisterMovieForm()
        {
            return View();
        }

        public IActionResult MovieRegistration(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _contextProvider.AddMovie(movie);
                TempData["AddedMovie"] = movie.Title;
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Search()
        {
            var genres = _contextProvider.GetDistincGenres();

            return View(genres);
        }

        public IActionResult SearchResultTitle(string movieTitle)
        {
            var movies = _contextProvider.SearchMovieByTitle(movieTitle);

            return View(movies);
        }

        public IActionResult SearchResultGenre(string movieGenre)
        {
            var movies = _contextProvider.SearchMovieByGenre(movieGenre);

            return View(movies);
        }

        public IActionResult Checkout(int movieId)
        {
            var movie = _contextProvider.GetMovie(movieId);

            return View(movie);
        }

        public IActionResult Result(int movieId)
        {
            var userName = HttpContext.User.Identity.Name.ToString();
            var movie = _contextProvider.CheckoutMovie(movieId, userName);

            return View(movie);
        }

        public IActionResult CheckedOutMovies()
        {
            var userName = HttpContext.User.Identity.Name.ToString();
            var userMovies = _contextProvider.GetUserMovies(userName);

            return View(userMovies);
        }

        public IActionResult ReturnMovie(int movieId)
        {
            _contextProvider.ReturnMovie(movieId);
            
            return RedirectToAction("Index");
        }

            
    }
}

   

