using Games.ViewModel.Common;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class ShoppingCartViewModel : OrderBaseViewModel
    {
        public ShoppingCartViewModel()
        {
            Items = new List<ShoppingCartItemViewModel>();
            FlowThruItems = new List<ShoppingCartItemViewModel>();
            LowProbabilitySkuInfos = new List<LowProbabilityNotificationSKuInfoViewModel>();
            OutOfStockSkuInfos = new List<OutOfStockNotificationSKuInfoViewModel>();
        }
        public int TotalItems => Items.Count;
        public List<ShoppingCartItemViewModel> Items { get; set; }
        public List<ShoppingCartItemViewModel> FlowThruItems { get; set; }
        public List<LowProbabilityNotificationSKuInfoViewModel> LowProbabilitySkuInfos { get; set; }
        public List<OutOfStockNotificationSKuInfoViewModel> OutOfStockSkuInfos { get; set; }
        public PagingViewModel Paging { get; set; } = new PagingViewModel();
        public bool OnlyLowProbability { get; set; }
        public int OrderType { get; set; }
        public string SortBy { get; set; }
        public string SortOrder { get; set; }
        public int ReplenishmentOrderItemCount { get; set; }
        public int FlowThruOrderItemCount { get; set; }

    }
}
