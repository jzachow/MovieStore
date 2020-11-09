using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
       

        public void AddMovie(Movie movie)
        {
            _context.Add(movie);
             _context.SaveChanges();
        }

        public List<string> GetDistinctGenres()
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

        public Movie GetMovie(int movieId)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.MovieId == movieId);            

            return movie;
        }

        public MoviesViewModel CheckoutMovie(int movieId, string userName)
        {
            var movie = GetMovie(movieId);
            var user = _context.Users.FirstOrDefault(u => u.UserName == userName);

            var com = new CheckedOutMovies()
            {
                User = user,
                UserId = user.Id,
                Movie = movie,
                MovieId = movieId,
                DueDate = DateTime.Now.AddDays(4)
            };

            _context.Add(com);
            _context.SaveChanges();

            var mvm = new MoviesViewModel()
            {
                Movie = movie,
                CheckedOutMovies = com
            };

            return mvm;
        }

        public List<MoviesViewModel> GetUserMovies(string userName)
        {
            var userMovies = new List<MoviesViewModel>();           

            var user = _context.Users.FirstOrDefault(u => u.UserName == userName);
            var com = _context.CheckedOutMovies.Where(u => u.UserId == user.Id).ToList();            

            foreach (var item in com)
            {
                var movie = _context.Movies.FirstOrDefault(m => m.MovieId == item.MovieId);
                var userMovie = new MoviesViewModel()
                {
                    CheckedOutMovies = item,
                    Movie = movie
                };
            userMovies.Add(userMovie);
            }

            return userMovies;
        }

        public void ReturnMovie(int movieId)
        {
            var movie = _context.CheckedOutMovies.FirstOrDefault(m => m.MovieId == movieId);

            _context.Remove(movie);
            _context.SaveChanges();
        }
    }
}
