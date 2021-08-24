using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class RelatedProduct
    {
        public int Id { get; set; }
        public int RelatedProductRuleID { get; set; }
        public RelatedProductRule RelatedProductRule { get; set; }
        public string RelatedItemNumber { get; set; }
        public string ItemNumber { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int OrderNumber { get; set; }
        public bool Hide { get; set; }

    }
}
