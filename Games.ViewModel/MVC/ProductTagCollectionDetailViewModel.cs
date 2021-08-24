using Games.DataModel;
using System;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class ProductTagCollectionListViewModel
    {
        public int Id { get; set; }
        public string CollectionName { get; set; }
        public string CollectionDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
        public ProductTagCollectionCategoryViewModel Category { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int StatusId { get; set; }
        public IList<ProductTagCollectionMapping> ProductTagMappings { get; set; }
        public bool HasUpdateCollectionPermission { get; set; }
        public bool HasCreateCollectionPermission { get; set; }
        public bool HasDeleteCollectionPermission { get; set; }
        public int NoOfProducts { get; set; }
    }
}
