using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class CreateHomePageFooterLinkViewModel
    {
        public int Id { get; set; }
        public int FooterCategoryId { get; set; }
        public int LinkType { get; set; }
        public IFormFile LinkImageFile { get; set; }
        public string LinkImagePath { get; set; }
        public string LinkImageBase64String { get; set; }
        public string LinkImageFileName { get; set; }
        public string LinkImageOriginalName { get; set; }
        public string LinkImageFileNameEncrypted { get; set; }
        public string URLLink { get; set; }
        public string URLLinkName { get; set; }        
        public string LinkDisplayOrder { get; set; }
        public int StatusId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
