using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class SelectStoreViewModel: BaseViewModel
    {
        public string UserName { get; set; }
        public List<SelectStoreStoreInfoiewModel> StoreList { get; set; }
    }

    public class SelectStoreStoreInfoiewModel { 
        public int RetailerID { get; set; }
        public int StoreID { get; set; }
        public string RetailerName { get; set; }
        public string CROLNumber { get; set; }
        public string CreatedDate { get; set; }

        public string RetailerAddress { get; set; }
        public string RetailerAddressShort { get; set; }
        public int RetailerStatusID { get; set; }
        public int RetailerStoreID { get; set; }
    }

}
