using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.ModernUI.Sample.Pages;

namespace XF.ModernUI.Sample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
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
