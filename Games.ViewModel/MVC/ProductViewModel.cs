using System;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public int AlertId { get; set; }
        public string ItemNumber { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public int? CategoryId { get; set; }
        public string PlanType { get; set; }
        public DateTime? DateAdded { get; set; }
        public string ItemImage { get; set; }
        public List<ItemVariations> ItemVariations { get; set; }
        public int RelatedProductRuleID { get; set; }
        public string RelatedItemNumber { get; set; }
        public bool Hide { get; set; }
        public string RuleName { get; set; }
        public int RuleId { get; set; }
    }
}
