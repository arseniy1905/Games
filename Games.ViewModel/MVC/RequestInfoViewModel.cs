using Games.DataModel;

namespace Games.ViewModel.MVC
{
    public class RequestInfoViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public string CROLNumber { get; set; }
        public string UploadedFileName { get; set; }
        public string UploadedFileURL { get; set; }
        public int RequestTypeID { get; set; }
        public RequestTypeMaster RequestType { get; set; }
        public int RequestStatusID { get; set; }
        public RequestStatusMaster RequestStatus { get; set; }
        public int RetailerID { get; set; }
        public bool IsEmailExist { get; set; }
        public bool IsValidToken { get; set; }
    }
}
