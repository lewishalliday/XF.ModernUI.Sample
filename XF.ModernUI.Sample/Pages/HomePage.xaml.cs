using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XF.ModernUI.Sample.ViewModels;

namespace XF.ModernUI.Sample.Pages
{
    public partial class HomePage : ContentPage
    {
        public static readonly BindableProperty HomePageVmProperty =
            BindableProperty.Create("HomePageVm", typeof(HomePageVm), typeof(HomePage), null);

        public HomePageVm HomePageVm
        {
            get { return (HomePageVm)GetValue(HomePageVmProperty); }
            set { SetValue(HomePageVmProperty, value); }
        }

        public HomePage()
        {
            InitializeComponent();
            this.BindingContext = new HomePageVm();
        }
    }
}
