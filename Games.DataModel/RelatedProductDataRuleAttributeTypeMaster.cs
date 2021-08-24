using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class RelatedProductDataRuleAttributeTypeMaster
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string DataTypeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int CreatedBy { get; set; }
        public int StatusId { get; set; }
    }
}
