using Games.ViewModel.MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel
{
    public class CreateCollectionViewModel:BaseAdminViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Collection Name required.")]
        [MaxLength(255)]
        public string CollectionName { get; set; }
        public List<ProductTagCollectionCategoryViewModel> itemCategoryLists { get; set; }
        [Required(ErrorMessage = "Category is required.")]
        [Range(1, 10000, ErrorMessage = "Category Required.")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Description required.")]
        [MaxLength(1000)]
        public string Description { get; set; }
        public string Tag { get; set; }

        public bool HasDeleteCollectionPermission { get; set; }
        public bool HasUpdateCollectionPermission { get; set; }
        public IEnumerable<string> SkuTags { get; set; }

    }
}
