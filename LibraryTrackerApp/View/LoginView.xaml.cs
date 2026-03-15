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
using LibraryTrackerApp.ViewModel;

namespace LibraryTrackerApp.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var vm = (LoginViewModel)DataContext;
            vm.LoginCommand.Execute(pwdBox.Password);
        }
    }
}
