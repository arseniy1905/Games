using System;

namespace Games.DataModel
{
    public class Banner
    {
        public int Id { get; set; }
        public string IconFilePath { get; set; }
        public int BannerColourId { get; set; }
        public BannerColour BannerColour { get; set; }
        public string BannerTitle { get; set; }
        public string BannerTitleFr { get; set; }
        public string Description { get; set; }
        public string DescriptionFr { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int StatusId { get; set; }
        public BannerStatusMaster Status { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public DateTime? PublishedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
