using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MySQL_Movie_Database
{
    public partial class remove : Form
    {
        public remove()
        {
            InitializeComponent();
        }

        private void remove_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //the program will end if this form is closed
        }

        // Handles the "Remove" button click event to search and delete a movie from the list.
        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string movieName = textBox2.Text;
                if (string.IsNullOrEmpty(movieName))
                {
                    sub2.Text = "Make sure you enter the name of the movie!";
                    return;
                }

                List<Movie> movies = Database.Instance.Movies;
                Movie movieToRemove = null;

                // Loop through each movie and find the one matching the name
                foreach (Movie film in movies)
                {
                    if (film.name.ToLower().Equals(movieName.ToLower()))
                    {
                        movieToRemove = film;
                        break;
                    }
                }

                if (movieToRemove != null)
                {
                    // Remove the found movie from the database
                    Database.Instance.DeleteMovie(movieToRemove);
                    sub2.Text = "The movie was removed from the list.";
                }
                else
                    sub2.Text = "That movie was not found...";
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur and display an error message
                sub2.Text = "Error: " + ex.Message;
            }
            Database.Instance.RefreshMovieList();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //hiding this form and opening form1
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }
    }
}
