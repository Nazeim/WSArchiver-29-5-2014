using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Common;
using Library.DAL;
using Library.DAL.Interface;

namespace Library.BLL
{
    public class OperationsManager : Manager<OperationVO>
    {
        //TODO remove anything related to separation between e-docs and paper-docs
        public const string LOGIN_LOGOUT = "تسجيل الدخول و الخروج";
        public const string EDIT_PARTIES = "تعديل الجهات";
        public const string EDIT_GENERAL_FILES = "تعديل الملفات العامة";
        public const string EDIT_DESTINATIONS = "تعديل الإدارات/المكاتب/الموظفين";
        public const string EDIT_CATEGORIES = "تعديل التصنيفات";
        public const string EDIT_USERS = "تعديل المستخدمين";
        //public const string CREATE_PAPER_DOCS = "إدخال مستندات ورقية";
        public const string CREATE_DOCS = "إنشاء المستندات";
        public const string SIMPLE_SEARCH = "البحث البسيط في الأرشيف";
        public const string ADVANCED_SEARCH = "البحث المتقدم في الأرشيف";
        //public const string EDIT_PAPER_DOCS = "تعديل مستندات ورقية";
        public const string EDIT_DOCS = "تعديل المستندات";
        public const string SEARCH_LOG = "البحث في ملف المراقبة";

                private AttacherDetacher<UserOperationVO, UserVO, OperationVO> permissionsAttacherDetacher =
            new AttacherDetacher<UserOperationVO, UserVO, OperationVO>(DAL.DALManager.GetUserOperation());

        public AttacherDetacher<UserOperationVO, UserVO, OperationVO> PermissionsAttacherDetacher
        {
            get { return permissionsAttacherDetacher; }
            set { permissionsAttacherDetacher = value; }
        }

        public OperationsManager()
            : base(DALManager.GetOperationDAO())
        {
        }

        public OperationVO GetOperationByName(string name)
        {
            List<OperationVO> operations = GetAll();

            foreach (OperationVO op in operations)
            {
                if (op.Name == name)
                    return op;
            }

            return null;
        }

        public List<OperationVO> GetOperationsOfUser(UserVO user)
        {
            List<OperationVO> result = new List<OperationVO>();
            List<OperationVO> all = GetAll();

            foreach (OperationVO op in all)
            {
                if (permissionsAttacherDetacher.IsAttached(user, op))
                {
                    result.Add(op);
                }
            }

            return result;
        }

        public bool AssignPermissionsToUser(UserVO user, List<OperationVO> operations)
        {
            if (!permissionsAttacherDetacher.DetachAllFrom(user))
                return false;

            foreach (OperationVO op in operations)
                if (permissionsAttacherDetacher.Attach(user, op) < 0)
                    return false;

            return true;
        }

        public bool HasPermission(string permission, UserVO user)
        {
            OperationVO op = GetOperationByName(permission);

            return permissionsAttacherDetacher.IsAttached(user, op);
        }

        public bool Ping()
        {
            bool result = ((IOperationDAO)dataAccessObject).Ping();
            dataAccessObject.CloseConnection();

            return result;
        }
    }
}
