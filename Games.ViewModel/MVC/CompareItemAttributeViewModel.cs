using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class CompareDetailViewModel
    { 
        public SalesProductDetailViewModel Item1 { get; set; }
        public SalesProductDetailViewModel Item2 { get; set; }
        public SalesProductDetailViewModel Item3 { get; set; }
        public List<CompareItemAttributeViewModel> Attributes { get; set; }
    }


    public class CompareItemAttributeViewModel
    {
        public int AttributeID { get; set; }
        public int PDPAttributeCategoryID { get; set; }
        public string DisplayName { get; set; }
        public string ToolTipDesc { get; set; }
        public string Item1AttributeValue { get; set; }
        public string Item2AttributeValue { get; set; }
        public string Item3AttributeValue { get; set; }
        public int SortOrder { get; set; }
    }
}
