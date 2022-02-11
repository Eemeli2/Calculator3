using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using AnimalKingdom.Forms.Core.Interfaces;
using Xamarin.Forms;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace AnimalKingdom.Forms.Core.ViewModels
{


    public class AnimalViewModel : MvxViewModel<IAnimal>
    {
        private IAnimal _animal;
        private readonly ICommand _playSoundCommand;

        public AnimalViewModel()
        {
            _playSoundCommand = new Command(() =>
            {
                _animal.PlaySound();
            });
        }

        public IAnimal Animal => _animal;

        public string Name => _animal.Name;

        public string Description => _animal.Description;

        public ICommand PlaySoundCommand => _playSoundCommand;

        public override void Prepare(IAnimal parameter)
        {
            _animal = parameter;
        }
        public override async Task Initialize()
        {
            await base.Initialize();

        }
    }
}
