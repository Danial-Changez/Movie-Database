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
    public partial class display : Form
    {
        public List<String> movies = new List<String>(); //creating the list that will store the movies

        public display()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //opening form1 and closing this form
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void display_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //this program will end if this form is closed
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            try //the following code will be ran
            {
                //storing each line in the text file into the movies list, the first three lines will be skipped
                movies = File.ReadLines(@"C:\Users\dania\source\repos\Culminating Movie Database\Movies.txt").Skip(3).ToList();
            }

            catch (FileNotFoundException) //if the FileNotFoundException is caught the following message will be displayed
            {
                sub.Text = "The file was not found, make sure that the file path is correct...";
            }

            catch (DirectoryNotFoundException) //if the DirectoryNotFoundException is caught the following message will be displayed
            {
                sub.Text = "The file was not found, make sure that the file path is correct...";
            }

            //removing empty lines from the movies list
            foreach (String line in movies.ToList())
                if (String.IsNullOrEmpty(line))
                    movies.Remove(line);

            textBox1.Text = "Name 	Release Date 		Genre           Fav.Character 	Rating(Out Of 5)";

            //printing each line in the movies list to textBox1
            foreach (String line in movies.ToList())
            {
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText(line);
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            try //the following code will be ran
            {
                //storing each line in the text file into the movies list, the first three lines will be skipped
                movies = File.ReadLines(@"C:\Users\dania\source\repos\Culminating Movie Database\Movies.txt").Skip(3).ToList();
                movies.Sort(); //sorting the list
            }

            catch (FileNotFoundException) //if the FileNotFoundException is caught the following message will be displayed
            {
                sub.Text = "The file was not found, make sure that the file path is correct...";
            }

            catch (DirectoryNotFoundException) //if the DirectoryNotFoundException is caught the following message will be displayed
            {
                sub.Text = "The file was not found, make sure that the file path is correct...";
            }

            //removing empty lines from the movies list
            foreach (String line in movies.ToList())
                if (String.IsNullOrEmpty(line))
                    movies.Remove(line);

            textBox1.Text = "Name 	Release Date 		Genre           Fav.Character 	Rating(Out Of 5)";

            //printing each line in the movies list to textBox1
            foreach (String line in movies.ToList())
            {
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText(line);
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private void display_Load(object sender, EventArgs e)
        {

        }

    }
}
