using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CompanyComunicate()); //CompanyLoginPage
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
