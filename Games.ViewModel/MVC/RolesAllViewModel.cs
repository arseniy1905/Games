using System;

namespace Games.ViewModel.MVC
{
    public class RolesAllViewModel
    {
        public int Id { get; set; }
        public string RoleType { get; set; }
        public string UserRole { get; set; }
        public int TotalUsers { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string Action { get; set; }
        public string ColorCode { get; set; }
    }
}
