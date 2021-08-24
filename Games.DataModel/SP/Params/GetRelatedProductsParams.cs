using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel.SP.Params
{
    public class GetRelatedProductsParams
    {
        public GetRelatedProductsParams()
        {
            Rules = "";
        }
        public int UserId { get; set; }
        public int Language { get; set; }
        public int ProductRelationTypeId { get; set; }
        public string SearchWord { get; set; }
        public int PageSize { get; set; }
        public int CurrentPageNumber { get; set; }
        public string Rules { get; set; }
    }
}
