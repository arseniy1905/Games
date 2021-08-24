namespace Games.Common.State
{
    public class Retailer
    {
        public Retailer()
        {
            RetailerAddress = new RetailerAddress();

        }
        public int Id { get; set; }
        public int RetailerOrganizationId { get; set; }
        public string RetailerId { get; set; }
        public string RetailerName { get; set; }
        public int RetailerStoreId { get; set; }
        public int RetailerStatusId { get; set; }
        public int RequestId { get; set; }
        public bool IsNDAAccepted { get; set; }
        public int NoOfRetailers { get; set; }
        public RetailerAddress RetailerAddress { get; set; }
        public RetailerAddress RetailerStoreAddress { get; set; }
        public string RetailerStoreName { get; set; }
    }
}
