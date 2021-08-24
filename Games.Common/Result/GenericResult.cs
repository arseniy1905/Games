namespace Games.Common.Result
{
    public class GenericResult
    {
        public GenericResult()
        {
            ErrorMessage = "";
            Success = true;
        }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}
