using Games.Common.Resources;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Games.ViewModel.MVC
{
    public class CreatePasswordViewModel
    {
        
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(ResourceType = typeof(CommonResources), Name = "FirstName")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(ResourceType = typeof(CommonResources), Name = "LastName")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "A phone number is required.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Phone Number")]
        [MaxLength(10)]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Phone Number.")]
        [Display(ResourceType = typeof(CommonResources), Name = "PhoneNumber")]
        public string ContactNumber
        {
            get
            {
                return _ContactNumber;
            }
            set => _ContactNumber = string.Join("", (value + "").Where(x => Char.IsDigit(x)).Take(10));
        }
        private string _ContactNumber;
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool EmailExist { get; set; }
        public string CROLNumber { get; set; }
        public string Token { get; set; }
        public int RequestId { get; set; }
        public bool IsValidToken { get; set; }
        public int RetailerId { get; set; }
        public int RetailerStoreId { get; set; }
        public int RequestType { get; set; }
        public int UserId { get; set; }
    }
}
