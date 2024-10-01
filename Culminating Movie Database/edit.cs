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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }

        private void edit_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //the program will end if this form is closed
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //opening form1 and closing this form
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            String n = nameTextBox.Text.ToLower(); //changing the text in nameTextBox to lower case and storing it in the n string

            List<Movie> movies = new List<Movie>(); //creating the list that will store the movies
            String[] movieInfo = new String[5]; //array used to store each movie's info
            int index = 0; //integer that will store the index of the movie the user wants to edit
            bool error = false; //boolean used to check if an error has occured

            try //the following block of code will be executed
            {
                //if the number in rateTextBox is greater than 5 the following code will execute
                if (Convert.ToDouble(rateTextBox.Text) > 5)
                {
                    sub.Text = "The rating must be out of 5!";
                    error = true; //setting error equal to true
                }

                //storing each line in the Movies.txt file into the fileInfo list, first three lines will be skipped
                List<String> fileInfo = File.ReadAllLines(@"C:\Users\dania\source\repos\Culminating Movie Database\Movies.txt").Skip(3).ToList();

                //removing empty lines from the fileInfo list
                foreach (String line in fileInfo.ToList())
                    if (String.IsNullOrEmpty(line))
                        fileInfo.Remove(line);

                foreach (string line in fileInfo) //this code will loop through each line in the fileInfo list
                {
                    movieInfo = line.Split('\t'); //splitting the line by tabs and storing it in the movieInfo array

                    //adding a new movie into the movies list, by using the contents of the movieInfo array
                    movies.Add(new Movie(movieInfo[0], movieInfo[1], movieInfo[2], movieInfo[3], Convert.ToDouble(movieInfo[4])));
                }

                if (error == false) //if error equals false the following code will execute
                {
                    foreach (Movie movie in movies) //this will loop through each movie in the movies list
                    {
                        //if the movie name is the same as the name the user searched for in the search form, then the following will happen
                        if (movie.name.Equals(search.searchedName))
                        {
                            index = movies.IndexOf(movie); //storing the index of the movie

                            //changing each propety of the movie to the variables inputted by the user
                            movie.name = n; movie.relDate = dateTimePicker1.Text;
                            movie.genre = genreTextBox.Text; movie.favChar = favCharTextBox.Text;
                            movie.rating = Convert.ToDouble(rateTextBox.Text);
                            fileInfo[index] = movie.toString(); //the item located at fileInfo[index] will equal movie.toString()

                            //writing the following text to the Movies.txt file
                            File.WriteAllText(@"C:\Users\dania\source\repos\Culminating Movie Database\Movies.txt", "Movie Info:" +
                            "\n\n" + "Name    Release Date        Genre           Fav.Character   Rating(Out Of 5)");

                            //writing each line in the fileInfo list to the Movies.txt file
                            foreach (String line in fileInfo)
                                File.AppendAllText(@"C:\Users\dania\source\repos\Culminating Movie Database\Movies.txt", "\n" + line);

                            break; //breaking out of the loop
                        }
                    }
                }
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

            catch (FormatException) //if the ForamatException is caught the following will happen
            {
                sub.Text = "Make sure everything is filled in correctly!";
                error = true; //setting error equal to true
            }

            //if any of the textBoxes were left empty the following code will execute
            if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(genreTextBox.Text) || String.IsNullOrEmpty(favCharTextBox.Text) || String.IsNullOrEmpty(rateTextBox.Text))
            {
                sub.Text = "Make sure that all the textboxes are filled in correctly!";
                error = true; //setting error equal to true
            }

            if (error == false) //if error equals false the following code will execute
            {
                sub.Text = "The movie's info was edited.";
            }

            nameTextBox.Clear(); genreTextBox.Clear(); favCharTextBox.Clear(); rateTextBox.Clear(); //clearing the textBoxes

        }

        private void relDateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
