﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class HomePageTemplateContentBlockMapping
    {
        public int Id { get; set; }
        public int HomePageTemplateId { get; set; }
        public int ContentBlockTemplateID { get; set; }
        public int SortOrder { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
