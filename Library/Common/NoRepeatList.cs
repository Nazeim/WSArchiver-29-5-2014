using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Common
{
    [Serializable]
    public class NoRepeatList<T>:List<T>
    {
        public NoRepeatList()
            : base()
        { }

        public bool AddDistinct(T item)
        {
            if (Contains(item))
                return false;

            Add(item);
            return true;
        }
        public bool AddDistinct(IEnumerable<T> enumerable)
        {
            bool result = false;

            foreach(T item in enumerable)
                result |= AddDistinct(item);

            return result;
        }
    }
}
