using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.Common
{
    public class BreadCrumbViewModel
    {
        public string DisplayText { get; set; }
        public string Link { get; set; }
        public bool LinkRequired { get; set; }
    }
}
