using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class ContactInfoViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public int ContactTypeId { get; set; }
        public int RetailerOrganizationId { get; set; }
        public int StatusId { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
