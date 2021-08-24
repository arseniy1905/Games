using System;

namespace Games.DataModel
{
    public class ProductTagTypeMaster
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public StatusMaster Status { get; set; }
    }
}