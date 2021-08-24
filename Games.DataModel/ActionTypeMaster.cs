using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class ActionTypeMaster
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string ActionName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
