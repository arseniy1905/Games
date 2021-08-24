using Games.Common.Enums;

namespace Games.Common.State
{
    public class Language
    {
        public Language()
        {
            Id = EnumLanguage.English;
            Name = nameof(EnumLanguage.English);
        }
        public EnumLanguage Id { get; set; }
        public string Name { get; set; }
    }
}
