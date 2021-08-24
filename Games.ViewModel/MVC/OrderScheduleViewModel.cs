using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class OrderScheduleViewModel: BaseViewModel
    {
        public OrderScheduleViewModel()
        {
            OrderPlacedDates = new List<DateTime>();
            UpcomingDeliveryDates = new List<DeliveryScheduleRecordViewModel>();
        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CurrentMonth { get; set; }
        public int CurrentYear { get; set; }
        public List<SelectListItem> RetailerLists { get; set; }
        public List<DeliveryScheduleRecordViewModel> UpcomingDeliveryDates { get; set; }
        public string UpcomingOrderingWindow { get; set; }
        public string UpcomingDeliveryWindow { get; set; }
        public List<OrderScheduleOrderDayViewModel> OrderScheduleDays { get; set; }
        public List<DateTime> OrderPlacedDates { get; set; }
    }

    public class OrderScheduleOrderDayViewModel
    { 
        public int DayId { get; set; }
        public int CodeDayId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime OrderingDate { get; set; }
        public string DisplayOrderingDate { get; set; }
        public string DisplayDeliveryDate { get; set; }
        public bool IsOrderPlaced { get; set; }
        public int OrderMode { get; set; }
        public int RemainingOrderTime { get; set; }
        public int ItemCount { get; set; }
        //public string DeliverySchedule  
    }

}
