using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Common.State
{
    public class RetailerAddress
    {
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public int ProvinceId { get; set; }
        public string StoreName { get; set; }
    }
}
