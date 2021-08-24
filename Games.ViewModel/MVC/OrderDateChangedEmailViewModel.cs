using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class OrderDateChangedEmailViewModel
    {
        public string NewOrderDate { get; set; }
        public string OldOrderDate { get; set; }
        public List<OrderDayChangedEmailDetail> EmailDedails { get; set; }
    }
}
