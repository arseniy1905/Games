using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class ContactTypeMaster
    {
        public int Id { get; set; }
        public string ContactTypeName { get; set; }
        public string ContactTypeNameFr { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int StatusId { get; set; }
    }
}
