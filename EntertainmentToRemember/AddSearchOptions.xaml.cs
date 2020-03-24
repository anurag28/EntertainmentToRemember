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
    /// Interaction logic for AddSearchOptions.xaml
    /// </summary>
    public partial class AddSearchOptions : Page
    {
        string entertainmentType;
        public AddSearchOptions(string entertainmentType)
        {
            InitializeComponent();
            this.entertainmentType = entertainmentType;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddContent(entertainmentType));
        }

        private void btnNavigateToHome_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HomePage());
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (entertainmentType == "Movies")
            {
                this.NavigationService.Navigate(new SearchMovies());
            }
        }

        private void btnAddToWishlist_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
