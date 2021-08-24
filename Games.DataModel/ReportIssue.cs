using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class ReportIssue
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RetailerId { get; set; }
        public int ItemId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RetailStoreAuthorization { get; set; }
        public string Email { get; set; }
        public string Topic { get; set; }
        public int CategoryId { get; set; }
        public string Subject { get; set; }
        public string Question { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
