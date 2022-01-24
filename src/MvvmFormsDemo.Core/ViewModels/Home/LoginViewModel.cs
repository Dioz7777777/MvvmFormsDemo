using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmFormsDemo.Core.ViewModels.Home
{
    public sealed class LoginViewModel : MvxNavigationViewModel
    {
        private string _username;

        public string Username
        {
            get => _username;
            set
            {
                SetProperty(ref _username, value);
                CheckUsernameAndPassword();
            }
        }

        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                SetProperty(ref _password, value);
                CheckUsernameAndPassword();
            }
        }

        private bool _isLoginButtonEnabled;

        public bool IsLoginButtonEnabled
        {
            get => _isLoginButtonEnabled;
            set => SetProperty(ref _isLoginButtonEnabled, value);
        }

        public MvxAsyncCommand LoginCommand { get; }

        public LoginViewModel(ILoggerFactory logFactory, IMvxNavigationService navigationService)
            : base(logFactory, navigationService)
        {
            LoginCommand = new MvxAsyncCommand(Login);
        }

        private Task Login()
        {
            return Task.WhenAll(
                NavigationService.Close(this),
                NavigationService.Navigate<TabsRootViewModel>());
        }

        private void CheckUsernameAndPassword()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                IsLoginButtonEnabled = false;
            }
            else
            {
                IsLoginButtonEnabled = true;
            }
        }
    }
}
