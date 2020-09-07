using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblProvince
    {
        public int IProvinceId { get; set; }
        public string SProvinceName { get; set; }
        public int? IStateId { get; set; }
        public string SStateName { get; set; }
        public int? ICreateUserId { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? IUpdateUserId { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public long? BEnable { get; set; }
        public long? BArchive { get; set; }
        public int? IProvinceStatusId { get; set; }
        public string SProvinceStatus { get; set; }
    }
}
