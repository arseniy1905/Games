using System;

namespace Games.DataModel
{
    public class EmailNotificationLog
    {
        public Int64 Id { get; set; }
        public int EmailTemplateId { get; set; }
        public EmailTemplate EmailTemplate { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public string EmailTo { get; set; }
        public string EmailCC { get; set; }
        public string EmailBCC { get; set; }
        public string EmailFrom { get; set; }
        public string EmailAttachmentPath { get; set; }
        public bool IsSent { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
