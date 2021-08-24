using Games.Common.Enums;
using Games.Common.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Games.ViewModel.MVC
{
    public class ProductSkuDetailViewModel
    {
        public int Id { get; set; }
        public string ItemBarcode { get; set; }
        public string InventSizeId { get; set; }
        public string InventColorId { get; set; }
        public string ColorId { get; set; }
        public string InventStyleId { get; set; }
        public int OnHandQuantity { get; set; }
        public string Sku { get; set; }
        public string FulfilmentType { get; set; }
        public bool IsFlowthruSku
        {
            get
            {
                return FulfilmentType == EnumFulfilmentType.FlowThru.GetDescription();
            }
        }
        public decimal? UnitPrice { get; set; }
        public decimal? PackSize { get; set; }
        public bool ShowInSalesFlow { get; set; }
        public IEnumerable<string> SkuTags { get; set; }
        public string StringifiedSkuTags
        {
            get
            {
                if (SkuTags != null)
                {
                    return string.Join(", ", SkuTags);
                }
                return string.Empty;
            }
            set
            {
                SkuTags = string.IsNullOrEmpty(value) ? null : value.Split(',').Select(x => x);
            }
        }
        public bool TagSearchable { get; set; }
        public string AssortmentId { get; set; }
        public IEnumerable<SelectListItem> Assortments { get; set; }
        public IEnumerable<ProductVariationsSkuImageViewModel> ItemImages { get; set; }
        public IList<int> ImageSortOrder { get; set; }
        public bool Unlimited { get; set; }
    }
}
