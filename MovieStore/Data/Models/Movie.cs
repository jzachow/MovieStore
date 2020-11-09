using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MovieStore.Data.Models
{
    public class Movie
    {
        public Movie()
        {
            ActorMovies = new HashSet<ActorMovie>();
            DirectorMovies = new HashSet<DirectorMovie>();
        }

        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public double Runtime { get; set; }
       

        public List<Actor> Actors{ get; set; }
        public ICollection<ActorMovie> ActorMovies { get; set; }

        public List<Director> Directors { get; set; }
        public ICollection<DirectorMovie> DirectorMovies { get; set; }


    }
}
