using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDAT
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Director Director { get; set; }

        public List<Actor> AcceptedActors { get; set; }

        public List<Genre> Genres { get; set; } 


    }
}