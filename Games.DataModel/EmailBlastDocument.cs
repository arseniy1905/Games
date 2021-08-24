using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class EmailBlastDocument
    {
        public int Id { get; set; }
        public int EmailBlastId { get; set; }
        public string OriginalFileName { get; set; }
        public string SavedFileName { get; set; }
        public string FileSize { get; set; }
        public int StatusID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? MocifiedBy { get; set; }
    }

    public class EmailBlastRetailerEmailInfo { 
        public int RetailerId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public List<string> EmailAddress { get; set; }
    }

}
