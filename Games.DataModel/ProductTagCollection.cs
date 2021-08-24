using System;
using System.Collections.Generic;

namespace Games.DataModel
{
    public class ProductTagCollection
    {
        public int Id { get; set; }
        public string CollectionName { get; set; }
        public string CollectionDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
        public ProductTagCollectionCategoryMaster Category { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int StatusId { get; set; }
        public ICollection<ProductTagCollectionMapping> ProductTagMappings { get; set; }
    }
}
