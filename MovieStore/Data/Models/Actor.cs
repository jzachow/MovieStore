using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Data.Models
{
    public class Actor
    {

        public Actor()
        {
            ActorMovies = new HashSet<ActorMovie>();
        }
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public ICollection<ActorMovie> ActorMovies { get; set; }

    }
}
