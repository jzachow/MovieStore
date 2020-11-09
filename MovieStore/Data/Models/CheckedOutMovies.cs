using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Data.Models
{
    public class CheckedOutMovies
    {
        public int CheckedOutMoviesId { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public DateTime DueDate { get; set; }
    }
}
