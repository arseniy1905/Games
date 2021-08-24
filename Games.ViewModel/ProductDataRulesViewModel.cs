using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class ProductDataRulesViewModel
    {
        public ProductDataRulesViewModel()
        {
            Rules = new List<ProductDataRuleViewModel>();

        }
        public List<ProductDataRuleViewModel> Rules { get; set; }
        
    }
}
