using Games.DataModel.SP.Result;
using Games.DataModel.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel.SP
{
    public class SpGetRelatedProducts
    {
        public SpGetRelatedProducts()
        {
            TotalRecords = new List<SpGetTaggedProductsResult>();
            Views = new List<RelatedProductItem>();
        }
        public List<SpGetTaggedProductsResult> TotalRecords { get; set; }
        public List<RelatedProductItem> Views { get; set; }
    }
}
