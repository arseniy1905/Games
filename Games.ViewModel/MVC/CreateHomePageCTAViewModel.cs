using Microsoft.AspNetCore.Http;    
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class CreateHomePageCTAViewModel
    {
        public int Id { get; set; }
        public int HomePageId { get; set; }
        public int CTATemplateId { get; set; }
        public bool IsVisibile { get; set; }
        public string CTATitle { get; set; }
        public string CTAFontFamily { get; set; }
        public string CTAFontWeight { get; set; }
        public string CTAFontColor { get; set; }
        public string URLLink { get; set; }
        public string HoverText { get; set; }
        public int DisplayOrder { get; set; }
        public IFormFile IconFile { get; set; }
        public string IconPath { get; set; }
        public string IconOriginalName { get; set; }
        public string IconImageBase64String { get; set; }
        public string IconFileName { get; set; }
        public string IconFileNameEncrypted { get; set; }
        public bool IsIconVisible { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "yyyy-MM-dd HH:mm", null);
        public int CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int ModifyBy { get; set; }
        public string BackgroundColor { get; set; }
    }
}
