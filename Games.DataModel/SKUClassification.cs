using System;

namespace Games.DataModel
{
    public class SKUClassification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameFr { get; set; }
        public string Description { get; set; }
        public decimal Divisor { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int DivisorTypeID { get; set; }
        public bool? IsDefault { get; set; }
    }
}
