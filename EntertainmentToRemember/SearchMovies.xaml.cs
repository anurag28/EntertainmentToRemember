using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace EntertainmentToRemember
{
    /// <summary>
    /// Interaction logic for SearchMovies.xaml
    /// </summary>
    public partial class SearchMovies : Page
    {
        FileReader reader;
        public SearchMovies()
        {
            InitializeComponent();
            reader = new FileReader();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            List<string> moviesList = new List<string>();
           
            string moviesDetails = null;
            if(txtCast.Text=="" && this.drpdownGenre.Text.ToString() != "Choose your option")
            {
                MessageBox.Show("1");
                moviesList = reader.FetchMovieDetailsGenre(this.drpdownGenre.Text.ToString());

            }

            else if(txtCast.Text!="" && this.drpdownGenre.Text.ToString() != "Choose your option")
            {
                MessageBox.Show("2");
                moviesList = reader.FetchMovieDetails(this.drpdownGenre.Text.ToString(), txtCast.Text);
            }

            else if(txtCast.Text != "" && this.drpdownGenre.Text.ToString() == "Choose your option")
            {
                MessageBox.Show("3");
                moviesList = reader.FetchMovieDetails(txtCast.Text);
            }

            foreach(string movie in moviesList)
            {
                MessageBox.Show(movie);
                moviesDetails = movie;
            }

          
                txtSearchResult.Text = txtSearchResult.Text + moviesDetails;
            
        }
    }
}
