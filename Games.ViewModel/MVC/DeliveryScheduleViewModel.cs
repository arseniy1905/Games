using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class DeliveryScheduleViewModel: BaseAdminViewModel
    {
        public DeliveryScheduleViewModel()
        {
            Records = new List<DeliveryScheduleRecordViewModel>();
            FailedStoreExcelNumbers = new Dictionary<string, string>();
        }
        public DateTime? UploadedDate { get; set; }
        public string FileName { get; set; }
        public int DocumentId { get; set; }
        public int RecordsUploaded { get; set; }
        public string ErrorMessage { get; set; }

        [BindProperty(Name = "records")]
        public List<DeliveryScheduleRecordViewModel> Records { get; set; }
        public IFormFile AttachmentFile { get; set; }
        public IDictionary<string, string> FailedStoreExcelNumbers { get; set; }
    }
}
