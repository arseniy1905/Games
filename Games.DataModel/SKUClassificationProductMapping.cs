using System;

namespace Games.DataModel
{
    public class SKUClassificationProductMapping
    {
        public int Id { get; set; }
        public int SKUClassificationId { get; set; }
        public string SKU { get; set; }
        public int StatusID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
