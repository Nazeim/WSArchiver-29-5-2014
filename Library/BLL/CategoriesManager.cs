using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL;

namespace Library.BLL
{
    public class CategoriesManager : Manager<CategoryVO>
    {
        public CategoriesManager()
            : base(DALManager.GetCategoryDAO())
        {
        }
        public bool IsCategoryNew(CategoryVO category)
        {

            List<CategoryVO> all = GetAll();

            foreach (CategoryVO cat in all)
            {
                if (category.Name == cat.Name)
                    return false;

            }

            return true;
        }
    }
}
