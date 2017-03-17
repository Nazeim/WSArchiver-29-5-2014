using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Common
{
    public abstract class VO
    {
        private int id = -1;

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !GetType().Equals(obj.GetType()))
                return false;
            if (!(obj is VO))
                return false;

            return (obj as VO).Id == Id;
        }


        public static IComparer<T> GetSorter<T>() where T : VO
        {
            return new Sorter<T>();
        }

        class Sorter<T> : IComparer<T> where T : VO
        {
            #region IComparer<NameBasedVO> Members

            public int Compare(T x, T y)
            {
                return x.ToString().CompareTo(y.ToString());
            }

            #endregion
        }
    }
}
