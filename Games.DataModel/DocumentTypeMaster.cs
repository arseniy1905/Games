namespace Games.DataModel
{
    public class DocumentTypeMaster
    {
        public int Id { get; set; }
        public string DocumentType { get; set; }
        public string DocumentTypeFr { get; set; }
        public string FileRestriction { get; set; }
        public string Description { get; set; }
        public string DescriptionFr { get; set; }
        public string DisplayRestriction { get; set; }
        public int StatusId { get; set; }
        public int Sort { get; set; }
        public StatusMaster Status { get; set; }
    }
}
