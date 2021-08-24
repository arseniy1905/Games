using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class RetailerFilterSetViewModel
    {
        public int Id { get; set; }
        public int RetailerId { get; set; }
        public string FilterName { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedByName { get; set; }
        public List<RetailerSavedFilterDetailViewModel> FilterDetails { get; set; }
        public RetailerFilterSetViewModel()
        {
            FilterDetails = new List<RetailerSavedFilterDetailViewModel>();
        }
    }
    public class RetailerSavedFilterDetailViewModel
    {
        public int FilterTypeID { get; set; }
        public string FilterType { get; set; }
        public string DataType { get; set; }
        public bool IsMultiple { get; set; }
        public string FilterValue1 { get; set; }
        public string FilterValue2 { get; set; }
        public string PrependText { get; set; }
        public string AppendText { get; set; }
    }
}
