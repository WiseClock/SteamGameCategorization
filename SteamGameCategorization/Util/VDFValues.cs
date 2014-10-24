using System.Collections.Generic;

namespace SteamGameCategorization.Util
{
    internal class VDFValues : VDF
    {
        private Dictionary<string, VDF> _value;

        public Dictionary<string, VDF> Value
        {
            get
            {
                return _value;
            }
        }

        public VDFValues(string key)
            : base(key)
        {
            _value = new Dictionary<string, VDF>();
        }
    }
}
