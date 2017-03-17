using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Library.Common.Search.StringSearchFunctions
{
    public class AdditionDistance
    {
        private static int CalcAdditionDistance(string word1, string word2)
        {
            string pattern = string.Format(@"(\w)*{0}(\w)*", word1);
            bool match = Regex.IsMatch(word2, pattern, RegexOptions.IgnoreCase);

            if (!match)
                return -1;

            return word2.Length - word1.Length;
        }

        private static double AverageNormalizedDistance(string[] criteriaWords, string[] rowWords)
        {
            int curMin;
            int curDistance;
            double sum = 0.0;

            foreach (string criteriaWord in criteriaWords)
            {
                curMin = -1;

                foreach (string rowWord in rowWords)
                {
                    curDistance = CalcAdditionDistance(criteriaWord, rowWord);

                    if (curDistance >= 0)
                    {
                        if (curMin < 0)//The first acceptable word
                            curMin = curDistance;
                        else
                            curMin = Math.Min(curMin, curDistance);
                    }
                }

                if (curMin < 0)//No words were accepted
                    return -10.0;

                sum += (double)curMin / criteriaWord.Length;//scale to [0..1]
            }

            return sum / criteriaWords.Length;//Averge of normalized addition distances
        }

        private static double AverageNormalizedDistance(string[] criteriaWords, string row)
        {
            return AverageNormalizedDistance(criteriaWords, Common.ExtractWords(row));
        }

        public static double AverageNormalizedDistance(string criteriaSentence, string compareToSentence)
        {
            return AverageNormalizedDistance(Common.ExtractWords(criteriaSentence), Common.ExtractWords(compareToSentence));
        }
    }
}
