using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("creature_template_locale")]
    public sealed class CreatureTemplateLocale : IDataModel
    {
        [DBFieldName("entry", true)]
        public uint? Entry;

        [DBFieldName("locale", true)]
        public string Locale;

        [DBFieldName("Name")]
        public string Name;

        [DBFieldName("NameAlt")]
        public string NameAlt;

        [DBFieldName("Title")]
        public string Title;

        [DBFieldName("TitleAlt")]
        public string TitleAlt;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
