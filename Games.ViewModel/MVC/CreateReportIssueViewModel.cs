
using Games.Common.Resources;
using Games.DataModel;
using Games.ViewModel.Validation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Games.ViewModel.MVC
{
    public class CreateReportIssueViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RetailerId { get; set; }
        public int ItemId { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string FirstName { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string LastName { get; set; }
        public string RetailStoreAuthorization { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string Topic { get; set; }
        public int? CategoryId { get; set; }
        public IEnumerable<ItemCategoryMaster> ItemCategories { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string Subject { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string Question { get; set; }
        [JsonIgnore]
        [RestrictUploadDocument]
        public IFormFile IconFile { get; set; }
        public string IconFileName { get; set; }
        public string IconImageBase64String { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
