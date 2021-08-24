using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class RetailerOrganizationContactInfo
    {
        public int Id { get; set; }
        public int RetailerOrganizationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public int ContactTypeId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int StatusId { get; set; }
    }
}
