using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common.Search;

namespace Library.BLL.Search.SearchFilters
{
    abstract class DateRangeBasedSearchFilter:SearchFilter
    {
        public DateRangeBasedSearchFilter(object criteria)
            : base(criteria)
        { }

        protected double Validate(DateTime recordValue)
        {
            if (((DateRange)Criteria).IsInRange(recordValue))
                return 0.0;

            return -10.0;
        }
    }
}
