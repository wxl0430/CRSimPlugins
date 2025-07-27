using CRSim.Core.Models;
using CRSim.Core.Abstractions;
using CRSim.ScreenSimulator.ViewModels;
namespace Zibo.PrimaryScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            ItemsPerPage = 8;
            ScreenCount = 2;
            StationType = StationType.Departure;
        }
    }
}
