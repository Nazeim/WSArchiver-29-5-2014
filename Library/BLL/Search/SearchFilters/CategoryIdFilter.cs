using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;

namespace Library.BLL.Search.SearchFilters
{
    class CategoryIdFilter : SearchFilter
    {
        public CategoryIdFilter(object criteria)
            : base(criteria)
        { }

        protected override double Validate(Common.VO record)
        {
            DocumentVO document = (DocumentVO)record;
            List<CategoryVO> ids = (List<CategoryVO>)Criteria;

            foreach (CategoryVO cat in document.Categories)
            {
                if (ids.Contains(cat))
                    return 0.0;
            }

            return -10.0;
        }
    }
}
