using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Movie
    {
        //initializing the object variables
        public String name;
        public String relDate;
        public String genre;
        public String favChar;
        public double rating;

        //class constructor that takes 4 strings and a double
        public Movie(String n, String rD, String gen, String fC, double rate)
        {
            name = n;
            relDate = rD;
            genre = gen;
            favChar = fC;
            rating = rate;
        }

        //toString function that will return each variable of the object stored in a string
        public String toString()
        {
            return "\n" + this.name + "\t" + this.relDate + "\t  " +
            this.genre + "\t   " + this.favChar + "\t" + this.rating;
        }
    }
}
