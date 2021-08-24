using System;

namespace Games.ViewModel.MVC
{
    public class EmailTemplateViewModel
    {
        public Int32 Id { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public string Module { get; set; }
        public bool SeparateFrenchTemplate { get; set; }
        public string EmailSubjectFr { get; set; }
        public string EmailBodyFr { get; set; }

    }
}
