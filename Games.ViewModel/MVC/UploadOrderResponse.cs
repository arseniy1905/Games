using Games.Common.Result;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class UploadOrderResponse : GenericResult
    {
        public UploadOrderResponse()
        {
            ErrorSkus = new List<UploadedOrderSKUInfo>();
        }
        public List<UploadedOrderSKUInfo> ErrorSkus { get; set; }
        public int NoOfItemsUploaded { get; set; }
        public int NoOfItemsInCart { get; set; }
    }
}
