using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Common
{
    public class DocumentCategoryVO : VO
    {
        private DocumentVO document;
        private CategoryVO category;

        public CategoryVO Category
        {
            get { return category; }
            set { category = value; }
        }

        public int CategoryId
        {
            get
            {
                return category.Id;
            }
        }

        public DocumentVO Document
        {
            get { return document; }
            set { document = value; }
        }

        public int DocumentId
        {
            get
            {
                return document.Id;
            }
        }
    }
}
