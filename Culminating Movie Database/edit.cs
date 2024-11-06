using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Culminating_Movie_Database
{
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }

        private void edit_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Program exits when the form is closed
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog(); // Opens Form1 and closes this one
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string key = nameTextBox.Text;
            bool error = false;

            // If any textboxes are empty, show an error message
            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(genreTextBox.Text) || string.IsNullOrEmpty(favCharTextBox.Text) || string.IsNullOrEmpty(rateTextBox.Text))
            {
                subUpdate.Text = "Make sure that all the textboxes are filled in correctly!";
                error = true;
                return;
            }

            try
            {
                // Validate rating (must be <= 10)
                if (!double.TryParse(rateTextBox.Text, out double rating))
                {
                    subUpdate.Text = "Invalid rating!";
                    error = true;
                }
                else if (rating > 10)
                {
                    subUpdate.Text = "The rating must be out of 10!";
                    error = true;
                }

                if (!error)
                {
                    // Retrieve list of movies from Database
                    List<Movie> movies = Database.Instance.Movies;

                    // Find the movie to edit by its name using SearchMovies method (if using SearchMovies)
                    string searchMessage = Database.Instance.SearchMovies(key);
                    if (searchMessage.Contains("exists"))
                    {
                        // Find the movie to edit by its name
                        Movie movie = movies.FirstOrDefault(m => m.name.ToLower() == key.ToLower());

                        if (movie != null)
                        {
                            // Update the movie details
                            movie.name = key;
                            movie.relDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                            movie.genre = genreTextBox.Text;
                            movie.favChar = favCharTextBox.Text;
                            movie.rating = rating;

                            // Update the database with the modified movie
                            string updateResult = Database.Instance.UpdateMovie(movie);
                            subUpdate.Text = updateResult;
                        }
                    }
                    else
                        subUpdate.Text = "Movie not found!";
                }
            }
            catch (Exception ex)
            {
                subUpdate.Text = "Error: " + ex.Message;
                error = true;
            }


            // If no errors, show a success message
            //if (!error)
            //    subUpdate.Text = "The movie's info was edited."; // Success message

            // Clear the textboxes after editing
            nameTextBox.Clear();
            genreTextBox.Clear();
            favCharTextBox.Clear();
            rateTextBox.Clear();

            Database.Instance.RefreshMovieList();
        }
    }
}