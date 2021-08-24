using System;

namespace Games.DataModel
{
    public class RetailerStageStatus
    {
        public int Id { get; set; }
        public int StageId { get; set; }
        public int StatusId { get; set; }
        public int StageStatusId { get; set; }
        public int CreatedBy { get; set; }
        public int RetailerId { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public UserInfoStage UserInfoStage { get; set; }
        public Retailer Retailer { get; set; }
    }
}
