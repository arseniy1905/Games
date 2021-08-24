using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class CreateHomePageContentBlockViewModel
    {
        public int Id { get; set; }
        public int HomePageId { get; set; }
        public int DisplayOrder { get; set; }
        public int ContentBlockTemplateId { get; set; }
        public bool IsVisibile { get; set; }
        public string HeaderTitle { get; set; }
        public string FontFamily { get; set; }
        public string FontWeight { get; set; }
        public string FontColor { get; set; }
        public string ContentBody { get; set; }
        public bool IsBodyVisible { get; set; }
        public string ButtonLinkType { get; set; }
        public string ButtonColor { get; set; }
        public string ButtonText { get; set; }
        public string ButtonPreDefinedAction { get; set; }
        public string ButtonCustomLinkURL { get; set; }
        public bool IsPredefined { get; set; }
        public bool IsButtonVisible { get; set; }
        public string ButtonFontFamily { get; set; }
        public string ButtonFontWeight { get; set; }
        public string ButtonFontColor { get; set; }
        public string BackgroundColor { get; set; }
        public IFormFile ImageFile { get; set; }
        public string ImagePath { get; set; }
        public string ImageOriginalName { get; set; }
        public string ImageBase64String { get; set; }
        public string ImageFileName { get; set; }
        public string ImageFileNameEncrypted { get; set; }
        public string ImageBackgroundColor { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "yyyy-MM-dd HH:mm", null);
        public int CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int ModifyBy { get; set; }
        public string ContentAlignment { get; set; }
        public string ImageAlignment { get; set; }

    }
}
