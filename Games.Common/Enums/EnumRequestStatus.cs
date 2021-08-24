namespace Games.Common.Enums
{
    public enum EnumRequestStatus
    {
        NotStarted = 1,
        ApplicationStarted = 2,
        CSCReiew = 3,
        PendingD365CustomerCreate = 4,
        OnHold = 5,
        D365CustomerCreateError = 6,
        RejectToRetailer = 7,
        ResubmittedReview = 8,
        ApplicationApproved = 9,
        Complete = 10,
        Expired = 11,
        Deleted = 12
    }
}
