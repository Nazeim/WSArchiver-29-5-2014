using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;

namespace Library.BLL.Search.SearchFilters
{
    class DocLastModificationDateFilter:DateRangeBasedSearchFilter
    {
        public DocLastModificationDateFilter(object criteria)
            : base(criteria)
        { }

        protected override double Validate(Common.VO record)
        {
            DocumentVO document = (DocumentVO)record;

            return Validate(document.LastEditDateTime);
        }
    }
}
