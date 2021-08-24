using System;
using System.Collections.Generic;

namespace Games.ViewModel.Common
{
    [Serializable]
    public class MenuBarViewModel
    {
        public MenuBarViewModel()
        {
            MenuItems = new List<MenuItemViewModel>();
        }
        public UserViewModel User { get; set; }
        public List<MenuItemViewModel> MenuItems { get; set; }
    }
}
