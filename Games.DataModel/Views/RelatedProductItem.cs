using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel.Views
{
    public class RelatedProductItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public string PlantType { get; set; }
        public int PlantTypeId { get; set; }
        public string ImagePath { get; set; }
        public string ItemNumber { get; set; }
        public string RuleName { get; set; }
        public bool Hide { get; set; }
        public string RelatedItemNumber { get; set; }
        public int OrderNumber { get; set; }
    }
}
