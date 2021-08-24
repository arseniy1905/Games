using Games.Common.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class RelatedProductRulesViewModel:BaseAdminViewModel
    {
        public RelatedProductRulesViewModel()
        {
            DataRuleSourceList = new List<ProductDataRuleViewModel>();
            DataRuleRelatedList = new List<ProductDataRuleViewModel>();
        }
        public int Id { get; set; }
        public bool HasCreateRulePermission { get; set; }
        public bool HasEditRulePermission { get; set; }
        public bool HasDeleteRulePermission { get; set; }
        [Required(ErrorMessageResourceType = typeof(CommonResources), ErrorMessageResourceName = "EnterRuleName")]
        public string RuleName { get; set; }
        [Required(ErrorMessageResourceType = typeof(CommonResources), ErrorMessageResourceName = "EnterRuleDescription")]
        public string Description { get; set; }
        public List<ProductDataRuleViewModel> DataRuleSourceList { get; set; }
        public List<ProductDataRuleViewModel> DataRuleRelatedList { get; set; }
        public bool? IsSaved { get; set; }
        public string DataRulesResultJson { get; set; }
        public int ProductRelationTypeId { get; set; }
        public int PriorityOrderId { get; set; }
    }
}
