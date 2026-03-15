using LibraryTrackerApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LibraryTrackerApp.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand<string>(Login);
        }
        
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        private string _userId;
        public string UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
                OnPropertyChanged(nameof(UserId));
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        // login validation
        private void Login(string? parameter)
        {
           
             Password = parameter;

            if (UserId == "Admin" && Password == "Admin")
            {
                MessageBox.Show("Login Successfully!");
                MainWindowView main = new MainWindowView();
                   main.Show();
                Application.Current.Windows[0].Close();

            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }


    }

       
 }
