using MvvmCross.Forms.Presenters.Attributes;

namespace MvvmFormsDemo.UI.Pages
{
    [MvxTabbedPagePresentation(TabbedPosition.Root, NoHistory = false)]
    public partial class TabsRootPage
    {
        private bool _firstTime = true;

        public TabsRootPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (!_firstTime) return;
            ViewModel.ShowInitialViewModelsCommand.ExecuteAsync();
            _firstTime = false;
        }
    }
}
