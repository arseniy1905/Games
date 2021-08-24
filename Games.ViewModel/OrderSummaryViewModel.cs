using Games.ViewModel.Common;
using System.Collections.Generic;
using System.Linq;

namespace Games.ViewModel.MVC
{
    public class OrderSummaryViewModel
    {
        public OrderSummaryViewModel()
        {
            HighProbabilityPacks = new List<OrderSubCategoryViewModel>();
            HighProbabilityValues = new List<OrderSubCategoryViewModel>();
            LowProbabilityPacks = new List<OrderSubCategoryViewModel>();
            LowProbabilityValues = new List<OrderSubCategoryViewModel>();
            CannabisWeightValues = new List<OrderSubCategoryViewModel>();
            //PacksHiddenMaxOrderQty = new List<OrderSubCategoryViewModel>();
            //ValuesHiddenMaxOrderQty = new List<OrderSubCategoryViewModel>();
            ReplenishmentOrderItemDet = new List<OrderSubCategoryViewModel>();
            FlowThruOrderItemDet = new List<OrderSubCategoryViewModel>();
            FlowThruCannabisWeightValues = new List<OrderSubCategoryViewModel>();
        }
        public decimal Weight { get; set; }
        public decimal OrderTotal { get; set; }
        public decimal SalesTax { get; set; }
        public int TotalPacks { get; set; }
        public int TotalReplenishmentPacks { get; set; }
        public int TotalFlowThruPacks { get; set; }
        public int Pallets { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal TotalCost { get; set; }
        public decimal AccountBalance { get; set; }
        public List<OrderSubCategoryViewModel> HighProbabilityPacks { get; set; }
        public List<OrderSubCategoryViewModel> HighProbabilityValues { get; set; }
        public List<OrderSubCategoryViewModel> LowProbabilityPacks { get; set; }
        public List<OrderSubCategoryViewModel> LowProbabilityValues { get; set; }
        public List<OrderSubCategoryViewModel> CannabisWeightValues { get; set; }
        public List<OrderSubCategoryViewModel> FlowThruCannabisWeightValues { get; set; }
        //public List<OrderSubCategoryViewModel> PacksHiddenMaxOrderQty { get; set; }
        //public List<OrderSubCategoryViewModel> ValuesHiddenMaxOrderQty { get; set; }
        public List<OrderSubCategoryViewModel> ReplenishmentOrderItemDet { get; set; }
        public List<OrderSubCategoryViewModel> FlowThruOrderItemDet { get; set; }

        public int TotalItems => OrderSummaryItems.Count();
        public IEnumerable<OrderSummaryItemViewModel> OrderSummaryItems { get; set; }
        public PagingViewModel Paging { get; set; } = new PagingViewModel();
    }
}
