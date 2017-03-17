using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;

namespace Library.DAL.Interface
{
    public interface IDAO<T>where T:VO
    {
        int Insert(T vo);
        bool Update(T vo);
        bool DeleteAll();
        bool DeleteItem(int id);
        void CloseConnection();
        T GetItem(int id);
        List<T> GetAll();
        int GetRecordsCount();
        int GetMaxId();
        DateTime GetDate();
    }
}
