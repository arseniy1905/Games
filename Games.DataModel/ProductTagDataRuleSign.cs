using System;

namespace Games.DataModel
{
    public class ProductTagDataRuleSign
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int StatusId { get; set; }
        public string Sign { get; set; }
        public string SignName { get; set; }
    }
}
