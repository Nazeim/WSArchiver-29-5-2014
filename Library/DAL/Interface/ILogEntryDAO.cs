using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.Common.Search;

namespace Library.DAL.Interface
{
    public interface ILogEntryDAO : IManyToManyDAO<LogEntryVO, UserVO, OperationVO> 
    {
        List<LogEntryVO> Find(DateRange range, OperationVO operation, UserVO user); 
    }
}
