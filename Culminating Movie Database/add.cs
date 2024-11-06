using ClassLibrary;
using System;
using System.Windows.Forms;

namespace Culminating_Movie_Database
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void add_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // This program will end if this form is closed
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            // Opening form1 and closing this form
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text; // Get name
            string genre = genreTextBox.Text; // Get genre
            string favChar = favCharTextBox.Text; // Get favorite character
            double rating;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(genre) || string.IsNullOrEmpty(favChar) || string.IsNullOrEmpty(rateTextBox.Text))
            {
                sub.Text = "Make sure that all the textboxes are filled in correctly!";
                return;
            }

            try
            {
                rating = Convert.ToDouble(rateTextBox.Text);

                if (rating > 10)
                {
                    sub.Text = "The rating must be out of 5!";
                    return;
                }

                // Create new Movie object
                Movie addMovie = new Movie(name, dateTimePicker1.Value.ToString("yyyy-MM-dd"), genre, favChar, rating);

                // Insert movie into the database and get the response message
                string result = Database.Instance.InsertMovie(addMovie);

                sub.Text = result; // Show the message from the InsertMovie method
            }
            catch (FormatException)
            {
                sub.Text = "Make sure that all the textboxes are filled in correctly!";
            }
            catch (Exception ex)
            {
                sub.Text = $"An error occurred: {ex.Message}";
            }

            // Clear textboxes after submission
            nameTextBox.Clear();
            genreTextBox.Clear();
            favCharTextBox.Clear();
            rateTextBox.Clear();

            Database.Instance.RefreshMovieList();
        }
    }
}
