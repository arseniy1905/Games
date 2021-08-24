using Games.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class CreateHomePageViewModel : BaseAdminViewModel
    {
        public CreateHomePageViewModel()
        {
            RetailerGroups = new List<RetailerGroupViewModel>();
            RetailerGroupIds = new List<int>();
            CreateHomePageFooterList = new List<CreateHomePageFooterViewModel>();
            CreateHomePageCTAList = new List<CreateHomePageCTAViewModel>();
            CreateHomePageContentBlockList = new List<CreateHomePageContentBlockViewModel>();
            HomePageTemplateList = new List<HomePageTemplateMaster>();
            
        }
        public int Id { get; set; }
        public string HomePageName { get; set; }
        public string CTABackgroundColor { get; set; }
        public string ContentBlockBackgroundColor { get; set; }
        public string FooterBackgroundColor { get; set; }
        public DateTime HomePageStartDate { get; set; } = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "yyyy-MM-dd HH:mm", null);
        public DateTime PageLoadTime { get; set; } = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "yyyy-MM-dd HH:mm", null);
        public DateTime? HomePageEndDate { get; set; } = DateTime.ParseExact(DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd HH:mm"), "yyyy-MM-dd HH:mm", null);
        public int TemplateId { get; set; }
        public int StatusId { get; set; }
        public int PageStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public CreateHomePageCTAViewModel CreateHomePageCTAViewModel { get; set; }
        public CreateHomePageContentBlockViewModel CreateHomePageContentBlockViewModel { get; set; }
        public List<CreateHomePageCTAViewModel> CreateHomePageCTAList { get; set; }
        public List<CreateHomePageContentBlockViewModel> CreateHomePageContentBlockList { get; set; }
        public List<CreateHomePageFooterViewModel> CreateHomePageFooterList { get; set; }
        public IEnumerable<HomePageTemplateMaster> HomePageTemplateList { get; set; }
        public bool HasPublishBannerPermission { get; set; }
        public IEnumerable<int> RetailerGroupIds { get; set; }
        public IEnumerable<RetailerGroupViewModel> RetailerGroups { get; set; }
    }
}
