using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Oma_Projekti_1.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalListView : ContentPage
    {
        public AnimalListView()
        {
            InitializeComponent();
        }




        public string Animal { get; set; }

    }

}