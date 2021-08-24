using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class EmailBlast
    {
        public int Id { get; set; }
        public int RecipientTypeId { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
