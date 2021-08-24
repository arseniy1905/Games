using System;

namespace Games.DataModel
{
    public class PDPItemAttributeCategoryMaster
    {
        public int Id { get; set; }
        public string AttributeCategory { get; set; }
        public string AttributeCategoryFR { get; set; }
        public int SortOrder { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
    }

}
