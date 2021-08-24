using Games.DataModel;
using System;

namespace Games.ViewModel.MVC
{
    public class ConfigureHeroBannerListViewModel
    {
        public int Id { get; set; }
        public User Author { get; set; }
        public BannerStatusMaster BannerStatus { get; set; }
        public int BannerStatusId { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? EndDateTime { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int BannerDisplayOrder { get; set; }
        public string ImageFileBase64String { get; set; }
        public string ButtonText { get; set; }
        public string ButtonLink { get; set; }
        public bool IsButtonVisible { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
