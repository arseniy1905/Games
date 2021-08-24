using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.API
{
    public class SendOrderEmailRequestViewModel
    {
        public int asnid { get; set; }
        public string salesorderid { get; set; }
        public string shipmentid { get; set; }
        public string invoiceid { get; set; }
        public List<string> recipients { get; set; }
    }

    public class SendOrderEmailResponseViewModel
    {
        public SendOrderEmailResponseViewModel()
        {
            status = "success";
            error = new ApiErrorInfo();
        }
        public string status { get; set; }
        public string method { get; set; }
        public ApiErrorInfo error { get; set; }
    }

    public class UpdateRetailerStatusRequestViewModel
    {
        public string retaileremail { get; set; }
    }

    public class ApiErrorInfo
    {
        public ApiErrorInfo()
        {
            errorcode = string.Empty;
            errormessage = string.Empty;
        }
        public string errorcode { get; set; }
        public string errormessage { get; set; }
    }
}
