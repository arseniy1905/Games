using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel.SP
{
    public class SpGetCompareItemAttributeDetails
    {
        public List<CompareItemAttributeDetailsView> Views { get; set; }
    }

    public class CompareItemAttributeDetailsView
    {
        public int AttributeID { get; set; }
        public int PDPAttributeCategoryID { get; set; }
        public string AtrributeName { get; set; }
        public string DisplayName { get; set; }
        public string ToolTipDesc { get; set; }
        public int SortOrder { get; set; }
        public string Item1AttributeValue { get; set; }
        public string Item2AttributeValue { get; set; }
        public string Item3AttributeValue { get; set; }
    }

    public class GetCompareItemAttributeDetailsParams
    {
        public GetCompareItemAttributeDetailsParams()
        {
            ItemNumber1 = "";
            ItemNumber2 = "";
            ItemNumber3 = "";
        }
        public string ItemNumber1 { get; set; }
        public string ItemNumber2 { get; set; }
        public string ItemNumber3 { get; set; }

    }
}
