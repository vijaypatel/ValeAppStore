using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ValeAppStore
{
    public class ApplicationListViewModel
    {
        INavigation _navigation;
        public ApplicationListViewModel(INavigation navigation)
        {
            this._navigation = navigation;

            var ddd = new List<ApplicationViewModel> {
                new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", IOSUri="hello://", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                        new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}},
                new ApplicationViewModel (navigation){ Title="As Seen On TV … Bringing C# to the Living Room", Description="The new Apple TV has been released, and YOU can be one of the first developers to write apps for it. To make things even better, you can build these apps in C#! This session will introduce the basics of how to create a tvOS app with Xamarin, including: differences between tvOS and iOS APIs, TV user interface best practices, responding to user input, as well as the capabilities and limitations of building apps for a television. Grab some popcorn—this is going to be good!",
                    AppIconUri="http://i.imgur.com/ASj60DP.jpg", PublishedDate=DateTime.Now, AppScreenShots=new List<string>{"http://i.imgur.com/ASj60DP.jpg","http://i.imgur.com/ASj60DP.jpg"}}
            };

            Applications = ddd;
        }

        public List<ApplicationViewModel> Applications
        {
            get;
            private set;
        }

        public ApplicationViewModel SelectedEvent
        {
            set
            {

                if (value != null)
                {
                    var viewModel = new ApplicationDetailViewModel(_navigation) { ApplicationDetail = value };
                    _navigation.PushAsync(new ApplicationDetail { BindingContext = viewModel });
                }
            }
        }
    }
}

