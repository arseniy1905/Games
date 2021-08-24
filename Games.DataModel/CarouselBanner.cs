using System;

namespace Games.DataModel
{
    public class CarouselBanner
    {
        public int Id { get; set; }
        public string ImageFilePath { get; set; }
        public string BannerName { get; set; }
        public string BannerNameFr { get; set; }
        public string BannerTitle { get; set; }
        public string BannerTitleFr { get; set; }
        public string Description { get; set; }
        public string DescriptionFr { get; set; }
        public string ButtonText { get; set; }
        public string ButtonTextFr { get; set; }
        public string ButtonLink { get; set; }
        public bool IsButtonVisible { get; set; }
        public int BannerDisplayOrder { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int StatusId { get; set; }
        public BannerStatusMaster Status { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
