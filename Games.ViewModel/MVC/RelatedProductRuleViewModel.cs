using Games.ViewModel.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class RelatedProductRuleListViewModel : BaseAdminViewModel
    {
        public RelatedProductRuleListViewModel()
        {
            RelatedProductRules = new List<RelatedProductRuleViewModel>();
            Paging = new PagingViewModel();
        }
        public PagingViewModel Paging { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<SelectListItem> PriorityList { get; set; }
        public List<RelatedProductRuleViewModel> RelatedProductRules { get; set; }
        public bool HasUpdateRelatedProductRulePermission { get; set; }
        public bool HasCreateRelatedProductRulePermission { get; set; }
        public bool HasDeleteRelatedProductRulePermission { get; set; }
    }
    public class RelatedProductRuleViewModel
    {
        public int Id { get; set; }
        public string RuleName { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? PriorityId { get; set; }

    }
}
