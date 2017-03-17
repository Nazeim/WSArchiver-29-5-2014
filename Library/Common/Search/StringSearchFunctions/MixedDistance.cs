using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Common.Search.StringSearchFunctions
{
    class MixedDistance
    {
        public static double AverageNormalizedDistance(string criteriaSentence, string compareToSentence, double upperLimitAsPercentage)
        {
            double additionResult = AdditionDistance.AverageNormalizedDistance(criteriaSentence, compareToSentence);

            //If we find an additiion result it will have priority
            if (additionResult > 0.0)
            {
                return additionResult * 0.1;
            }

            return LevensteinDistance.AverageNormalizedDistance(criteriaSentence, compareToSentence, upperLimitAsPercentage) * 0.9 + 0.1;
        }
    }
}
