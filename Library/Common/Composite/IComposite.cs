using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Common.Composite
{
   public interface IComposite:IComponent
    {
        IComponent GetChildAt(int index);
        int GetChildrenCount();
    }
}
