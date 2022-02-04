using Oma_Projekti_1.Services;
using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Oma_Projekti_1.ViewModels
{
    public class AnimalViewModel : BaseViewModel
    {
        private readonly IAnimal _animal;
        private readonly ICommand _playSoundCommand;

        public AnimalViewModel(IAnimal animal)
        {
            _animal = animal;

            _playSoundCommand = new Command(() =>
            {
                //todo: play sound
                _animal.PlaySound();
            });
            
        }
        public IAnimal Animal => _animal;
        public string Name => _animal.Name;

        public string Description => _animal.Description;

        public ICommand PlaySoundCommand => _playSoundCommand;
    }
}