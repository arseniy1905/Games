using System;

namespace Games.DataModel
{
    public class Province
    {
        public int Id { get; set; }
        public string ProvinceName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string ProvinceNameFr { get; set; }
        public string ShortName { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }

    }
}
