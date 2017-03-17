using System.Collections.Generic;
namespace Library.Common.Search
{
    public class Filter
    {
        public enum FilterEnum
        {
            NOT_SET = -1,

            //Integer based
            DOC_REGISTRATION_NUMBER = 0,
            DOC_IN_NUMBER = 1,
            DOC_GENERAL_FILE_ID = 2,
            DOC_CREATOR_ID = 3,
            DOC_LAST_MODIFIER_ID = 4,
            PARTY_ID = 5,
            PARTY_NUMBER = 6,
            GENERAL_FILE_NUMBER = 7,
            DESTINATION_ID = 8,
            CATEGOTY_ID = 9,
            
            //Date Based
            DOC_REGISTRATION_DATE = 10,
            DOC_IN_DATE = 11,
            DOC_CREATION_DATE = 12,
            DOC_LAST_MODIFICATION_DATE = 13,
            FILE_ARCHIVING_DATE = 14,

            //String based
            DOC_TITLE_EXACT = 15,
            DOC_PROCESS_EXACT = 16,
            DOC_SUBJECT_EXACT = 17,
            FILE_NAME_EXACT = 18,
            DOC_TITLE = 19,
            DOC_PROCESS = 20,
            DOC_SUBJECT= 21,
            FILE_NAME = 22
        }

        private object criteria;
        private FilterEnum filterType;

        public object Criteria
        {
            get { return criteria; }
            set { criteria = value; }
        }
        
        public FilterEnum FilterType
        {
            get { return filterType; }
            set { filterType = value; }
        }

        public Filter(object criteria, FilterEnum filterType)
        {
            Criteria = criteria;
            FilterType = filterType;
        }
        public Filter()
            :this(null, FilterEnum.NOT_SET)
        { }
        public Filter(FilterEnum filter)
            : this(null, filter)
        { }

        private static FilterSorter sorter = null;

        public static IComparer<Filter> GetComparer()
        {
            if (sorter == null)
                sorter = new FilterSorter();

            return sorter;
        }

        class FilterSorter : IComparer<Filter>
        {
            #region IComparer<Filter> Members

            public int Compare(Filter x, Filter y)
            {
                if ((int)x.FilterType > (int)y.FilterType)
                    return 1;

                if ((int)x.FilterType < (int)y.FilterType)
                    return -1;

                return 0;
            }

            #endregion
        }
    }
}