using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class RelatedProductDataRuleAttributeMaster
    {
        public int Id { get; set; }
        public string AttributeName { get; set; }
        public int AttributeLevelId { get; set; }
        public string FieldName { get; set; }
        public int AttributeTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int? CreatedBy { get; set; }
        public int StatusId { get; set; }
    }
}
