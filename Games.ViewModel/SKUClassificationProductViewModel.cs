using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class SKUClassificationProductViewModel : ProductViewModel
    {
        public SKUClassificationProductViewModel()
        {
            ItemVariations = new List<ItemVariationSKUClissificationViewModel>();
        }
        public bool ItemSelected { get; set; }
        public new List<ItemVariationSKUClissificationViewModel> ItemVariations { get; set; }

    }
}
