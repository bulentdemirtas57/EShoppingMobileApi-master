using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblSubCategory
    {
        public int ISubCategoryId { get; set; }
        public int? ICategoryId { get; set; }
        public string SCategoryName { get; set; }
        public string SSubCategoryName { get; set; }
        public string SDescription { get; set; }
        public int? ISubCategoryRow { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public int? ICreateUserId { get; set; }
        public string SCreateUserFullName { get; set; }
        public long? BEnable { get; set; }
        public long? BArchive { get; set; }
        public string SSubCategoryStatus { get; set; }
        public int? ISubCategoryStatusId { get; set; }
        public string SSubCategoryNameTr { get; set; }
    }
}
