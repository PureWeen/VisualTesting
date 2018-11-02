using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace VisualTesting
{
    using Xamarin.Forms;
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            // All currently implemented controls are listed here
            // Frame == Card View on Native Platforms
            ProgressBar progressBar = new ProgressBar()
            {
                Visual = Visual.Material,
                ProgressColor = Color.Blue,
                HeightRequest = 5
            };

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                var progress = progressBar.Progress + 0.1;
                if (progress > 1)
                    progress = 0;

                progressBar.Progress = progress;
                return true;
            });

            Content = new StackLayout()
            {
                Children =
                {
                    new Frame()
                    {
                        Visual = Visual.Material,
                        Margin = 10,
                        HasShadow = true,
            			//border not working
            			BorderColor = Color.Blue,
                        BackgroundColor = Color.Yellow,
                        CornerRadius = 10,
                        Content = new Label()
                        {
                            Text = "Welcome To Visuals",
                            HorizontalOptions = LayoutOptions.Center,
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
                        }

                    },
                    new Frame()
                    {
                        Visual = Visual.Material,
                        Margin = 10,
                        HasShadow = true,
            			//border not working
            			//BorderColor = Color.Blue,
            			Content = new StackLayout()
                        {
                            Children =
                            {
                                new Entry()
                                {
                                    Visual = Visual.Material,
                                    PlaceholderColor = Color.Green,
                                    Placeholder = "Login"
                                },
                                new Entry()
                                {
                                    Visual = Visual.Material,
                                    PlaceholderColor = Color.Green,
                                    Placeholder = "Password",
                                    IsPassword = true
                                },
                                progressBar,
                                new Button()
                                {
                                    Text = "Login",
                                    Visual = Visual.Material,
                                    BackgroundColor = Color.Pink,
                                    TextColor = Color.Black,
                                    HorizontalOptions = LayoutOptions.FillAndExpand,
                                    Margin = new Thickness(5,0,5,0),
                                    CornerRadius = 3,
                                    BorderColor = Color.Blue,
                                    BorderWidth = 4
                                }
                            }
                        }
                    }
                }
            };

            this.On<iOS>().SetUseSafeArea(true);
        }
    }
}
