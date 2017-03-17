using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.BLL.Search.SearchFilters
{
    abstract class ExactStringBasedSearchFilter:SearchFilter
    {
        public ExactStringBasedSearchFilter(object criteria)
            : base(criteria)
        { }

        protected double Validate(string recordValue)
        {
            if (((string)Criteria).Equals(recordValue))
                return 0.0;

            return -10.0;
        }
    }
}
