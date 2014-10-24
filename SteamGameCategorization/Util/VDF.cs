using System;
namespace SteamGameCategorization.Util
{
    internal class VDF
    {
        private string _key;

        public string Key
        {
            get
            {
                return _key;
            }
        }

        public VDF(string key)
        {
            _key = key;
        }

        public VDF GetKey(string key)
        {
            if (this is VDFValue)
            {
                throw new Exception("Getting Value Dictionary from non VDFValues object.");
            }
            return ((VDFValues)this).Value[key];
        }
    }
}
