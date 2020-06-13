using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VSMAdaptiveLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NonResponsiveLayout : ContentPage
    {
        public NonResponsiveLayout()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}