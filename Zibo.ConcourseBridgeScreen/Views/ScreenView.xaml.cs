
using Zibo.ConcourseBridgeScreen.ViewModels;
using System.Windows.Controls;
namespace Zibo.ConcourseBridgeScreen.Views
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
