using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.BLL.Search.SearchFilters;
using Library.Common.Search;

namespace Library.BLL.Search
{
    class FiltersManager
    {
        public static SearchFilter GetFilter(Filter filter)
        {
            switch (filter.FilterType)
            {
                case Filter.FilterEnum.CATEGOTY_ID:
                    return new CategoryIdFilter(filter.Criteria);
                case Filter.FilterEnum.DESTINATION_ID:
                    return new DestinationIdFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_CREATION_DATE:
                    return new DocOutDateFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_CREATOR_ID:
                    return new DocCreatorIdFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_GENERAL_FILE_ID:
                    return new DocFolderIdFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_IN_DATE:
                    return new DocInDateFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_IN_NUMBER:
                    return new DocInNumberFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_LAST_MODIFICATION_DATE:
                    return new DocLastModificationDateFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_LAST_MODIFIER_ID:
                    return new DocLastModifierIdFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_PROCESS:
                    return new DocProcessFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_PROCESS_EXACT:
                    return new DocProcessExactFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_REGISTRATION_DATE:
                    return new DocOutDateFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_REGISTRATION_NUMBER:
                    return new DocOutNumberFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_SUBJECT:
                    return new DocSubjectFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_SUBJECT_EXACT:
                    return new DocSubjectExactFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_TITLE:
                    return new DocTitleFilter(filter.Criteria);
                case Filter.FilterEnum.DOC_TITLE_EXACT:
                    return new DocTitleExactFilter(filter.Criteria);
                case Filter.FilterEnum.FILE_ARCHIVING_DATE:
                    return new FileArchivingDateFilter(filter.Criteria);
                case Filter.FilterEnum.FILE_NAME:
                    return new FileNameFilter(filter.Criteria);
                case Filter.FilterEnum.FILE_NAME_EXACT:
                    return new FileNameExactFilter(filter.Criteria);
                case Filter.FilterEnum.GENERAL_FILE_NUMBER:
                    return new FolderNumberFilter(filter.Criteria);
                case Filter.FilterEnum.PARTY_ID:
                    return new PartyIdFilter(filter.Criteria);
                case Filter.FilterEnum.PARTY_NUMBER:
                    return new PartyNumberFilter(filter.Criteria);

                default:
                    throw new Exception("Filter is missing");
            }
        }
    }
}
