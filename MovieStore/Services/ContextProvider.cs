using Microsoft.EntityFrameworkCore;
using MovieStore.Data;
using MovieStore.Data.Models;
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

        public async Task<List<Movie>> GetMovies()
        {
            var movies = await _context.Movies.ToListAsync();

            return movies;
        }

        public async void AddMovie(Movie movie)
        {
            _context.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task<List<string>> GetDistincGenres()
        {
            var movies = await _context.Movies.ToListAsync();
            var genres = movies.Select(_ => _.Genre).Distinct().ToList();
            genres.Sort();

            return genres;
        }

        public async Task<List<Movie>> SearchMovieByTitle(string searchString)
        {
            List<Movie> movies = await _context.Movies.Where(_ => _.Title.ToUpper().Contains(searchString.ToUpper())).ToListAsync();

            return movies;
        }

        public async Task<List<Movie>> SearchMovieByGenre(string searchString)
        {
            List<Movie> movies = await _context.Movies.Where(_ => _.Genre == searchString).ToListAsync();

            return movies;
        }
    }
}
