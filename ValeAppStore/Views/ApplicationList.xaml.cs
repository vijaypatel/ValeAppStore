using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ValeAppStore
{
    public partial class ApplicationList : ContentPage
    {
        public ApplicationList()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Helper.IsLoggedIn)
            {
                BindingContext = new ApplicationListViewModel(Navigation);
                appListView.ItemSelected += (s, e) =>
                {
                    appListView.SelectedItem = null;
                };
            }
            else
            {
                Navigation.PushModalAsync(new Login());
            }
        }
    }
}

