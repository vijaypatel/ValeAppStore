using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ValeAppStore
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new LoginViewModel(Navigation);
        }
    }
}

