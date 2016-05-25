using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ValeAppStore
{
    public partial class ApplicationDetail : ContentPage
    {
        private ApplicationDetailViewModel Model{get {return BindingContext as ApplicationDetailViewModel;    }}

        void OpenButtonClicked(object sender, System.EventArgs e)
        {
            var launcher = DependencyService.Get<IApplicationService>();
          var installed=  launcher.IsInstalled(Device.OnPlatform<string>(iOS:Model.ApplicationDetail.IOSUri, 
                                                           Android:Model.ApplicationDetail.PackageName,
                                                           WinPhone:Model.ApplicationDetail.PackageName));
            //TODO: Open installed app

            //DisplayAlert("Message", "Request Clicked - " + installed.ToString(), "Ok");
            //if (installed)
            //{
                launcher.LaunchApp(Device.OnPlatform<string>(iOS: Model.ApplicationDetail.IOSUri,
                                                           Android: Model.ApplicationDetail.PackageName,
                                                         WinPhone: Model.ApplicationDetail.PackageName));
            //}


        }

        void RequestButtonClicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Message", "Request Clicked - ", "Ok");
            //TODO: Request access for this app
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var data = BindingContext as ApplicationDetailViewModel;
            foreach (var item in data.ApplicationDetail.AppScreenShots)
            {
                screenShot.Children.Add(new Image { Source = item });

            }
        }

        public ApplicationDetail()
        {
            InitializeComponent();


        }
    }
}

