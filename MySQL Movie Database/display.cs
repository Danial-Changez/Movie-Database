using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Culminating_Movie_Database
{
    public partial class display : Form
    {
        public display()
        {
            InitializeComponent();
        }

        // Back button logic to open Form1
        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        // Application exit when form is closed
        private void display_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Load movies into DataGridView on form load
        private void display_Load(object sender, EventArgs e)
        {
            try
            {
                // Refresh the Movies list
                Database.Instance.RefreshMovieList();

                // Access the Movies list from the Database
                List<Movie> moviesList = Database.Instance.Movies;

                // Bind the movies list to the DataGridView
                BindingList<Movie> bindingList = new BindingList<Movie>(moviesList);
                dataGridView1.DataSource = bindingList;
            }
            catch (Exception ex)
            {
                sub.Text = "Error: " + ex.Message;
            }
        }

        // Sort movies by name (ascending order)
        private void nameSort_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Instance.RefreshMovieList();
                List<Movie> moviesList = Database.Instance.Movies;

                // Sort by name in ascending order
                moviesList.Sort((Movie m1, Movie m2) => m1.name.CompareTo(m2.name));

                // Bind the sorted list to the DataGridView
                BindingList<Movie> bindingList = new BindingList<Movie>(moviesList);
                dataGridView1.DataSource = bindingList;
            }
            catch (Exception ex)
            {
                sub.Text = "Error: " + ex.Message;
            }
        }

        // Sort movies by rating (descending order)
        private void ratingSort_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Instance.RefreshMovieList();
                List<Movie> moviesList = Database.Instance.Movies;

                // Sort by rating in descending order
                moviesList.Sort((Movie m1, Movie m2) => m2.rating.CompareTo(m1.rating));

                // Bind the sorted list to the DataGridView
                BindingList<Movie> bindingList = new BindingList<Movie>(moviesList);
                dataGridView1.DataSource = bindingList;
            }
            catch (Exception ex)
            {
                sub.Text = "Error: " + ex.Message;
            }
        }
    }
}
