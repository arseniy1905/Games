using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class EmailBlastRetailerGroup
    {
        public int Id { get; set; }
        public int EmailBlastId { get; set; }
        public int RetailerGroupId { get; set; }
        public int StatusID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? MocifiedBy { get; set; }
    }
}
