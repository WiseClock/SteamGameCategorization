using System;
using System.Diagnostics;

namespace SteamGameCategorization.Util
{
    internal class VDFPrinter
    {
        public static void printUserRoamingConfigStore(VDF vdf)
        {
            printVDF(((VDFValues)vdf).Value["UserRoamingConfigStore"], 0);
        }

        private static void printVDF(VDF vdf, int indent)
        {
            for (int i = 0; i < indent; i++)
                Debug.Write("\t");
            Debug.Write("\"" + vdf.Key + "\"");
            if (vdf is VDFValues)
            {
                Debug.Write("\n");
                for (int i = 0; i < indent; i++)
                    Debug.Write("\t");
                Debug.Write("{\n");

                foreach (VDF subVDF in ((VDFValues)vdf).Value.Values)
                {
                    printVDF(subVDF, indent + 1);
                }

                for (int i = 0; i < indent; i++)
                    Debug.Write("\t");
                Debug.Write("}\n");
            }
            else if (vdf is VDFValue)
            {
                Debug.Write("\t\t\"" + ((VDFValue)vdf).Value + "\"\n");
            }
        }
    }    
}
