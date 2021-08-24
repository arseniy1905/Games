namespace Games.Common.Enums
{
    public enum EnumRetailerStatus
    {
        PendingOnboard = 0,
        OnboardingStarted = 1,
        OCSReview = 2,
        PendingD365CustomerCreate = 3,
        D365OnHold = 4,
        D365CustomerCreateError = 5,
        RejectToRetailer = 6,
        ResubmittedReview = 7,
        ApplicationApproved = 8,
        Active = 9,
        Deleted = 10,
        Archived = 11
    }
}
