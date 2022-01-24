using MvvmCross.Forms.Presenters.Attributes;

namespace MvvmFormsDemo.UI.Pages
{
    [MvxContentPagePresentation(WrapInNavigationPage = false)]
    public partial class LoginPage
    {
        public LoginPage()
        {
            InitializeComponent();

            // var set = CreateBindingSet();
            // set.Bind(UsernameEntry)
            //     .For(x => x.Text)
            //     .To(vm => vm.Username);
            // set.Bind(PasswordEntry)
            //     .For(x => x.Text)
            //     .To(vm => vm.Password);
            // set.Bind(LoginButton)
            //     .For(x => x.Command)
            //     .To(vm => vm.LoginCommand);
            // set.Bind(LoginButton)
            //     .For(x => x.IsEnabled)
            //     .To(vm => vm.IsLoginButtonEnabled);
            // set.Apply();
        }
    }
}

