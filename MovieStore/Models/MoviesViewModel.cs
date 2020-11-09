using MovieStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class MoviesViewModel
    {
        public Movie Movie { get; set; }
        public CheckedOutMovies? CheckedOutMovies { get; set; }
    }
}
