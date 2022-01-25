using System.Linq;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace MvvmFormsDemo.Core.ViewModels.Home
{
    public sealed class Tab2ViewModel : BaseViewModel
    {
        public MvxObservableCollection<ItemHeader> Initiatives { get; }

        public MvxCommand<ItemHeader> HeaderTappedCommand { get; }

        public Tab2ViewModel()
        {
            Initiatives = new MvxObservableCollection<ItemHeader>();
            Initiatives.AddRange(new []
            {
                new ItemHeader
                {
                    Id = 1,
                    Label = "Header 1",
                    Items = new MvxObservableCollection<ItemChild>
                    {
                        new ItemChild
                        {
                            Id = 1,
                            Name = "Item 1-1",
                        },
                        new ItemChild
                        {
                            Id = 2,
                            Name = "Item 1-2"
                        }
                    }
                },
                new ItemHeader
                {
                    Id = 2,
                    Label = "Header 2",
                    Items = new MvxObservableCollection<ItemChild>
                    {
                        new ItemChild
                        {
                            Id = 3,
                            Name = "Item 2-1",
                        },
                        new ItemChild
                        {
                            Id = 4,
                            Name = "Item 2-2"
                        }
                    }
                }
            });

            HeaderTappedCommand = new MvxCommand<ItemHeader>(HeaderTapped);
        }

        private static void HeaderTapped(ItemHeader value)
        {
            value.IsElapsed = !value.IsElapsed;
            value = null;
        }
    }

    public sealed class ItemHeader : MvxNotifyPropertyChanged
    {
        private bool _isElapsed;
        public int Id { get; set; }
        public string Label { get; set; }

        public bool IsElapsed
        {
            get => _isElapsed;
            set => SetProperty(ref _isElapsed, value);
        }

        public MvxObservableCollection<ItemChild> Items { get; set; }
    }

    public sealed class ItemChild
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
