using Games.DataModel.SP.Result;
using Games.DataModel.Views;
using System.Collections.Generic;

namespace Games.DataModel.SP
{
    public class SpGetTaggedProducts
    {
        public SpGetTaggedProducts()
        {
            TotalRecords = new List<SpGetTaggedProductsResult>();
            Views = new List<TaggedProductItemView>();
        }
        public List<SpGetTaggedProductsResult> TotalRecords { get; set; }
        public List<TaggedProductItemView> Views { get; set; }
    }
}
