using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class RelatedProductDataRuleAttributeSignMaster
    {
        public int Id { get; set; }
        public int AttributeId { get; set; }
        public int SignId { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int StatusId { get; set; }
    }
}
