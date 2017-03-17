using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Library.Common.Search.StringSearchFunctions
{
    public class LevensteinDistance
    {
        /// <summary>
        /// Returns the Levenshtein distance between the two strings.
        /// </summary>
        /// <param name="s">The first string</param>
        /// <param name="t">The second string</param>
        /// <param name="upperLimit">Upper limit of the distance, or a negative value if no limit is to be specified.</param>
        /// <returns>The Levenshtein distance between the two strings if it is less than the specified limit. -1 otherwise.</returns>
        private static int LevenshteinDistance(string s, string t, int upperLimit)
        {
            // for all i and j, d[i,j] will hold the Levenshtein distance between
            // the first i characters of s and the first j characters of t;
            // note that d has (m+1)*(n+1) values
            int[,] d = new int[s.Length + 1, t.Length + 1];
            if (upperLimit < 0)
                upperLimit = Int32.MaxValue;


            // source prefixes can be transformed into empty string by
            // dropping all characters
            for (int i = 0; i < d.GetLength(0); i++)
            {
                d[i, 0] = i;
            }

            //If the minimum value of the current row and the previous
            //row is greater than the upper limit then the distance is
            //greater than the upper limit and -1 is returned
            int prevRowMinVal = s.Length;//s.Length is the min value of first row
            int curRowMinVal = Int32.MinValue;

            // target prefixes can be reached from empty source prefix
            // by inserting every characters
            for (int i = 0; i < d.GetLength(1); i++)
            {
                d[0, i] = i;
            }

            for (int j = 1; j <= t.Length; j++)
            {
                curRowMinVal = Int32.MaxValue;

                for (int i = 1; i <= s.Length; i++)
                {
                    if (s[i - 1] == t[j - 1])
                        d[i, j] = d[i - 1, j - 1];
                    else
                        d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + 1);

                    curRowMinVal = Math.Min(curRowMinVal, d[i, j]);

                    if (Math.Min(prevRowMinVal, curRowMinVal) > upperLimit)
                        return -1;
                }

                prevRowMinVal = curRowMinVal;
            }

            return (d[s.Length, t.Length] > upperLimit) ? -1 : d[s.Length, t.Length];
        }

        /// <summary>
        /// Returns the Levenshtein distance between the two strings.
        /// </summary>
        /// <param name="s">The first string</param>
        /// <param name="t">The second string</param>
        /// <param name="upperLimitAsPercentage">Percentage of the length of the first string that corresponds to an upper limit for the edit distance, or a negative value if no limit is to be specified.</param>
        /// <returns>The Levenshtein distance between the two strings if it is less than the specified limit. -1 otherwise.</returns>
        private static int LevenshteinDistance(string s, string t, double upperLimitAsPercentage)
        {
            int upperLimit = (int)Math.Round(s.Length * upperLimitAsPercentage);

            return LevenshteinDistance(s, t, upperLimit);
        }

        private static double AverageNormalizedDistance(string[] criteriaWords, string[] rowWords, double upperLimitAsPercentage)
        {
            int curMin;
            int curDistance;
            double sum = 0.0;

            foreach (string criteriaWord in criteriaWords)
            {
                curMin = -1;

                foreach (string rowWord in rowWords)
                {
                    curDistance = LevenshteinDistance(criteriaWord, rowWord, upperLimitAsPercentage);

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

            return sum / criteriaWords.Length;//Averge of normalized edit distances
        }

        private static double AverageNormalizedDistance(string[] criteriaWords, string row, double upperLimitAsPercentage)
        {
            return AverageNormalizedDistance(criteriaWords, Common.ExtractWords(row), upperLimitAsPercentage);
        }

        public static double AverageNormalizedDistance(string criteriaSentence, string compareToSentence, double upperLimitAsPercentage)
        {
            return AverageNormalizedDistance(Common.ExtractWords(criteriaSentence), Common.ExtractWords(compareToSentence), upperLimitAsPercentage);
        }

    }
}
