using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Common
{
    public abstract class NameBasedVO : VO
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
