namespace Games.Common.Result
{
    public class UserDetailResult
    {
        public int UserId { get; set; }
        public string FirstPassword { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
