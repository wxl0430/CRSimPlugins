
using Zibo.PlatformScreen.ViewModels;
using System.Windows.Controls;
namespace Zibo.PlatformScreen.Views
{
    public partial class ScreenView : Page
    {
        public ScreenViewModel ViewModel { get; }
        public ScreenView(ScreenViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            DataContext = viewModel;
        }
    }
}
