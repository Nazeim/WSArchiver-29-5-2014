using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;

namespace Library.BLL.Search.SearchFilters
{
    class FileArchivingDateFilter : DateRangeBasedSearchFilter
    {
        public FileArchivingDateFilter(object criteria)
            : base(criteria)
        { }

        protected override double Validate(Common.VO record)
        {
            DocumentVO document = (DocumentVO)record;
            double temp;

            foreach (FileVO file in document.Files)
            {
                temp = Validate(file.AdditionDateTime);

                if (temp >= 0.0)
                    return temp;
            }

            return -10.0;
        }
    }
}
