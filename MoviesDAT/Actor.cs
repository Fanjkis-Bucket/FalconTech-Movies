using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDAT
{
    public class Actor : Person
    {
        public Actor(int id, string firstName, string lastName, string address) : base(id, firstName, lastName, address) { }
    }
}
