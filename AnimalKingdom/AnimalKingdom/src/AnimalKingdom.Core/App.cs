using AnimalKingdom.Core.ViewModels.Home;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace AnimalKingdom.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
