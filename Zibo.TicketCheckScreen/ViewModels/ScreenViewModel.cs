﻿using CRSim.Core.Models;
using CRSim.Core.Abstractions;
using CRSim.ScreenSimulator.Models;
using CRSim.ScreenSimulator.ViewModels;
namespace Zibo.TicketCheckScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = $"    开车前{settingsService.GetSettings().StopCheckInAdvanceDuration.TotalMinutes}分钟停止检票";
            StationType = StationType.Departure;
            ItemsPerPage = 5;
            ScreenCount = 2;
        }
        public override void RefreshDisplay(object? sender, EventArgs? e)
        {
            UIDispatcher.Invoke(() =>
            {
                int pageCount = (int)Math.Ceiling((double)TrainInfo.Count / (ItemsPerPage * ScreenCount.Value));
                ScreenA.Clear();
                ScreenB.Clear();
                int startIndex = CurrentPageIndex * ItemsPerPage * ScreenCount.Value;
                var ItemsToShow = TrainInfo.Skip(startIndex).Take(ItemsPerPage * ScreenCount.Value).ToList();
                var leftItems = ItemsToShow.Where((item, index) => index % 2 == 0).ToList();
                var rightItems = ItemsToShow.Where((item, index) => index % 2 == 1).ToList();
                while (leftItems.Count < ItemsPerPage)
                {
                    leftItems.Add(new TrainInfo());
                }
                while (rightItems.Count < ItemsPerPage)
                {
                    rightItems.Add(new TrainInfo());
                }
                foreach (var item in leftItems)
                {
                    ScreenA.Add(item);
                }
                foreach (var item in rightItems)
                {
                    ScreenB.Add(item);
                }
                CurrentPageIndex = CurrentPageIndex + 1 >=  Math.Min(_settings.MaxPages, pageCount) ? 0 : CurrentPageIndex + 1;
            });
        }
    }
}
