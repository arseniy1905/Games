using System.Collections.Generic;

namespace Games.DataModel
{
    public class UserInfoStage
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string Name { get; set; }
        public string NameFr { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string StepNumber { get; set; }
        public string StepNumberFr { get; set; }
        public StatusMaster Status { get; set; }
        public List<RetailerStageStatus> RetailerStageStatuses { get; set; }
    }
}
