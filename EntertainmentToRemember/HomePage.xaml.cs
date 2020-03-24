﻿using System;
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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnMovies_Click(object sender, RoutedEventArgs e)
        {
            //AddSearchOptions objAddSearch = new AddSearchOptions();
            //this.Content = objAddSearch;

            this.NavigationService.Navigate(new AddSearchOptions("Movies"));
        }

        private void btnSongs_Click(object sender, RoutedEventArgs e)
        {
            //AddSearchOptions objAddSearch = new AddSearchOptions();
            //this.Content = objAddSearch;
            this.NavigationService.Navigate(new AddSearchOptions("Songs"));

        }

        private void btnShows_Click(object sender, RoutedEventArgs e)
        {
            //AddSearchOptions objAddSearch = new AddSearchOptions();
            //this.Content = objAddSearch;
            this.NavigationService.Navigate(new AddSearchOptions("Shows"));
        }
    }
}
