using System;

namespace Games.DataModel
{
    public class ProductTagItem
    {

        public int Id { get; set; }
        public int ProductTagId { get; set; }
        public ProductTag ProductTag { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public string SKU { get; set; }
    }
}
