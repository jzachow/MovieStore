﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Data.Models
{
    public class ActorMovie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }

    }
}
