﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class FavouriteItems
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RetailerId { get; set; }
        public int ItemNumber { get; set; }
        public bool IsFavourite { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
