using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;

namespace Library.DAL.Interface
{
    public interface IDocumentCategoryDAO : IManyToManyDAO<DocumentCategoryVO, DocumentVO, CategoryVO>
    {
    }
}
