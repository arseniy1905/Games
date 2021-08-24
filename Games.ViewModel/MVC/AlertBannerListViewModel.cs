using Games.DataModel;
using System;

namespace Games.ViewModel.MVC
{
    public class AlertBannerListViewModel
    {
        public int Id { get; set; }
        public User Author { get; set; }
        public BannerStatusMaster BannerStatus { get; set; }
        public int BannerStatusId { get; set; }
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? PublishedDate { get; set; }

    }
}
