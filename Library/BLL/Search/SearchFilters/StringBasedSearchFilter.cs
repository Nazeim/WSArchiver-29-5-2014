using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common.Search.StringSearchFunctions;

namespace Library.BLL.Search.SearchFilters
{
    abstract class StringBasedSearchFilter:SearchFilter
    {
        public StringBasedSearchFilter(object criteria)
            : base(criteria)
        { }

        protected double Validate(string recordValue)
        {
            return MixedDistance.AverageNormalizedDistance((string)Criteria, recordValue, ConfigurationManager.LEVENSTEIN_DISTANCE_UPPER_LIMIT);
        }
    }
}
