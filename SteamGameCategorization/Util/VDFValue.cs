namespace SteamGameCategorization.Util
{
    internal class VDFValue : VDF
    {
        private string _value;

        public string Value
        {
            get
            {
                return _value;
            }
        }

        public VDFValue(string key, string value)
            : base(key)
        {
            _value = value;
        }
    }
}
