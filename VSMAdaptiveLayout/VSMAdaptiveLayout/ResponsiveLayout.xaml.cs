using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VSMAdaptiveLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResponsiveLayout : ContentPage
    {
        public ResponsiveLayout()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            var state = (width > height) ? "Landscape" : "Portrait";
            VisualStateManager.GoToState(DetailsBoxView, state);
            VisualStateManager.GoToState(bulletChart, state);
        }
    }
}