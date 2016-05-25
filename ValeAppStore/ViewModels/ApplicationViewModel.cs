using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ValeAppStore
{
    public class ApplicationViewModel
    {
        private INavigation _navigation;
        public ApplicationViewModel(INavigation navigation)
        {
            this._navigation = navigation;
        }

        public string Title
        {
            get;
            set;
        }

        public string PackageName
        {
            get;
            set;
        }

        public string IOSUri
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string AppIconUri
        {
            get;
            set;
        }

        public bool IsAccessible
        {
            get;
            set;
        }

        public IList<string> AppScreenShots { get; set; }

        public DateTime PublishedDate
        {
            get;
            set;
        }
    }
}

