using System;
using System.Collections.Generic;

namespace Games.ViewModel.Common
{
    [Serializable]
    public class PagingViewModel
    {

        public PagingViewModel()
        {
            CurrentPageNumber = 1;
            PageSize = 10;
            PageSizeList = new List<int> { 10, 20, 50, 100 };
        }

        public int CurrentPageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public List<int> PageSizeList { get; set; }
        public int TotalPageCount
        {
            get
            {
                return (TotalRecords / PageSize) + ((TotalRecords % PageSize) == 0 ? 0 : 1);
            }
        }
        public string SortExpression { get; set; }
    }
}

