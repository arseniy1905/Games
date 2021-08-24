using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class RelatedProductRule
    {
        public int Id { get; set; }
        public string RuleName { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? Priority_OrderId { get; set; }
    }
}
