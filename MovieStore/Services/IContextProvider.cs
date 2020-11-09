using MovieStore.Data;
using MovieStore.Data.Models;
using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services
{
    public interface IContextProvider
    {
        
        public void AddMovie(Movie movie);

        public List<string> GetDistincGenres();

        public List<MoviesViewModel> SearchMovieByTitle(string searchString);
        public List<MoviesViewModel> SearchMovieByGenre(string searchString);

        public List<MoviesViewModel> GetMovies();

        public Movie GetMovie(int movieId);

        public MoviesViewModel CheckoutMovie(int movieId, string userName);
        
    }
}
