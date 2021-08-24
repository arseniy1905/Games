using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class ProductDetailViewModel:BaseAdminViewModel
    {
        public ProductDetailViewModel()
        {
            RelatedProductData = "";
            HideRelatedProductInfo = new List<HideRelatedProductInfo>();
        }
        public string ItemNumber { get; set; }
        [Required]
        [MaxLength(255)]
        public string ItemName { get; set; }
        [Required]
        [MaxLength(255)]
        public string Brand { get; set; }
        public string ProductImagePath { get; set; } = "/images/image-not-available.png";
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Category { get; set; }
        public int PlantTypId { get; set; }
        public IEnumerable<SelectListItem> PlantType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int Unlimited { get; set; }
        public List<HideRelatedProductInfo> HideRelatedProductInfo { get; set; }
        public string RelatedProductData { get; set; }

      
     
    }
    public class HideRelatedProductInfo
    {
        public int RelatedProductId { get; set; }
        public bool Hide { get; set; }
    }
}
