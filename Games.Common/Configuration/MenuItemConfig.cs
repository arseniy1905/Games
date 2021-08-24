namespace Games.Common.Configuration
{
    public class MenuItemConfig : BaseMenuItemConfig
    {
        public string TextResourceName { get; set; }
        public string ImageFile { get; set; }
        public string ImageFileSelected { get; set; }
        public BaseMenuItemConfig PreviousMenuItem { get; set; }

    }
}
