using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace VSMAdaptiveLayout
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
        }

        private async void NonResponsive_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NonResponsiveLayout()); 
        }
        private async void Responsive_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResponsiveLayout());
        }
    }
}
