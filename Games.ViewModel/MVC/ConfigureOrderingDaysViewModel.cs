using Games.Common.Resources;
using Games.ViewModel.Validation;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Games.ViewModel.MVC
{
    public class ConfigureOrderingDaysViewModel
    {
        public int Id { get; set; }
        public int DayId { get; set; }
        public DayMasterViewModel Day { get; set; }
        public int AllocationSlotNumber { get; set; }
        public bool Enabled { get; set; }
        public string StartTime { get; set; }
        [MustBeLaterThan("StartTime")]
        public string EndTime { get; set; }
        public IEnumerable<RetailerGroupViewModel> AssignedGroups { get; set; }
        public string StringifiedAssignedGroupIds { get; set; }
        public IList<SelectListItem> StartTimespans { get; set; }
        public IList<SelectListItem> EndTimespans { get; set; }

        public static void Validate(IEnumerable<ConfigureOrderingDaysViewModel> configures, ModelStateDictionary ms)
        {
            if (configures != null && configures.Any())
            {
                var groups = configures.GroupBy(x => x.DayId).Select(x => new
                {
                    DayId = x.First().DayId,
                    Enabled = x.First().Enabled && x.Skip(1).First().Enabled,
                    EndTime1 = x.First(s => s.AllocationSlotNumber == 1).EndTime,
                    StartTime2 = x.First(s => s.AllocationSlotNumber == 2).StartTime
                });
                foreach (var g in groups)
                {
                    if (!g.Enabled)
                    {
                        continue;
                    }
                    var endTime1 = TimeSpan.Parse(g.EndTime1);
                    var startTime2 = TimeSpan.Parse(g.StartTime2);
                    if (endTime1.Add(new TimeSpan(1, 0, 0)) > startTime2)
                    {
                        ms.AddModelError(string.Format("DayId_{0}", g.DayId), CommonResources.InvalidValue);
                    }
                }
            }
        }
    }
}
