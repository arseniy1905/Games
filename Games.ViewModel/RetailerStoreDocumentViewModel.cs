using Games.DataModel;
using System;

namespace Games.ViewModel.MVC
{
    public class RetailerStoreDocumentViewModel
    {
        public int Id { get; set; }
        public int RetailerId { get; set; }
        public int? RetailerStoreId { get; set; }
        public DocumentTypeMaster DocumentType { get; set; }
        public int DocumentTypeId { get; set; }
        public string OriginalFileName { get; set; }
        public string SavedFileName { get; set; }
        public string FileSize { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public StatusMaster Status { get; set; }
    }
}
