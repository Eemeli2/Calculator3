using Oma_Projekti_1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Oma_Projekti_1.Views
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