using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _mainFrame.NavigationService.Navigate(new HomePage());
        }
        //private void btnMovies_Click(object sender, RoutedEventArgs e)
        //{
        //    _mainFrame.Navigate(new System.Uri("AddSearchOptions.xaml",
        //     UriKind.RelativeOrAbsolute));
        //    //AddSearchOptions objAddSearch = new AddSearchOptions();
        //    //this.Content = objAddSearch;
        //}

        //private void btnSongs_Click(object sender, RoutedEventArgs e)
        //{
        //    AddSearchOptions objAddSearch = new AddSearchOptions();
        //    this.Content = objAddSearch;

        //}

        //private void btnShows_Click(object sender, RoutedEventArgs e)
        //{
        //    AddSearchOptions objAddSearch = new AddSearchOptions();
        //    this.Content = objAddSearch;
        //}
    }
}
