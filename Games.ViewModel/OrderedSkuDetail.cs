using System.Collections.Generic;

namespace Games.ViewModel.MVC
{

    public class PlpOrderSkuInformation
    {
        public List<OrderedSkuDetail> CurrentOrderedSkus { get; set; }
        public List<RetailerLastOrderedItemViewModel> PreviouslyOrderedItems { get; set; }
        public List<RetailerOnStockNotificationItemsViewModel> OnStockNotificationItems { get; set; }
        public List<FavouriteItemViewModel> FavouriteItems { get; set; }
    }

    public class OrderedSkuDetail
    {
        public string ItemNumber { get; set; }
        public string Sku { get; set; }
        public int Quantity { get; set; }
    }
}
