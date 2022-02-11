using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using AnimalKingdom.Forms.Core.Interfaces;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Xamarin.Forms;

namespace AnimalKingdom.Forms.Core.ViewModels
{

    public class AnimalListViewModel : MvxViewModel

    {



        private readonly IMvxNavigationService _navigationService;
        private readonly IAnimalStore _animalStore;
        public AnimalListViewModel(IMvxNavigationService navigationService, IAnimalStore animalStore)
        {
            _navigationService = navigationService;
            _animalStore = animalStore;
            

            AnimalTapped = new Command<IAnimal>(OnAnimalSelected);
        }

        public override void Prepare()
        {
            //
            
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            var animals = await _animalStore.GetAnimalsAsync();

            Animals = new ObservableCollection<IAnimal>(animals);
        }

      

        private IAnimal _selectedAnimal;
        public Command<IAnimal> AnimalTapped { get; }
        public IAnimal SelectedAnimal
        {
            get => _selectedAnimal;
            set
            {
                SetProperty(ref _selectedAnimal, value);
                OnAnimalSelected(value);
            }
        }



        async void OnAnimalSelected(IAnimal animal)
        {
            if (animal == null)
                return;
            await _navigationService.Navigate<AnimalViewModel, IAnimal>(animal);
        }

      
        public ObservableCollection<IAnimal> Animals { get; private set; }
    }


}
