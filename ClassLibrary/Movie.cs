using System;

namespace ClassLibrary
{
    public class Movie
    {
        // Object properties to store movie details
        public String name { get; set; }
        public String relDate { get; set; }
        public String genre { get; set; }
        public String favChar { get; set; }
        public double rating { get; set; }

        // Constructor to initialize a Movie object with name, release date, genre, favorite character, and rating
        public Movie(String n, String rD, String gen, String fC, double rate)
        {
            name = n;
            relDate = rD;
            genre = gen;
            favChar = fC;
            rating = rate;
        }

        // Method to return a string representation of the movie with its details
        public String toString()
        {
            return "\n" + this.name + "\t" + this.relDate + "\t  " +
            this.genre + "\t   " + this.favChar + "\t" + this.rating;
        }
    }
}
