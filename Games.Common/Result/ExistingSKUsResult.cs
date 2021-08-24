using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Common.Result
{
    public class ExistingSKUsResult:GenericResult
    {
        public ExistingSKUsResult()
        {
            ExistingSKUs = string.Empty;
            ExistingSKUList = new List<ExistingSKUItem>();
        }
        public string ExistingSKUs { get; set; }
        public List<ExistingSKUItem> ExistingSKUList { get; set; }
    }
}
