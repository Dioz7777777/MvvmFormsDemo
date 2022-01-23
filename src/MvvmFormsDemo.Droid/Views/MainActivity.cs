using Android.App;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmFormsDemo.Core.ViewModels.Main;

namespace MvvmFormsDemo.Droid
{
    [Activity(
        Theme = "@style/AppTheme")]
    public class MainActivity : MvxFormsAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
        }
    }
}
