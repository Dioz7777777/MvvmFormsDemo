using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmFormsDemo.Core.ViewModels.Home
{
    public sealed class TabsRootViewModel : MvxNavigationViewModel
    {
        public MvxAsyncCommand ShowInitialViewModelsCommand { get; }

        public TabsRootViewModel(
            ILoggerFactory logFactory,
            IMvxNavigationService navigationService)
            : base(logFactory, navigationService)
        {
            ShowInitialViewModelsCommand = new MvxAsyncCommand(ShowInitialViewModels);
        }

        private Task ShowInitialViewModels()
        {
            Task<bool>[] tasks =
            {
                NavigationService.Navigate<Tab1ViewModel>(),
                NavigationService.Navigate<Tab2ViewModel>()
            };
            return Task.WhenAll(tasks);
        }
    }
}
