using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace VisualTesting
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new NavigationPage(new VisualPage())
            //{
            //    BarBackgroundColor = Color.FromHex("#2196F3"),
            //    BarTextColor = Color.White
            //};

            MainPage = new AppShell();
        }
    }
}
