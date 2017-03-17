using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;

namespace Library.BLL.Search.SearchFilters
{
    class PartyNumberFilter:IntegerBasedSearchFilter
    {
        public PartyNumberFilter(object criteria)
            : base(criteria)
        { }

        protected override double Validate(Common.VO record)
        {
            //DocumentVO document = (DocumentVO)record;

            //return Validate(document.Folder.Party.Number);

            return 0.0;
        }
    }
}
