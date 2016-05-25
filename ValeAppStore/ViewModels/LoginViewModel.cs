using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ValeAppStore
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _userName;
        private string _password;

        private INavigation _navigation;

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel(INavigation navigation)
        {
            this._navigation = navigation;

            this.LoginCommand = new Command(() =>
            {
                //TODO: add authentication details
                Helper.IsLoggedIn = true;
                this._navigation.PopModalAsync(true);

            }, () =>
            {
                return !string.IsNullOrWhiteSpace(this._userName) && !string.IsNullOrWhiteSpace(this._password);
            });
        }

        public string UserName
        {
            get { return this._userName; }

            set
            {
                this._userName = value;
                RaisePropertyChangedEvent("UserName");
                ((Command)this.LoginCommand).ChangeCanExecute();
            }
        }

        public string Password
        {
            get { return this._password; }

            set
            {
                this._password = value;
                RaisePropertyChangedEvent("Password");
                ((Command)this.LoginCommand).ChangeCanExecute();
            }
        }

        public ICommand LoginCommand { get; private set; }

        private void RaisePropertyChangedEvent(string propertyName)
        {
            if (null != PropertyChanged)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

