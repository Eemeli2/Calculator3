
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using AnimalKingdom.Forms.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimalKingdom.Forms.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true)]
    public partial class HomePage : MvxContentPage<AnimalListViewModel>
    {
        public HomePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Application.Current.MainPage is NavigationPage navigationPage)
            {
                navigationPage.BarTextColor = Color.White;
                navigationPage.BarBackgroundColor = (Color)Application.Current.Resources["PrimaryColor"];
            }
        }
    }
}
