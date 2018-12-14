using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace VisualTesting
{
    public class App : Application
    {
        public App()
        {

            //MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new VisualPage())
            {
                BarBackgroundColor = Color.FromHex("#2196F3"),
                BarTextColor = Color.White
            };
        }
    }
}
