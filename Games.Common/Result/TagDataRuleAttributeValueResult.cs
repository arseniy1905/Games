namespace Games.Common.Result
{
    public class TagDataRuleAttributeValueResult : TagdataRuleResult
    {
        public bool InvalidValue { get; set; }
        public int DataValueId { get; set; }
        public string DataValue { get; set; }

    }
}
