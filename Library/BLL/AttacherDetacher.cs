using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL.Interface;

namespace Library.BLL
{
    public class AttacherDetacher<T, T1, T2> where T:VO where T1:VO where T2:VO
    {
        IManyToManyDAO<T, T1, T2> dataAccessObject;

        public AttacherDetacher(IManyToManyDAO<T, T1, T2> dao)
        {
            dataAccessObject = dao;
        }

        public int Attach(T1 firstTableVO, T2 secondTableVO, bool closeConnection)
        {
            int result = dataAccessObject.Attach(firstTableVO, secondTableVO);

            if (closeConnection)
                dataAccessObject.CloseConnection();

            return result;
        }
        public int Attach(T1 firstTableVO, T2 secondTableVO)
        {
            return Attach(firstTableVO, secondTableVO, true);
        }

        public bool Detach(T1 firstTableVO, T2 secondTableVO, bool closeConnection)
        {
            bool result = dataAccessObject.Detach(firstTableVO, secondTableVO);

            if (closeConnection)
                dataAccessObject.CloseConnection();

            return result;
        }

        public bool Detach(T1 firstTableVO, T2 secondTableVO)
        {
            return Detach(firstTableVO, secondTableVO, true);
        }

        public bool DetachAllFrom(T1 firstTableVO)
        {
            bool res = dataAccessObject.DeleteAssociationsOfFirstTableElement(firstTableVO);
            dataAccessObject.CloseConnection();

            return res;
        }

        public bool DetachAllFrom(T2 secondTableVO)
        {
            bool res = dataAccessObject.DeleteAssociationsOfSecondTableElement(secondTableVO);
            dataAccessObject.CloseConnection();

            return res;
        }

        public bool IsAttached(T1 firstTableVO, T2 secondTableVO)
        {
            bool result = dataAccessObject.IsAttached(firstTableVO, secondTableVO);
            dataAccessObject.CloseConnection();

            return result;
        }

    }
}
