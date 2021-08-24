using System;

namespace Games.DataModel
{
    public class DayMaster
    {
        public int ID { get; set; }
        public string Day { get; set; }
        public string DayFr { get; set; }
        public int CodeDayId { get; set; }

        public StatusMaster Status { get; set; }
        public int StatusID { get; set; }
    }

    public class HolidayMaster
    { 
        public int Id { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Holiday { get; set; }
        public string HolidayFr { get; set; }
        public int StatusId { get; set; }

    }

}
