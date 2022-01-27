using Oma_Projekti_1.Services;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Oma_Projekti_1.ViewModels
{
    public class AnimalViewModel : BaseViewModel
    {
        private readonly IAnimal _animal;

        public AnimalViewModel( IAnimal animal )
        {

            _animal = animal;

            {

            }
        }
        public string Name => _animal.Name;
    }
}