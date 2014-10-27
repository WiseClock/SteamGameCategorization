using System;
using System.Text;
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

        public override string ToString()
        {
            return getText(0);
        }

        private string getText(int indent)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < indent; i++)
                sb.Append("\t");
            sb.Append("\"" + this.Key + "\"");

            if (this is VDFValues)
            {
                sb.Append("\n");
                for (int i = 0; i < indent; i++)
                    sb.Append("\t");
                sb.Append("{\n");

                foreach (VDF subVDF in ((VDFValues)this).Value.Values)
                {
                    sb.Append(subVDF.getText(indent + 1));
                }

                for (int i = 0; i < indent; i++)
                    sb.Append("\t");
                sb.Append("}\n");
            }
            else if (this is VDFValue)
            {
                sb.Append("\t\t\"" + ((VDFValue)this).Value + "\"\n");
            }
            return sb.ToString();
        }
    }
}
