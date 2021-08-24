using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class RequestInfoDetailViewModel
    {
        public List<SelectListItem> RequestTypeList { get; set; }
        public List<SelectListItem> RequestStatusList { get; set; }
        public List<SelectListItem> RetailerList { get; set; }
        public RequestInfoDetailViewModel()
        {
            RequestTypeList = new List<SelectListItem>();
            RequestStatusList = new List<SelectListItem>();
            RetailerList = new List<SelectListItem>();
        }

        public int Id { get; set; }
        public int RequestTypeID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CROLNumber { get; set; }
        public int RequestStatusID { get; set; }
        public int RetailerID { get; set; }
        public string RetailerName { get; set; }
        public string RSANumber { get; set; }
        public string UploadedFileName { get; set; }
        public string UploadedFileURL { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int LastUpdateBy { get; set; }

    }
}