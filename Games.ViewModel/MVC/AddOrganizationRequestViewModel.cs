using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class AddOrganizationRequestViewModel
    {
        public List<ContactInfoViewModel> ContactList { get; set; }
        public int Index { get; set; }
    }
}
