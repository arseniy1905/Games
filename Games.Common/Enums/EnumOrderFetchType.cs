using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Common.Enums
{
    public enum EnumOrderFetchType
    {
        EditModeANdTemperoryOrders = 1,
        ALL = 2
    }
    public enum EnumOrderMode
    {
        ContinueEditMainOrderMode = 1,
        ContinueEditTempOrderMode = 2,
        NewOrderMode = 3,
        EditExistingOrderMode = 4
    }
}
