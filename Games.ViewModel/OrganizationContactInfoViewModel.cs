using Games.Common.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class OrganizationContactInfoViewModel
    {
        public OrganizationContactInfoViewModel()
        {
            ContactTypeList = new List<SelectListItem>();
            FirstName = "";
            LastName = "";
            ContactNumber = "";
            ContactEmail = "";

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _phoneNumber;
        [MaxLength(14)]
        [DataType(DataType.PhoneNumber, ErrorMessageResourceName = "InvalidPhoneNumber", ErrorMessageResourceType = typeof(CommonResources))]
        public string ContactNumber 
        {
            get
            {
                return _phoneNumber;
            }
            set => _phoneNumber = string.Join("", (value + "").Where(x => char.IsDigit(x)).Take(10));
        }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){1,})+)$", ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(256)]
        public string ContactEmail { get; set; }
        public int ContactTypeId { get; set; }
        public List<SelectListItem> ContactTypeList { get; set; }
        public int RetailerOrganizationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int StatusId { get; set; }
    }
}
