using MvvmCross.Forms.Presenters.Attributes;
using Xamarin.Forms;

namespace MvvmFormsDemo.UI.Pages
{
    [MvxTabbedPagePresentation(
        WrapInNavigationPage = false,
        Title = "Tab1")]
    public partial class Tab1Page
    {
        public Tab1Page()
        {
            InitializeComponent();

            IconImageSource = ImageSource.FromResource(
                "MvvmFormsDemo.UI.Resources.Images.home.png");
        }
    }
}
