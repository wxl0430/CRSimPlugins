using CRSim.Core.Models;
using CRSim.Core.Abstractions;
using CRSim.ScreenSimulator.ViewModels;
namespace Zibo.SecondaryScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = $"开车前{settingsService.GetSettings().StopCheckInAdvanceDuration.TotalMinutes}分钟停止检票";
            ItemsPerPage = 18;
            ScreenCount = 1;
            StationType = StationType.Departure;
        }
    }
}
