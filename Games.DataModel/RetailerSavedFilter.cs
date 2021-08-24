using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class RetailerSavedFilter
    {
        public int Id { get; set; }
        public int RetailerId { get; set; }
        public string FilterName { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public User CreatedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public List<RetailerSavedFilterDetail> FilterDetails { get; set; }

    }
    public class RetailerSavedFilterDetail
    {
        public int Id { get; set; }
        public RetailerSavedFilter SavedFilter { get; set; }
        public int SavedFilterId { get; set; }
        public int PLPFilterTypeId { get; set; }
        public PDPFilterTypeMaster PLPFilterType { get; set; }
        public string FilterValue1 { get; set; }
        public string FilterValue2 { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }

    public class PDPFilterTypeMaster
    {
        public int Id { get; set; }
        public string FilterType { get; set; }
        public string DataType { get; set;  }
        public string PrependText { get; set; }
        public string AppendText { get; set; }
        public bool IsMultiple { get; set; }
        public int StatusId { get; set; }
    }
}
