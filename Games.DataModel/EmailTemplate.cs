using System;

namespace Games.DataModel
{
    public class EmailTemplate
    {
        public Int32 Id { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public string Module { get; set; }
        public bool SeparateFrenchTemplate { get; set; }
        public string EmailSubjectFr { get; set; }
        public string EmailBodyFr { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public bool IsPredefinedToEmail { get; set; }
        public bool IsPredefinedCCEmail { get; set; }
        public bool IsPredefinedBCCEmail { get; set; }
        public string ToEmailAddress { get; set; }
        public string CCEmailAddress { get; set; }
        public string BCCEmailAddress { get; set; }

    }
}
