using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ValeAppStore
{
    public class ApplicationDetailViewModel
    {
        private INavigation _navigation;

        public ICommand OpenCommand { get; private set; }
        public ICommand RequestCommand { get; private set; }

        public ApplicationViewModel ApplicationDetail
        {
            get;
            set;
        }

        public ApplicationDetailViewModel(INavigation navigation)
        {
            this._navigation = navigation;

            OpenCommand = new Command(() =>
            {
                //DisplayAlert(
                ApplicationDetail.Title = "New Title";
            }, ()=> { return true;});

            RequestCommand = new Command(() =>
            {
                //DisplayAlert(
                ApplicationDetail.Title = "Request command clicked";

            }, () => { return true;});
        }




    }
}

