using MovieStore.Data;
using MovieStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services
{
    public interface IContextProvider
    {
        public Task<List<Movie>> GetMovies();

        public void AddMovie(Movie movie);

        public Task<List<string>> GetDistincGenres();

        public Task<List<Movie>> SearchMovieByTitle(string searchString);
        public Task<List<Movie>> SearchMovieByGenre(string searchString);


       
    }
}
