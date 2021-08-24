using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class OrderDayChangedEmailDetail
    {
        public OrderDayChangedEmailDetail()
        {
            EmailAddress = "";
        }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
    }
}
