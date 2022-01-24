using System.Threading.Tasks;
using MvvmCross.Commands;

namespace MvvmFormsDemo.Core.ViewModels.Home
{
    public sealed class LoginViewModel : BaseViewModel
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

        public LoginViewModel()
        {
            LoginCommand = new MvxAsyncCommand(async () => await LoginAsync());
            IsLoginButtonEnabled = true;
        }

        private Task LoginAsync()
        {
            return Task.CompletedTask;
        }

        private void CheckUsernameAndPassword()
        {
            if (string.IsNullOrWhiteSpace(Username) && string.IsNullOrWhiteSpace(Password))
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
