using System;
using System.Collections.Generic;

namespace Games.DataModel
{
    public class OrderingDayConfig
    {
        public int Id { get; set; }
        public int AllocationSlotNumber { get; set; }
        public int DayId { get; set; }
        public DayMaster Day { get; set; }
        public bool Enabled { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public IEnumerable<OrderingDayConfigRetailerGroupMapping> AssignedGroups { get; set; }
    }
}