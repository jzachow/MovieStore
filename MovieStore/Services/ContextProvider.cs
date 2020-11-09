using Microsoft.EntityFrameworkCore;
using MovieStore.Data;
using MovieStore.Data.Models;
using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services
{
    public class ContextProvider : IContextProvider
    {
        private readonly ApplicationDbContext _context;

        public ContextProvider(ApplicationDbContext context)
        {
            _context = context;
        }
       

        public async void AddMovie(Movie movie)
        {
            _context.Add(movie);
            await _context.SaveChangesAsync();
        }

        public List<string> GetDistincGenres()
        {
            var movies =  _context.Movies.ToList();
            var genres = movies.Select(_ => _.Genre).Distinct().ToList();
            genres.Sort();

            return genres;
        }

        public List<MoviesViewModel> SearchMovieByTitle(string searchString)
        {
            var movies = GetMovies();

            List<MoviesViewModel> movieResults = movies.Where(_ => _.Movie.Title.ToUpper().Contains(searchString.ToUpper())).ToList();

            return movieResults;
        }

        public List<MoviesViewModel> SearchMovieByGenre(string searchString)
        {

            var movies = GetMovies();

            List<MoviesViewModel> movieResults =  movies.Where(_ => _.Movie.Genre == searchString).ToList();

            return movieResults;
        }

        public List<MoviesViewModel> GetMovies()
        {
          
            var movies = new List<MoviesViewModel>();
            var dbList = _context.Movies.ToList();

            foreach (var movie in dbList)
            {
                var mvm = new MoviesViewModel()
                {
                    Movie = movie                    
                };

                var checkedOut = _context.CheckedOutMovies.FirstOrDefault(i => i.MovieId == movie.MovieId);
                if (!(checkedOut == null))
                    mvm.CheckedOutMovies = checkedOut;

                movies.Add(mvm);
            }                     
            
            return movies;
        }
    }
}
