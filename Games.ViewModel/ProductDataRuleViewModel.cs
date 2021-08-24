using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class ProductDataRuleViewModel
    {
        public ProductDataRuleViewModel()
        {
            SignList = new List<TagDataSignViewModel>();
            AttributeList = new List<TagDataAttributeViewModel>();
            ValueList = new List<TagDataValueViewModel>();

        }
        public int Id { get; set; }
        public int RuleKey { get; set; }
        public int AttributeId { get; set; }
        public int SignId { get; set; }
        public List<TagDataSignViewModel> SignList { get; set; }
        public List<TagDataAttributeViewModel> AttributeList { get; set; }
        public List<TagDataValueViewModel> ValueList { get; set; }
        public int ValueId { get; set; }
        public string Value { get; set; }
        public int AttributeLevelId { get; set; }
        public int AttributeTypeId { get; set; }
        public string TagDataRuleValuePlaceHolder { get; set; }
        public int ProductRelationTypeId { get; set; }
    }
}
