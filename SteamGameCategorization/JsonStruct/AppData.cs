using System;
using System.Collections.Generic;

namespace SteamGameCategorization.JsonStruct
{
    [Serializable]
    internal class AppData
    {
        public string type { get; set; }
        public string name { get; set; }
        public string supported_languages { get; set; }
        public IList<string> developers { get; set; }
        public IList<string> publishers { get; set; }
        public IList<IdDescriptionPair> categories { get; set; }
        public IList<IdDescriptionPair> genres { get; set; }
    }

    [Serializable]
    internal class IdDescriptionPair
    {
        public string id { get; set; }
        public string description { get; set; }
    }
}
