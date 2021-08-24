using Games.Common.Enums;
using Games.DataModel;
using Games.ViewModel.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class AccountBalanceViewModel : BaseViewModel
    {
        public AccountBalanceViewModel()
        {
            Paging = new PagingViewModel();
        }
        public List<AccountBalanceListViewModel> AccountBalanceList { get; set; }
        public PagingViewModel Paging { get; set; }

        public List<SelectListItem> StoreList { get; set; }

        public int StoreId { get; set; }

    }

    public class AccountBalanceListViewModel
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Invoice { get; set; }
        public decimal? Amount { get; set; }
        public string Reference { get; set; }
        public decimal? AccountBalance { get; set; }
    }

    public class RetailerHomeViewModel : BaseViewModel
    {
        public int OrderMode { get; set; }
        public string CTABackgroundColor { get; set; }
        public string ContentBlockBackgroundColor { get; set; }
        public string FooterBackgroundColor { get; set; }
        public CreateHomePageViewModel HomePageInfo { get; set; }
        public List<HomeCarouselDetailViewModel> CarouselItems { get; set; }
        public List<ConfigureHeroBannerListViewModel> CarouselBanner { get; set; }
        public List<RetailerHomePageContentBlockViewModel> HomePageContentBlocks { get; set; }
        public RetailerHomeViewModel()
        {
            OrderMode = (int)EnumOrderMode.NewOrderMode;
            HomePageInfo = new CreateHomePageViewModel();
            HomePageContentBlocks = new List<RetailerHomePageContentBlockViewModel>();
            //CTAItems = new List<CreateHomePageCTAViewModel>();
            //ContentBlockItems = new List<CreateHomePageContentBlockViewModel>();
        }
        //public List<CreateHomePageCTAViewModel> CTAItems { get; set; }
        //public List<CreateHomePageContentBlockViewModel> ContentBlockItems { get; set; }

    }

    public class RetailerHomePageContentBlockViewModel
    {
        public int Id { get; set; }
        public int ContentBlockTemplateID { get; set; }
        public string ContentBlockHtml { get; set; }
        public int NoOfBlockInRow { get; set; }
        public bool ShowContentBlock { get; set; }
    }

    public class HomeCarouselDetailViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionHtml { get; set; }
        public string ImageUrl { get; set; }
        public int SortOrder { get; set; }
    }

    public class OrderSubmitValidationViewModel
    {
        public bool IsValid { get; set; }
        public int ErrorID { get; set; }
        public string Message { get; set; }
    }
    public class AccountBalancePdfInfo
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string RetailerCode { get; set; }
        public string RetailerName { get; set; }
        public string City { get; set; }
        public string ProvinceCode { get; set; }
        public string PostalCode { get; set; }
        public string RetailerAddress { get; set; }
        public double StatementPeriod { get; set; }
        public List<AccountBalancePDF> Transactions { get; set; }

    }

    public class AccountBalancePDF
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Invoice { get; set; }
        public decimal? Amount { get; set; }
        public string Description { get; set; }
        public decimal? AccountBalance { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }

    }
}
