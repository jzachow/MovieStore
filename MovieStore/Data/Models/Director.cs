using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Data.Models
{
    public class Director
    {
        public Director()
        {
            DirectorMovies = new HashSet<DirectorMovie>();
        }
        public int DirectorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }     
        public ICollection<DirectorMovie> DirectorMovies{ get; set; }

    }
}
