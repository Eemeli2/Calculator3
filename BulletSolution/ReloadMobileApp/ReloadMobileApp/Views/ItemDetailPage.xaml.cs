using ReloadMobileApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ReloadMobileApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}