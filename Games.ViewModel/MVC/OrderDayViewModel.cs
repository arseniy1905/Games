using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class OrderDayViewModel
    {
        public OrderDayViewModel()
        {
            TimeSlots = new List<TimeSlotViewModel>();
        }
        public int DayId { get; set; }
        public List<TimeSlotViewModel> TimeSlots { get; set; }
    }
}
