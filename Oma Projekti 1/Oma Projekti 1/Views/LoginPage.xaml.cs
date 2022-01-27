using Oma_Projekti_1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Oma_Projekti_1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalAbstraction : ContentPage
    {
        public AnimalAbstraction()
        {
            InitializeComponent();
            this.BindingContext = new AnimalAbstraction();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}