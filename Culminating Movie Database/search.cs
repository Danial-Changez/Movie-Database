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
    public partial class search : Form
    {
        public static String searchedName = ""; //creating the String that will store the movie name that the user inputted

        //sub3, yesBtn, and noBtn are made invisible at the start of the program.
        public search()
        {
            InitializeComponent();
            sub3.Visible = false;
            yesBtn.Visible = false;
            noBtn.Visible = false;
        }

        private void search_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //this program will end if this form is closed
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<Movie> movies = new List<Movie>(); //creating the list that will store each movie
            List<String> fileInfo = new List<String>(); //list that will store the text in the Movies.txt file

            String n = textBox2.Text.ToLower(); //changing the text in textBox2 to lowercase and storing it in the n string

            try //the following code will be executed
            {
                //storing each line in the Movies.txt file in the fileInfo list, the first 3 will be skipped
                fileInfo = File.ReadAllLines(@"C:\Users\dania\source\repos\Culminating Movie Database\Movies.txt").Skip(3).ToList();
            }

            catch (FileNotFoundException) //if the FileNotFoundException is caught the following message will be caught
            {
                sub2.Text = "The file was not found, make sure that the file path is correct...";
            }

            catch (DirectoryNotFoundException)  //if the DirectoryNotFoundException is caught the following message will be caught
            {
                sub2.Text = "The file was not found, make sure that the file path is correct...";
            }

            String[] movieInfo = new String[5]; //creating the array that will store the movie's info

            bool searched = false; //creating the boolean that will check if the movie was searched or not

            //removing empty lines from the fileInfo list
            foreach (String line in fileInfo.ToList())
                if (String.IsNullOrEmpty(line))
                    fileInfo.Remove(line);

            for (int i = 0; i < fileInfo.Count; i++) //this will loop through each line in the fileInfo list
            {
                movieInfo = fileInfo[i].Split('\t'); //splitting the line by tabs
                
                //adding a new movie into the movies list, by using the contents of the movieInfo array
                movies.Add(new Movie(movieInfo[0], movieInfo[1], movieInfo[2], movieInfo[3], Convert.ToDouble(movieInfo[4]))); 
            }

            if (String.IsNullOrEmpty(textBox2.Text) == false) //if the line isnt empty the following code will execute
            {
                //this will loop as long as i is less than the number of items in the movies list
                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].name == n) //if movie's name is equal to the n string
                    {
                        //writing the movie's contents to textBox1
                        textBox1.Text = "Name 	Release Date 		Genre           Fav.Character 	Rating(Out Of 5)";
                        textBox1.AppendText(Environment.NewLine);
                        textBox1.AppendText(movies[i].toString());

                        showButtons(true); //calling the showButtons method with true as an argument
                        sub2.Text = "The movie info has been found.";
                    }
                }

                if (searched == false) //if searched is equal to false the following will be execute
                {
                    sub2.Text = "That movie could not be found...";
                    textBox1.Clear(); //clearing textBox1
                    showButtons(false); //calling the showButtons method with false as an argument
                }
            }

            else if (String.IsNullOrEmpty(textBox2.Text)) //if textBox2 is empty the following will happen
            {
                sub2.Text = "Make sure that the name of the movie is entered!";
                textBox1.Clear(); //clearing textBox1
                showButtons(false); //calling the showButtons method with false as an argument
            }
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            searchedName = textBox2.Text; //searchedName will equal the text in textBox2

            //hhiding this form and opening the edit form
            edit newForm = new edit();
            this.Hide();
            newForm.ShowDialog();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            sub2.Text = "Enter the name of the movie";
            showButtons(false); //calling showButtons method with false as an argument

            //clearing textBox 1 and 2
            textBox1.Clear();
            textBox2.Clear();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //hiding this form and opening form1
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        /*This method takes a boolean as a parameter. If the boolean is equal to true
        Then label3, button3, and button4 will be visible. If the boolean is false then
        they will be invisible */
        public void showButtons(bool x)
        {
            //if the boolean is true then sub3, yesBtn, and noBtn will be visible
            if (x == true)
            {
                sub3.Visible = true;
                yesBtn.Visible = true;
                noBtn.Visible = true;
            }

            //if the boolean is false then sub3, yesBtn, and noBtn will be invisible
            else
            {
                sub3.Visible = false;
                yesBtn.Visible = false;
                noBtn.Visible = false;
            }
        }

        private void search_Load(object sender, EventArgs e)
        {

        }
    }
}
