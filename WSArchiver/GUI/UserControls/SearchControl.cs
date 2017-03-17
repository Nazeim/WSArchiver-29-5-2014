using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Common;

namespace WSArchiver.GUI.UserControls
{
    public partial class SearchControl : UserControl
    {
        private Library.Common.Search.Filter.FilterEnum filterType;

        public Library.Common.Search.Filter.FilterEnum FilterType
        {
            get { return filterType; }
            set { filterType = value; }
        }

        public Library.Common.Search.Filter Filter
        {
            get
            {
                Library.Common.Search.Filter filter =
                    new Library.Common.Search.Filter(GenerateCriteria(), filterType);

                return filter;
            }
        }

        //public Common.Search.Filter.FilterEnum Type
        //{
        //    set
        //    {
        //        filterType = value;
        //    }
        //    get
        //    {
        //        return filterType;
        //    }
        //}

        public string String
        {
            get
            {
                switch (filterType)
                {
                    case Library.Common.Search.Filter.FilterEnum.CATEGOTY_ID:
                        return "تصنيفات المستند";
                    case Library.Common.Search.Filter.FilterEnum.DESTINATION_ID:
                        return "وجهة المستند";
                    case Library.Common.Search.Filter.FilterEnum.DOC_CREATION_DATE:
                        return "تاريخ إنشاء الأرشفة";
                    case Library.Common.Search.Filter.FilterEnum.DOC_CREATOR_ID:
                        return "المستخدم الذي أنشأ المستند";
                    case Library.Common.Search.Filter.FilterEnum.DOC_GENERAL_FILE_ID:
                        return "الملف العام الخاص بالمستند";
                    case Library.Common.Search.Filter.FilterEnum.DOC_IN_DATE:
                        return "تاريخ الوارد";
                    case Library.Common.Search.Filter.FilterEnum.DOC_IN_NUMBER:
                        return "رقم الوارد";
                    case Library.Common.Search.Filter.FilterEnum.DOC_LAST_MODIFICATION_DATE:
                        return "تاريخ آخر تعديل";
                    case Library.Common.Search.Filter.FilterEnum.DOC_LAST_MODIFIER_ID:
                        return "المستخدم الذي قام بآخر تعديل";
                    case Library.Common.Search.Filter.FilterEnum.DOC_PROCESS_EXACT:
                    case Library.Common.Search.Filter.FilterEnum.DOC_PROCESS:
                        return "الإجراء";
                    case Library.Common.Search.Filter.FilterEnum.DOC_REGISTRATION_DATE:
                        return "تاريخ التسجيل";
                    case Library.Common.Search.Filter.FilterEnum.DOC_REGISTRATION_NUMBER:
                        return "رقم التسجيل";
                    case Library.Common.Search.Filter.FilterEnum.DOC_SUBJECT_EXACT:
                    case Library.Common.Search.Filter.FilterEnum.DOC_SUBJECT:
                        return "موضوع المستند";
                    case Library.Common.Search.Filter.FilterEnum.DOC_TITLE:
                    case Library.Common.Search.Filter.FilterEnum.DOC_TITLE_EXACT:
                        return "عنوان المستند";
                    case Library.Common.Search.Filter.FilterEnum.FILE_ARCHIVING_DATE:
                        return "تاريخ أرشفة ملفات المستند";
                    case Library.Common.Search.Filter.FilterEnum.FILE_NAME_EXACT:
                    case Library.Common.Search.Filter.FilterEnum.FILE_NAME:
                        return "اسم الملف";
                    case Library.Common.Search.Filter.FilterEnum.GENERAL_FILE_NUMBER:
                        return "رقم الملف العام";
                    case Library.Common.Search.Filter.FilterEnum.PARTY_ID:
                        return "الجهة";
                    case Library.Common.Search.Filter.FilterEnum.PARTY_NUMBER:
                        return "رقم الجهة";
                }

                return "غير معروف";
            }
        }

        public SearchControl()
        {
            InitializeComponent();
        }

        protected SearchControl(Library.Common.Search.Filter.FilterEnum filter)
        {
            this.filterType = filter;
        }

        protected virtual object GenerateCriteria()
        {
            return null;
        }

    }
}
