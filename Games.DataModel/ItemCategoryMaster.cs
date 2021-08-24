using System;
using System.Collections.Generic;

namespace Games.DataModel
{
    public class ItemCategoryMaster
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string CategoryFr { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<ItemSubCategoryMaster> SubCategories { get; set; }
        //public DateTime UpdatedDate { get; set; }
    }

    public class ItemSubCategoryMaster
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public ItemCategoryMaster Category { get; set; }
        public string SubCategory { get; set; }
        public string SubCategoryFr { get; set; }
        public int StatusID { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<ItemSubSubCategoryMaster> SubSubCategories { get; set; }
    }
    public class ItemSubSubCategoryMaster
    {
        public int Id { get; set; }
        public int SubCategoryId { get; set; }
        public ItemSubCategoryMaster SubCategory { get; set; }
        public string SubSubCategory { get; set; }
        public string SubSubCategoryFr { get; set; }
        public int StatusID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
