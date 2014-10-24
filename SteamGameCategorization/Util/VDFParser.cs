using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SteamGameCategorization.Util
{
    internal class VDFParser
    {
        public static VDF parse(string vdfString)
        {
            //vdfString = Regex.Replace(vdfString, "\\s+", " ");

            string patternVDF = @"(?x)                                  # enable extended mode
                                \s* \"" (?'name' [^\""]*) \"" \s* {     # start of tag
                                (?'values'                              # named capture
                                  (?>                                   # don't backtrack
                                    (?:
                                      [^{}]+                            # not brackets
                                    | (?'open' { )                      # count opening bracket
                                    | (?'close-open' } )                # subtract closing bracket (matches only if open count > 0)
                                    )*
                                  )
                                  (?(open)(?!))                         # make sure open is not > 0
                                )
                                }                                       # end of tag

                                |                                       # or

                                \s* \"" (?'name' [^\""]*) \"" \s* \""   # start of tag
                                (?'value'                               # named capture
                                  (?>                                   # don't backtrack
                                    (?:
                                      [^""\r\n\\]*(?:\\.[^""\r\n\\]*)*  # not quotes
                                    | (?'open' .+\"" )                  # count opening quotes
                                    | (?'close-open' \"".+ )            # subtract closing quotes (matches only if open count > 0)
                                    )*
                                  )
                                  (?(open)(?!))                         # make sure open is not > 0
                                )
                                \""                                     # end of tag
                                ";

            VDF vdf = new VDFValues("ROOT");
            construct(vdfString, patternVDF, 0, vdf);

            return vdf;
        }

        private static VDF construct(string source, string patternVDF, int indent, VDF parentVDF)
        {
            foreach (Match mVDF in Regex.Matches(source, patternVDF))
            {
                // creates new vdf struct
                VDF vdf;

                /* DEBUG
                for (int i = 0; i < indent; i++)
                    Debug.Write("    ");
                Debug.Write("name: " + mVDF.Groups["name"]);
                */

                if (mVDF.Groups["value"].Length > 0) // value
                {
                    vdf = new VDFValue(mVDF.Groups["name"].ToString(), mVDF.Groups["value"].ToString());

                    /* DEBUG
                    Debug.Write(", value: " + mVDF.Groups["value"]);
                    */
                }
                else // values
                {
                    vdf = new VDFValues(mVDF.Groups["name"].ToString());
                    construct(mVDF.Groups["values"].ToString(), patternVDF, indent + 1, vdf);
                }

                /* DEBUG
                Debug.Write("\n");
                */

                ((VDFValues)parentVDF).Value.Add(mVDF.Groups["name"].ToString(), vdf);
            }
            return parentVDF;
        }
    }
}
