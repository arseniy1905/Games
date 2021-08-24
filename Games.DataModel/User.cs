using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Games.DataModel
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public int StatusId { get; set; }
        public UserStatusMaster Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public bool LockoutEnabled { get; set; }
        public bool? IsOrganizationAdmin { get; set; }        
        public string PhoneNumber { get; set; }
        public int AccessFailedCount { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string FullName { get; set; }

        public int? UserTypeId { get; set; }
        public UserType UserType { get; set; }

        //public int StoreId { get; set; }
        public Store Store { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string EmployeeId { get; set; }

        public string StatusMessage { get; set; }
        //public int? RetailerID { get; set; }
        public string UploadedImagePath { get; set; }
        public string OriginalImagePath { get; set; }
        public DateTime? LastLoggedIn { get; set; }
        public int? LoginCount { get; set; }
        public int? UserRoleId { get; set; }
        public bool? IsBRT { get; set; }
        public int? BRTRole { get; set; }
        public int? RetailerOrganizationId { get; set; }
        public RetailerOrganization RetailerOrganization { get; set; }
        public UserPreference Preference { get; set; }
        public UserRole UserRole { get; set; }
        //public Retailer Retailer { get; set; }
        [NotMapped]
        public string UserName
        {
            get
            {
                return $"{ FirstName } { LastName }".Replace("null", "").Trim();
            }
        }
        [NotMapped]
        public string RetailerAddress { get; set; }

        public ICollection<UrlToken> UrlTokens { get; set; }
        public ICollection<RetailerUserMapping> RetailerUserMappings { get; set; }
        //public int PLPViewMode { get; set; }
        //public int PLPPriceMode { get; set; }

    }
    public class UserPreference
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        //public int PLPViewMode { get; set; }
        //public int PLPPriceMode { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
