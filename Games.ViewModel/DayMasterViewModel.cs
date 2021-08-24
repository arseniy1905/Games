using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class DayMasterViewModel
    {
        public DayMasterViewModel()
        {
            TimeInterval = new List<string>();

            TimeInterval.Add("12:00 AM");
            TimeInterval.Add("12:30 AM");
            TimeInterval.Add("01:00 AM");
            TimeInterval.Add("01:30 AM");
            TimeInterval.Add("02:00 AM");
            TimeInterval.Add("02:30 AM");
            TimeInterval.Add("03:00 AM");
            TimeInterval.Add("03:30 AM");
            TimeInterval.Add("04:00 AM");
            TimeInterval.Add("04:30 AM");
            TimeInterval.Add("05:00 AM");
            TimeInterval.Add("05:30 AM");
            TimeInterval.Add("06:00 AM");
            TimeInterval.Add("06:30 AM");
            TimeInterval.Add("07:00 AM");
            TimeInterval.Add("07:30 AM");
            TimeInterval.Add("08:00 AM");
            TimeInterval.Add("08:30 AM");
            TimeInterval.Add("09:00 AM");
            TimeInterval.Add("09:30 AM");
            TimeInterval.Add("10:00 AM");
            TimeInterval.Add("10:30 AM");
            TimeInterval.Add("11:00 AM");
            TimeInterval.Add("11:30 AM");
            TimeInterval.Add("12:00 PM");
            TimeInterval.Add("12:30 PM");
            TimeInterval.Add("01:00 PM");
            TimeInterval.Add("01:30 PM");
            TimeInterval.Add("02:00 PM");
            TimeInterval.Add("02:30 PM");
            TimeInterval.Add("03:00 PM");
            TimeInterval.Add("03:30 PM");
            TimeInterval.Add("04:00 PM");
            TimeInterval.Add("04:30 PM");
            TimeInterval.Add("05:00 PM");
            TimeInterval.Add("05:30 PM");
            TimeInterval.Add("06:00 PM");
            TimeInterval.Add("06:30 PM");
            TimeInterval.Add("07:00 PM");
            TimeInterval.Add("07:30 PM");
            TimeInterval.Add("08:00 PM");
            TimeInterval.Add("08:30 PM");
            TimeInterval.Add("09:00 PM");
            TimeInterval.Add("09:30 PM");
            TimeInterval.Add("10:00 PM");
            TimeInterval.Add("10:30 PM");
            TimeInterval.Add("11:00 PM");
            TimeInterval.Add("11:30 PM");
        }
        public int ID { get; set; }
        public string Day { get; set; }
        public string DayFr { get; set; }
        public int StatusID { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public int StoreId { get; set; }
        public List<string> TimeInterval { get; set; }


    }
}
