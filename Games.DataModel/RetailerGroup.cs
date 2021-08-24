using System;

namespace Games.DataModel
{
    public class RetailerGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameFr { get; set; }
        public string Description { get; set; }
        public int? ColorID { get; set; }
        public ColorPalletMaster ColorPallet { get; set; }
        public int StatusID { get; set; }
        public StatusMaster Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
