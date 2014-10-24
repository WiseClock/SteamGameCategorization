using System;
using SteamGameCategorization.Util;
using System.Collections.Generic;
using System.Diagnostics;

namespace SteamGameCategorization.Util
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\CODE\VISUAL STUDIO\Projects\SteamGameCategorization\sharedconfig.vdf";
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            string vdfString = file.ReadToEnd();

            VDF vdfObject = VDFParser.parse(vdfString);

            printVDF(((VDFValues)vdfObject).Value["UserRoamingConfigStore"], 0);

            Console.ReadKey();
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
