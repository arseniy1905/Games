using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel.SP
{
    public class SpCheckIsValidExportOrderTemplateDay
    {
        public List<CheckIsValidExportOrderTemplateDayResponce> Views { get; set; }
    }

    public class CheckIsValidExportOrderTemplateDayResponce
    { 
        public bool IsValid { get; set; }
    }

}
