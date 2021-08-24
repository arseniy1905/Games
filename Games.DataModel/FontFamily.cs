using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class FontFamilyMaster
    {
        public int Id { get; set; }
        public string FontFamily { get; set; }
        public string FontFamilyValue { get; set; }
        public int StatusId { get; set; }
    }
    public class ContentAlignmentMaster
    {
        public int Id { get; set; }
        public string Alignment { get; set; }
        public string AlignmentValue { get; set; }
        public int StatusId { get; set; }
    }
    public class ImageAlignmentMaster
    {
        public int Id { get; set; }
        public string Alignment { get; set; }
        public string AlignmentValue { get; set; }
        public int StatusId { get; set; }
    }    
    public class FontWeightMaster
    {
        public int Id { get; set; }
        public string FontWeight { get; set; }
        public string FontWeightValue { get; set; }
        public int StatusId { get; set; }
    }

    public class HomePagePredefinedActionMaster
    {
        public int Id { get; set; }
        public int? PermissionId { get; set; }
        public string PredefinedAction { get; set; }
        public string PredifinedActionLink { get; set; }
        public int StatusId { get; set; }
    }

}
