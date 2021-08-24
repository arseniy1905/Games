using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class RetailerLastOrderedItemViewModel
    {
        public string ItemNumber { get; set; }
        public string LastOrderedDate { get; set; }
        public int Quantity { get; set; }
    }
    public class RetailerOnStockNotificationItemsViewModel
    {
        public string ItemNumber { get; set; }
        public string SKU { get; set; }
    }

}
