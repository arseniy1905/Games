namespace Games.DataModel.SP.Params
{
    public class GetTaggedProductParams
    {
        public GetTaggedProductParams()
        {
            SearchWord = string.Empty;
            PageSize = 10;
            CurrentPageNumber = 1;
        }
        public int UserId { get; set; }
        public int Language { get; set; }
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public string SearchWord { get; set; }
        public int PageSize { get; set; }
        public int CurrentPageNumber { get; set; }
        public int TagId { get; set; }
    }
}
