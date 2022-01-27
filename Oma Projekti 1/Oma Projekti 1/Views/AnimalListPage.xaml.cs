using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oma_Projekti_1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Oma_Projekti_1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalListPage : ContentPage
    {
        public AnimalListPage()
        {
            InitializeComponent();

            BindingContext = new AnimalListViewModel();
        }
    }
}