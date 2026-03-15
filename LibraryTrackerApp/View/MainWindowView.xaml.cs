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
using System.Windows.Shapes;
using LibraryTrackerApp.View;

namespace LibraryTrackerApp.View
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
            MaincontentControl.Content = new DashboardView();
            
        }

        // to open BookView();
        private void BooksButton_Click(object sender, RoutedEventArgs e)
        {
            MaincontentControl.Content = new BookView();
        }

        // to open dashboard
        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            MaincontentControl.Content = new DashboardView();
        }

        private void MemberButton_Click(Object sender, RoutedEventArgs e)
        {
            MaincontentControl.Content=new MemberView();
        }
    }
}
