using System;

namespace SteamGameCategorization.JsonStruct
{
    [Serializable]
    internal class App
    {
        public bool success { get; set; }
        public AppData data { get; set; }
    }
}
