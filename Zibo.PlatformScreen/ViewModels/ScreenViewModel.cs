using CRSim.Core.Models;
using CRSim.Core.Abstractions;
using CRSim.ScreenSimulator.ViewModels;
namespace Zibo.PlatformScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = $"请站在白色安全线以内排队候车";
            ItemsPerPage = 1;
        }
    }
}
