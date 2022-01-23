using MvvmCross.Forms.Presenters.Attributes;

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
        }
    }
}
