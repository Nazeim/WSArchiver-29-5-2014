using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Library.Common.Search.StringSearchFunctions
{
    public class Common
    {
        public static string[] ExtractWords(string original)
        {
            string pattern = @"\b\w+\b";
            MatchCollection collection = Regex.Matches(original, pattern, RegexOptions.IgnoreCase);
            string[] result = new string[collection.Count];

            int counter = 0;

            foreach (Match match in collection)
            {
                result[counter] = match.Value;
                counter++;
            }

            return result;
        }

        public static Regex GetRegexOfName(string name)
        {
            string nameSearchRegex = string.Format(@"((\s)*(\S)+(\s)+)*{0}((\s)*(\S)+(\s)+)*", name.Trim());
            Regex searchRegex = new Regex(nameSearchRegex);

            return searchRegex;
        }

    }
}
