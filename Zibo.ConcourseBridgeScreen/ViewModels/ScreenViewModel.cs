using CRSim.Core.Models;
using CRSim.Core.Abstractions;
using CRSim.ScreenSimulator.ViewModels;
namespace Zibo.ConcourseBridgeScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            StationType = StationType.Departure;
            ItemsPerPage = 2;
        }
    }
}
