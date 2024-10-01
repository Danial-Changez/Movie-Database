using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary;

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
            Application.Exit(); //this program will end if this form is closed
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //opening form1 and closing this form
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            List<Movie> movies = new List<Movie>(); //creating the list that will store the movies
            bool error = false; //creating the boolean that will check if an error has occured

            String n = nameTextBox.Text.ToLower(); //changing the text in nameTextBox to lower case and storing it in the n string

            try
            { //the following block of code will execute

                //if the number in rateTextBox is greater than 5 the following code will execute
                if (Convert.ToDouble(rateTextBox.Text) > 5)
                {
                    sub.Text = "The rating must be out of 5!";
                    error = true; //setting error equal to true
                }

                if (error == false) //if error equals false the following code will execute
                {

                    //creating a new Movie object with the values the user inputted into the textboxes
                    Movie addMovie = new Movie(n, dateTimePicker1.Text, genreTextBox.Text, favCharTextBox.Text, Convert.ToDouble(rateTextBox.Text));

                    movies.Add(addMovie); //adding the movie into the movies list

                    foreach (Movie film in movies) //this code will loop through each item in the movies list
                    {
                        //writing the text in the item to the Movies.txt file
                        System.IO.File.AppendAllText(@"C:\Users\dania\source\repos\Culminating Movie Database\Movies.txt", film.toString());
                    }
                }
            }

            catch (FormatException) //if the FormatException is caught the following will happen
            {
                sub.Text = "Make sure that all the textboxes are filled in correctly!";
                error = true; //setting error equal to true
            }

            catch (FileNotFoundException) //if the FileNotFoundException is caught the following will happen
            {
                sub.Text = "The file was not found, make sure that the file path is correct...";
                error = true; //setting error equal to true
            }

            catch (DirectoryNotFoundException) //if the DirectoryNotFoundException is caught the following will happen
            {
                sub.Text = "The file was not found, make sure that the file path is correct...";
                error = true; //setting error equal to true
            }

            //if any of the textBoxes were left empty the following code will execute
            if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(genreTextBox.Text) || String.IsNullOrEmpty(favCharTextBox.Text) || String.IsNullOrEmpty(rateTextBox.Text))
            {
                sub.Text = "Make sure that all the textboxes are filled in correctly!";
                error = true; //setting error equal to true
            }

            if (error == false) //if error is equal to false the following message will be displayed
                sub.Text = "The movie was added to your list.";

            nameTextBox.Clear(); genreTextBox.Clear(); favCharTextBox.Clear(); rateTextBox.Clear(); //clearing the textboxes
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Load(object sender, EventArgs e)
        {

        }
    }
}
