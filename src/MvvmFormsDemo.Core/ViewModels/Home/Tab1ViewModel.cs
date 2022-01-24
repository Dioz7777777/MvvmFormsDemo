using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmFormsDemo.Core.ViewModels.Home
{
    public sealed class Tab1ViewModel : MvxNavigationViewModel
    {
        public IMvxAsyncCommand LogoutCommand { get; }

        public Tab1ViewModel(ILoggerFactory logFactory, IMvxNavigationService navigationService)
            : base(logFactory, navigationService)
        {
            LogoutCommand = new MvxAsyncCommand(Logout);
        }

        private Task Logout()
        {
            return Task.WhenAll(
                NavigationService.Close(this),
                NavigationService.Navigate<LoginViewModel>());
        }
    }
}
