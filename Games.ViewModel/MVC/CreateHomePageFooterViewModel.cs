using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class CreateHomePageFooterViewModel
    {
        public CreateHomePageFooterViewModel()
        {
            HomePageFooterLinkViewModel = new List<CreateHomePageFooterLinkViewModel>();
        }
        public int Id { get; set; }
        public int HomePageId { get; set; }
        public string CategoryName { get; set; }
        public int DisplayOrder { get; set; }
        public string BackgroundColor { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "yyyy-MM-dd HH:mm", null);
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int ModifyBy { get; set; }
        public int StatusId { get; set; }
        public List<CreateHomePageFooterLinkViewModel> HomePageFooterLinkViewModel { get; set; }
    }
}
