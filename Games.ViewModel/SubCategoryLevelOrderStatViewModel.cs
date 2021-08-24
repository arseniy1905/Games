using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class SideShoppingCartInfoViewModel
    {
        public string OrderWeight { get; set; }
        public string OrderTotal { get; set; }
        public string SalesTax { get; set; }
        public int TotalPacks { get; set; }
        public int Pallets { get; set; }
        public string ShippingFee { get; set; }
        public List<SubCategoryLevelOrderStatViewModel> SubaCtegoryLevelStats { get; set; }
        public List<SubCategoryLevelOrderStatViewModel> SubCategoryLevelStatsHideMaxOrderQty { get; set; }
    }
    public class SubCategoryLevelOrderStatViewModel
    {
        public string SubCategory { get; set; }
        public bool HideMaxOrderQty { get; set; }
        public int HighProbabilityPacks { get; set; }
        public int LowProbabilityPacks { get; set; }
        public string HighProbabilityPrice { get; set; }
        public string LowProbabilityPrice { get; set; }
        public string PercentageOftheOrder { get; set; }
    }

}
