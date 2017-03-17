using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.BLL.Search.SearchFilters
{
    abstract class IntegerBasedSearchFilter:SearchFilter
    {
        public IntegerBasedSearchFilter(object criteria)
            : base(criteria)
        { }

        protected double Validate(int recordValue)
        {
            if (recordValue == (int)Criteria)
                return 0.0;

            return -10.0;
        }
    }
}
