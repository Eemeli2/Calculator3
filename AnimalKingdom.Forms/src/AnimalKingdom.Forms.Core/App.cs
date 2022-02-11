using MvvmCross.IoC;
using MvvmCross.ViewModels;
using AnimalKingdom.Forms.Core.ViewModels;
using MvvmCross;
using AnimalKingdom.Forms.Core.Interfaces;

namespace AnimalKingdom.Forms.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.IoCProvider.RegisterType<IAnimalStore, MockAnimalStore>();

            RegisterAppStart<AnimalListViewModel>();
        }
    }
}
