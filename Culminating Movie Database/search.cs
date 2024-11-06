using System;
using System.Windows.Forms;
using ClassLibrary;

namespace Culminating_Movie_Database
{
    public partial class search : Form
    {
        // This string holds the name of the movie entered by the user for future use.
        public static string searchedName = "";

        public search()
        {
            InitializeComponent();
            // Initially hide sub3, yesBtn, and noBtn.
            sub3.Visible = false;
            yesBtn.Visible = false;
            noBtn.Visible = false;
        }

        private void search_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Close the application when the form is closed.
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Get the movie name entered by the user.
            string movieName = textBox2.Text;

            // Validate that the movie name is not empty.
            if (string.IsNullOrEmpty(movieName))
            {
                sub2.Text = "Make sure you enter the name of the movie!";
                return;
            }

            // Call the SearchMovies method to search for the movie in the database.
            string result = Database.Instance.SearchMovies(movieName);

            // If the movie is found, display its info, show the buttons, and update the label.
            if (result.Contains("found"))
            {
                textBox1.Text = result;
                showButtons(true);
                sub2.Text = "The movie info has been found.";
            }
            else
            {
                // If no movie is found, clear the text box and hide the buttons.
                textBox1.Clear();
                showButtons(false);
                sub2.Text = result; // Display the result from SearchMovies (e.g., "No movie found").
            }
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            // Store the movie name in searchedName for use in the edit form.
            searchedName = textBox2.Text;

            // Hide this form and open the edit form.
            edit newForm = new edit();
            this.Hide();
            newForm.ShowDialog();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            // Prompt the user to enter the movie name again, and clear the text boxes.
            sub2.Text = "Enter the name of the movie";
            showButtons(false);

            textBox1.Clear();
            textBox2.Clear();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            // Hide this form and open the main form (Form1).
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        /* This method shows or hides buttons based on the boolean parameter passed. 
           If true, the buttons and labels are made visible, otherwise, they are hidden. */
        public void showButtons(bool x)
        {
            if (x)
            {
                sub3.Visible = true;
                yesBtn.Visible = true;
                noBtn.Visible = true;
            }
            else
            {
                sub3.Visible = false;
                yesBtn.Visible = false;
                noBtn.Visible = false;
            }
        }
    }
}
