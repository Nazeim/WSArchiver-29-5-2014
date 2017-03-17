using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.Common.Search;

namespace Library.BLL.Search.SearchFilters
{
    abstract class SearchFilter
    {
        private object criteria;

        public object Criteria
        {
            get { return criteria; }
            set { criteria = value; }
        }

        public SearchFilter(object criteria)
        {
            Criteria = criteria;
        }

        protected abstract double Validate(VO record);

        public virtual void Apply(List<SortableSearchItem> items)
        {
            List<int> toKeep = new List<int>();
            SortableSearchItem[] copy = items.ToArray();

            double result;

            for (int i = 0; i < items.Count; i++)
            {
                result = Validate(items[i].Record);

                if (result >= 0.0)
                {
                    toKeep.Add(i);
                    items[i].DistanceFromCriteria += result;
                }      
            }

            items.Clear();

            for (int i = 0; i < toKeep.Count; i++)
                items.Add(copy[toKeep[i]]);
        }
    }
}
