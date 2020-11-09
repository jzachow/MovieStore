using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        public async Task<IActionResult> Index()
        {
            var movies = await _contextProvider.GetMovies();           

            return View(movies);
           
        }

        public IActionResult RegisterMovieForm()
        {
            return View();
        }

        public async Task<IActionResult> MovieRegistration(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _contextProvider.AddMovie(movie);
                TempData["AddedMovie"] = movie.Title;
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Search()
        {
            var genres = _contextProvider.GetDistincGenres();

            return View(genres);
        }

        public async Task<IActionResult> SearchResultTitle(string movieTitle)
        {
            var movies = _contextProvider.SearchMovieByTitle(movieTitle);

            return View(movies);
        }

        public async Task<IActionResult> SearchResultGenre(string movieGenre)
        {
            var movies = _contextProvider.SearchMovieByGenre(movieGenre);

            return View(movies);
        }

       
    }
}

   

