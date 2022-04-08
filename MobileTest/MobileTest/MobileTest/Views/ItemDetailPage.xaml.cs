using MobileTest.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobileTest.Views
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