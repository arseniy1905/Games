using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class RelatedProductItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public string PlantType { get; set; }
        public int PlantTypeId { get; set; }
        public string ImagePath { get; set; }
        public string ItemNumber { get; set; }
    }
}
