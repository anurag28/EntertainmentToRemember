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
        public AddSearchOptions()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddMovies());   
        }

        private void btnNavigateToHome_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HomePage());
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SearchMovies());
        }
    }
}
