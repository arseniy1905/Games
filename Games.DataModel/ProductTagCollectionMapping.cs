using System;

namespace Games.DataModel
{
    public class ProductTagCollectionMapping
    {
        public int Id { get; set; }
        public int CollectionId { get; set; }
        public ProductTagCollection ProductTagCollection { get; set; }
        public int ProductTagId { get; set; }
        public ProductTag ProductTag { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int StatusId { get; set; }
    }
}
