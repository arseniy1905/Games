namespace Games.ViewModel.MVC
{
    public class OrderBaseViewModel : BaseViewModel
    {
        public OrderBaseViewModel()
        {
            OrderSummary = new OrderSummaryViewModel();
            IsOrderSummaryPage = false;
        }
        public OrderSummaryViewModel OrderSummary { get; set; }
        public bool IsOrderSummaryPage { get; set; }

        public AddressViewModel DeliveryAddress { get; set; }

    }

    public class AddressViewModel
    {
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public int? ProvinceId { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
    }

}
