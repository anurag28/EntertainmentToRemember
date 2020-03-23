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

namespace EntertainmentToRemember
{
    /// <summary>
    /// Interaction logic for AddMovies.xaml
    /// </summary>
    public partial class AddMovies : Page
    {
        FileWriter writeObj;
       
        public AddMovies()
        {
            InitializeComponent();
            writeObj = new FileWriter();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string cast = txtCast.Text;
            string rating = txtRating.Text;
            string genre = this.drpdownGenre.Text.ToString();
            writeObj.WriteToMoviesFiles(name, cast, genre, rating);
        }
    }
}
