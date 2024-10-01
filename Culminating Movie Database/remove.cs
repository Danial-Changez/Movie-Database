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

        private void removeBtn_Click(object sender, EventArgs e)
        {
            List<Movie> movies = new List<Movie>(); //creating the list that will store each movie

            try //the following code will be executed
            {
                //storing each line in the Movies.txt file into the fileInfo list
                List<String> fileInfo = File.ReadAllLines(@"C:\Users\dania\source\repos\Culminating Movie Database\Movies.txt").Skip(3).ToList();
                String[] movieInfo = new String[5]; //array used to store each movie's info
                bool removed = false; //boolean used to check if the movie was removed or not

                //removing empty lines from the fileInfo list
                foreach (string line in fileInfo.ToList())
                    if (string.IsNullOrEmpty(line))
                        fileInfo.Remove(line);

                foreach (string line in fileInfo) //this will loop through each line in the fileInfo list
                {
                    movieInfo = line.Split('\t'); //splitting each line by tabs

                    //adding a new movie into the movies list, by using the contents of the movieInfo array
                    movies.Add(new Movie(movieInfo[0], movieInfo[1], movieInfo[2], movieInfo[3], Convert.ToDouble(movieInfo[4])));
                }

                if (String.IsNullOrEmpty(textBox2.Text) == false) //this code will only run if textBox2 is not empty
                {
                    foreach (Movie film in movies) //this will loop through each movie in the movies list
                    {
                        if (film.name == textBox2.Text) //this code will execute if the movie name is equal to the name the user inputted
                        {
                            movies.Remove(film); //removing the movie from movies list
                            removed = true; //setting removed equal to true
                            break; //breaking out of the loop
                        }
                    }
                }

                else //if textBox2 is empty the following message will be displayed
                    sub2.Text = "Make sure you enter the name of the movie!";

                if (removed == true) //if removed equals true the following code will be executed
                {
                    //writing the following text to the Movies.txt file
                    File.WriteAllText(@"C:\Users\dania\source\repos\Culminating Movie Database\Movies.txt", "Movie Info:" +
                    "\n\nName    Release Date        Genre           Fav.Character   Rating(Out Of 5)");

                    foreach (Movie film in movies) //this will loop through each movie in movies list
                    {
                        //writing the text in the movie to the Movies.txt file
                        File.AppendAllText(@"C:\Users\dania\source\repos\Culminating Movie Database\Movies.txt", film.toString());
                    }

                    sub2.Text = "The movie was removed from the list.";
                }

                else if (removed == false) //if removed is false the following message will be displayed
                    sub2.Text = "That movie was not found...";
            }

            catch (FileNotFoundException) //if the FileNotFoundException is caught the following message will be displayed
            {
                sub2.Text = "The file was not found, make sure that the file path is correct...";
            }

            catch (DirectoryNotFoundException) //if the DirectoryNotFoundException is caught the following message will be displayed
            {
                sub2.Text = "The file was not found, make sure that the file path is correct...";
            }

            catch (FormatException) //if the FormatException is caught the following message will be displayed
            {
                sub2.Text = "A format error has occurred.";
            }

            catch (IndexOutOfRangeException) //if the IndexOutOfRangeException is caught the following message will be displayed
            {
                sub2.Text = "An error has occured with the text file.";
            }
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
