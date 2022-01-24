using MvvmCross.Forms.Presenters.Attributes;
using Xamarin.Forms;

namespace MvvmFormsDemo.UI.Pages
{
    [MvxTabbedPagePresentation(
        WrapInNavigationPage = false,
        Title = "Tab2")]
    public partial class Tab2Page
    {
        public Tab2Page()
        {
            InitializeComponent();
            IconImageSource = ImageSource.FromResource(
                "MvvmFormsDemo.UI.Resources.Images.list.png");
        }
    }
}
