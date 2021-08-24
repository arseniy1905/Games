using System.Collections.Generic;

namespace Games.Common.Result
{
    public class TagDataRulesResult
    {
        public TagDataRulesResult()
        {
            ErrorList = new List<TagdataRuleResult>();
            ErrorListJson = string.Empty;
        }
        public List<TagdataRuleResult> ErrorList { get; set; }
        public string ErrorListJson { get; set; }
    }
}
