using System;

namespace Games.DataModel
{
    public class PDPItemAttributeMaster
    {
        public int Id { get; set; }
        public int PDPAttributeCategoryID { get; set; }
        public PDPItemAttributeCategoryMaster AttributeCategory { get; set; }
        public string AttributeName { get; set; }
        public string DisplayName { get; set; }
        public string DisplayNameFR { get; set; }
        public string ToolTipDesc { get; set; }
        public string ToolTipDescFR { get; set; }
        public int SortOrder { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
