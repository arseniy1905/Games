using System.Collections.Generic;

namespace Games.DataModel.SP
{
    public class SpGetItemAttributeDetails
    {
        public List<ItemAttributeDetailsView> Views { get; set; }
    }

    public class ItemAttributeDetailsView
    {
        public int AttributeID { get; set; }
        public int PDPAttributeCategoryID { get; set; }
        public string AtrributeName { get; set; }
        public string DisplayName { get; set; }
        public string ToolTipDesc { get; set; }
        public int SortOrder { get; set; }
        public string AttributeValue { get; set; }
    }
    public class GetItemAttributeDetailsParams
    {
        public GetItemAttributeDetailsParams()
        {
            ItemNumber = "";
        }
        public string ItemNumber { get; set; }

    }

    public class SpSalesFlowGetRelatedProducts
    {
        public List<RelatedProductDetailView> Views { get; set; }
    }

    public class RelatedProductDetailView
    {
        public string ItemNumber { get; set; }
        public int RelatedProductRuleID { get; set; }
        public string RelatedItemNumber { get; set; }
        public string RuleName { get; set; }
        public string RuleDescription { get; set; }
    }

    public class SalesFlowGetRelatedProductsParams
    {
        public SalesFlowGetRelatedProductsParams()
        {
            ItemNumber = "";
        }
        public string ItemNumber { get; set; }
        public int PageType { get; set; }
    }
}
