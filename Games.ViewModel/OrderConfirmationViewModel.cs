namespace Games.ViewModel.MVC
{
    public class OrderConfirmationViewModel : BaseViewModel
    {
        public long? ReplenishmentOrderId { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }
        public long? FlowThruOrderId { get; set; }

    }
}
