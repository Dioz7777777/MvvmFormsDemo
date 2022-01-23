using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmFormsDemo.Core.ViewModels.Home;

namespace MvvmFormsDemo.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<LoginViewModel>();
        }
    }
}
