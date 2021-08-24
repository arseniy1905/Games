using System;

namespace Games.DataModel
{
    public class ProductTagDataRuleLevel
    {
        public int Id { get; set; }
        public string LevelName { get; set; }
        public string SourceTableName { get; set; }
        public string DestTableName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int StatusId { get; set; }
        public string ForeignKeyName { get; set; }
        public string PrimaryKeyName { get; set; }
    }
}
