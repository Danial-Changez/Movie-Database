using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culminating_Movie_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //hiding this form and opening the add form
            add newForm = new add();
            this.Hide();
            newForm.ShowDialog();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            //hiding this form and opening the remove form
            remove newForm = new remove();
            this.Hide();
            newForm.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //hiding this form and opening the search form
            search newForm = new search();
            this.Hide();
            newForm.ShowDialog();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            //hiding this form and opening the display form
            display newForm = new display();
            this.Hide();
            newForm.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //the code will end if this form is closed
        }
    }
}
