using System;

namespace Games.DataModel
{
    public class ProductTagCollectionCategoryMaster
    {
        public int Id { get; set; }
        public string CollectionCategory { get; set; }
        public string CollectionCategoryFr { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CategoryOrder { get; set; }

    }
}
