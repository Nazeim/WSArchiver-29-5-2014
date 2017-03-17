using System.Collections.Generic;
using Library.Common;

namespace Library.Common.Search
{
    public class SortableSearchItem
    {
        private double distanceFromCriteria;
        private VO record;

        public VO Record
        {
            get { return record; }
            set { record = value; }
        }

        public double DistanceFromCriteria
        {
            get { return distanceFromCriteria; }
            set { distanceFromCriteria = value; }
        }


        public SortableSearchItem(double normalizedDistance, VO record)
        {
            DistanceFromCriteria = normalizedDistance;
            Record = record;
        }

        private static SearchItemSorter sorter = null;
        public static IComparer<SortableSearchItem> GetComparer()
        {
            if (sorter == null)
                sorter = new SearchItemSorter();
            return sorter;
        }

        public class SearchItemSorter : IComparer<SortableSearchItem>
        {
            #region IComparer<SortableSearchItem> Members

            public int Compare(SortableSearchItem x, SortableSearchItem y)
            {
                if (x.DistanceFromCriteria > y.DistanceFromCriteria)
                    return 1;

                if (x.DistanceFromCriteria < y.DistanceFromCriteria)
                    return -1;

                return 0;
            }
            #endregion
        }
    }
}
