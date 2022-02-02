using System.Collections.ObjectModel;
using Oma_Projekti_1.Services;

namespace Oma_Projekti_1.ViewModels
{
    public class AnimalListViewModel : BaseViewModel
    {
        private ObservableCollection<IAnimal> _animals;

        public AnimalListViewModel()
        {
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