using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace Lands.ViewModels
{
    public class LoginViewModel :INotifyPropertyChanged
    {
        private string _email;
        private string _password;
        private bool _isRunning;
        private bool _isRemembered;
        private bool _isEnable;
        public event PropertyChangedEventHandler PropertyChanged;
        #region Properties
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public bool IsRunning
        {
            get
            {
                return _isRunning;
            }
            set
            {
                _isRunning = value;
                OnPropertyChanged();
            }
        }
        public bool IsRemembered
        {
            get
            {
                return _isRemembered;
            }
            set
            {
                _isRemembered = value;
                OnPropertyChanged();
            }
        }
        public bool IsEnable
        {
            get
            {
                return _isEnable;
            }
            set
            {
                _isEnable = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            IsEnable = true;
            Email = "zincri@hotmail.com";
            Password = "1234";
            IsRemembered = true;
            IsRunning = false;

            

        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(LoginMethod);
            }
        }
        #endregion

        #region Methods
        private async void LoginMethod()
        {
            IsRunning = true;
            IsEnable = false;
            if (string.IsNullOrEmpty(this.Email))
            {
                await App.Current.MainPage.DisplayAlert(
                "Error Message",
                "the email is null or empty",
                "Ok");
                this.Password = string.Empty;
                IsRunning = false;
                IsEnable = true;
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await App.Current.MainPage.DisplayAlert(
                "Error Message",
                "the password is null or empty",
                "Ok");
                this.Password = string.Empty;
                IsRunning = false;
                IsEnable = true;
                return;
            }

            if (Email != "zincri@hotmail.com" || Password != "1234")
            {
                await App.Current.MainPage.DisplayAlert(
                "Error Message",
                "Email or password incorrect",
                "Ok");
                this.Password = string.Empty;
                IsRunning = false;
                IsEnable = true;
                return;
            }
            IsRunning = false;
            IsEnable = true;
            //Email = string.Empty;
            Password = string.Empty;

            MainViewModel.GetInstance().Lands = new LandsViewModel();
            await App.Current.MainPage.Navigation.PushAsync(new Views.LandsPage());

        }

        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion



    }
}
