using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL.Interface;

namespace Library.BLL
{
    public abstract class Manager<T> where T : VO
    {
        protected IDAO<T> dataAccessObject;

        protected Manager(IDAO<T> dao)
        {
            dataAccessObject = dao;
        }

        public virtual void Close()
        {
            dataAccessObject.CloseConnection();
        }

        /// <summary>
        /// Inserts the object in databse and sets its Id property to the inserted record id.
        /// </summary>
        /// <param name="vo">The VO object to be inserted.</param>
        /// <returns>The inserted record id. -1 if the insertion was not successful.</returns>
        public virtual int Insert(T vo, bool closeConnection)
        {
            int result = dataAccessObject.Insert(vo);

            if (closeConnection)
                dataAccessObject.CloseConnection();

            return result;
        }

        public virtual int Insert(T vo)
        {
            int result = Insert(vo, true);

            return result;
        }

        public virtual bool Update(T vo, bool closeConnection)
        {
            if (vo.Id < 0)
                return false;

            bool result = dataAccessObject.Update(vo);

            if (closeConnection)
                Close();

            return result;
        }

        public virtual bool Update(T vo)
        {
            return Update(vo, true);
        }

        public virtual bool Delete()
        {
            bool result = dataAccessObject.DeleteAll();
            dataAccessObject.CloseConnection();

            return result;
        }

        public virtual bool Delete(T vo, bool closeConnection)
        {
            if (vo.Id < 0)
                return false;

            bool result = dataAccessObject.DeleteItem(vo.Id);

            if (closeConnection)
                Close();

            return result;
        }

        public virtual bool Delete(T vo)
        {
            return Delete(vo, true);
        }

        public virtual T GetItem(int id)
        {
            T result = dataAccessObject.GetItem(id);
            Close();

            return result;
        }

        public virtual List<T> GetAll()
        {
            List<T> result = dataAccessObject.GetAll();
            Close();

            if (result.Count > 0 && ((result[0] is NameBasedVO && !(result[0] is FileVO)) || (result[0] is UserVO)))
            {
                result.Sort(VO.GetSorter<VO>());
            }

            return result;
        }

        public virtual int GetRecordsCount()
        {
            int result = dataAccessObject.GetRecordsCount();
            dataAccessObject.CloseConnection();

            return result;
        }

        public DateTime GetDate()
        {
            DateTime result = dataAccessObject.GetDate();
            Close();

            return result;
        }
    }
}
