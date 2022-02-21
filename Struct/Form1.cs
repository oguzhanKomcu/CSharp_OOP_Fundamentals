using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Movie_Struct movie;

        private void btnCreate_Click(object sender, EventArgs e)
        {

            

            movie.Name = textName.Text;
            movie.Genre = textGenre.Text;   
            movie.Year = textYear.Text; 
            movie.Country = textCountry.Text;   
            movie.Point = textPoint.Text;   
            movie.Director = textDirector.Text;
            MessageBox.Show($"Name: {movie.Name}\nGenre: {movie.Genre}\nYear: {movie.Year}\nCountry: {movie.Country}\nPoint:{movie.Point}\nDirector: {movie.Director}");

            Movie_Struct movie2 = new Movie_Struct();
            movie2.Name = textName.Text;
            movie2.Genre = textGenre.Text;
            movie2.Year = textYear.Text;
            movie2.Country = textCountry.Text;
            movie2.Point = textPoint.Text;
            movie2.Director = textDirector.Text;

        }
    }
}
