using System;
using System.Collections.Generic;

namespace Games.DataModel
{
    public class ProductTag
    {

        public int Id { get; set; }
        public string NameOfTag { get; set; }
        public bool? IsTagSearchable { get; set; }
        public int? ColorId { get; set; }
        public ColorPalletMaster Color { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? IsSalesFlow { get; set; }
        public int? TagTypeId { get; set; }
        public ProductTagTypeMaster TagType { get; set; }
        public ICollection<ProductTagCollectionMapping> ProductTagMappings { get; set; }
        public int? TagNumber { get; set; }
        
    }
}
