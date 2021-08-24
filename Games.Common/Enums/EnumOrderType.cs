using System.ComponentModel;

namespace Games.Common.Enums
{
    public enum EnumOrderType
    {
        [Description("Replenishment")]
        ReplenishmentOrder = 1,
        [Description("FlowThru")]
        FlowThru = 2,
        [Description("InitialBuy")]
        Initial = 3
    }
}
