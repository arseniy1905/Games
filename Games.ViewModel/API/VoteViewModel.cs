using Games.ViewModel.MVC;
using System.Collections.Generic;

namespace Games.ViewModel.API
{
    public class VoteViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string VoteButtonText { get; set; }
        public IEnumerable<PrizeViewModel> Prizes { get; set; }
        public string PrizesTitle { get; set; }
        public IEnumerable<int> Years { get; set; }
        public IEnumerable<int> Quarters { get; set; }
        public string QuarterPrefix { get; set; }
        public string SortByYearText { get; set; }
        public string SortByQuarterText { get; set; }
        public string ViewRulesText { get; set; }
        public int Year { get; set; }
        public int Quarter { get; set; }
        public string Rules { get; set; }
    }
}
