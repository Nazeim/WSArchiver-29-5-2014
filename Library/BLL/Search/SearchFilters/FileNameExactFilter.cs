using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;

namespace Library.BLL.Search.SearchFilters
{
    class FileNameExactFilter:ExactStringBasedSearchFilter
    {
        public FileNameExactFilter(object criteria)
            : base(criteria)
        { }

        protected override double Validate(Common.VO record)
        {
            DocumentVO document = (DocumentVO)record;
            double min = -10.0;
            double temp;

            foreach (FileVO file in document.Files)
            {
                temp = Validate(file.Name);

                if (temp >= 0.0)
                {
                    if (min >= 0.0)
                        min = Math.Min(min, temp);
                    else
                        min = temp;
                }
            }

            return min;
        }
    }
}
