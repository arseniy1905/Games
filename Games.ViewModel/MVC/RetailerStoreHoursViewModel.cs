namespace Games.ViewModel.MVC
{
    public class RetailerStoreHoursViewModel
    {
        public int? ID { get; set; }
        public int DayID { get; set; }
        public DayMasterViewModel Day { get; set; }
        public int RetailerId { get; set; }
        //public StoreViewModel Store { get; set; }
        public int StoreId { get; set; }
        public bool IsClosed { get; set; }
        public string OpenHour { get; set; }
        public string CloseHour { get; set; }
        public int StatusId { get; set; }

    }

}
