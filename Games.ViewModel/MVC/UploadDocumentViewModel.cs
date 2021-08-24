using Games.ViewModel.Validation;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Games.ViewModel.MVC
{
    public class UploadDocumentViewModel
    {
        public int Id { get; set; }
        public int? RetailerStoreId { get; set; }
        [JsonIgnore]
        [RestrictUploadDocument]
        public IFormFile Document { get; set; }
        public string Name { get; set; }
        public string DocumentType { get; set; }
        public string FileType { get; set; }
        public string FileTypeEx { get; set; }
        public int? ImageSize { get; set; }
        public int? ImageResolution { get; set; }
        public string FileRestriction { get; set; }
        public string Description { get; set; }
        public string OriginalFileName { get; set; }
        public string DisplayRestriction { get; set; }
        public string FileSize { get; set; }
        public string FileUploadErrorMsg { get; set; }
        public string SavedFilePathName { get; set; }
    }
}
