using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblCategory
    {
        public int ICategoryId { get; set; }
        public string SCategoryName { get; set; }
        public string SDescription { get; set; }
        public string SCategoryImg { get; set; }
        public int? ICategoryRow { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public int? ICreateUserId { get; set; }
        public string SCreateUserFullName { get; set; }
        public long? BEnable { get; set; }
        public long? BArchive { get; set; }
        public string SCategoryStatus { get; set; }
        public int? ICategoryStatusId { get; set; }
        public string SCategoryNameTr { get; set; }
    }
}
