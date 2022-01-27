using Oma_Projekti_1.Services;
using Oma_Projekti_1.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Oma_Projekti_1.Views
{
    public partial class Animal : ContentPage
    {
        public Animal()
        {
            InitializeComponent();

            

            BindingContext = new AnimalViewModel(new Cat());

        }
    }
}