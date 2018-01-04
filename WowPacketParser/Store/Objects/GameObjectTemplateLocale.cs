using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("gameobject_template_locale")]
    public sealed class GameObjectTemplateLocale : IDataModel
    {
        [DBFieldName("entry", true)]
        public uint? Entry;

        [DBFieldName("locale", true)]
        public string Locale;

        [DBFieldName("name")]
        public string Name;

        [DBFieldName("castBarCaption")]
        public string CastCaption;

        [DBFieldName("unk1")]
        public string UnkString;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
