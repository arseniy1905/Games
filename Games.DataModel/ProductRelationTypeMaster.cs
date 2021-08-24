using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class ProductRelationTypeMaster
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
