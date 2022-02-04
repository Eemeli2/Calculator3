using Oma_Projekti_1.Models;
using Oma_Projekti_1.Services;
using Oma_Projekti_1.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Oma_Projekti_1.ViewModels
{
    public class AnimalListViewModel : BaseViewModel
    {
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

            var animalPage = new AnimalDetailPage();

            animalPage.BindingContext = new AnimalViewModel(animal);

            await Shell.Current.CurrentPage.Navigation.PushAsync(animalPage);
        }




        private ObservableCollection<IAnimal> _animals;
        public AnimalListViewModel()
        {
            
                AnimalTapped = new Command<IAnimal>(OnAnimalSelected);
            

            _animals = new ObservableCollection<IAnimal>(
                new IAnimal[]
                {
                    new Cat(),
                    new Dog(),
                    new Alligator(),
                    new Crow()
                });
        }
        public ObservableCollection<IAnimal> Animals => _animals;
        }
    }
