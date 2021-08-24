using System.Collections.Generic;


namespace Games.DataModel.SP
{
    public class SpGetSideShoppingCartOrderBreakdown
    {
        public SpGetSideShoppingCartOrderBreakdown()
        {
            Views = new List<SubCategoryLevelOrderStats>();
        }
        public List<SubCategoryLevelOrderStats> Views { get; set; }
    }

    public class SubCategoryLevelOrderStats
    {
        public string SubCategory { get; set; }
        public bool HideMaxOrderQty { get; set; }
        public int HighProbabilityPacks { get; set; }
        public int LowProbabilityPacks { get; set; }
        public decimal HighProbabilityPrice { get; set; }
        public decimal LowProbabilityPrice { get; set; }
        public decimal PercentageOftheOrder { get; set; }
    }

    public class SpGetSideShoppingCartOrderBreakdownParams
    {
        public long OrderID { get; set; }
    }

}
