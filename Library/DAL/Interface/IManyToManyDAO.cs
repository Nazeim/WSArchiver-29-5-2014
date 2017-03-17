using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;

namespace Library.DAL.Interface
{
    public interface IManyToManyDAO<T, T1, T2> : IDAO<T>
        where T : VO
        where T1 : VO
        where T2 : VO
    {
        bool IsAttached(T1 firstTableVO, T2 secondTableVO);
        int Attach(T1 firstTableVO, T2 secondTableVO);
        bool Detach(T1 firstTableVO, T2 secondTableVO);
        int GetAssociationsCount(T1 firstTableVO, T2 secondTableVO);
        int GetAssociationsCountOfFirstTable(T1 firstTableVO);
        int GetAssociationsCountOfSecondTable(T2 secondTableVO);
        List<int> GetAssociationsOfFirstTable(T1 firstTableElement);
        List<int> GetAssociationsOfSecondTable(T2 secondTableElement);
        bool DeleteAssociationsOfFirstTableElement(T1 firstTableElement);
        bool DeleteAssociationsOfSecondTableElement(T2 firstTableElement);
    }
}
