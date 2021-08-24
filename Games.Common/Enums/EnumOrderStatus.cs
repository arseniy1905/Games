namespace Games.Common.Enums
{
    public enum EnumOrderStatus
    {
        Unwanted = -1,
        Submitted = 1,
        InventoryAllocated = 2,
        SubmittedToD365 = 3,
        FailedinD365 = 4,
        OrderInvoiced = 5,
        PartiallyShipped = 6,
        CompleteShipped = 7,
        Deleted = 10,
        Merged = 13
    }
}
