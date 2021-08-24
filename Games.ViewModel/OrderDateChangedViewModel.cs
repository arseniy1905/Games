using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class OrderDateChangedViewModel
    {
        public OrderDateChangedViewModel()
        {
            NewOrderDate = new StringBuilder();
            OldOrderDate = new StringBuilder();
        }
        public StringBuilder NewOrderDate { get; set; }
        public StringBuilder OldOrderDate { get; set; }
        public int RetailerGroupId { get; set; }
    }
}
