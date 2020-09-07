using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblNewServiceArea
    {
        public int INewServiceAreaId { get; set; }
        public string SPostaCodeName { get; set; }
        public string SStreet { get; set; }
        public string SNumber { get; set; }
        public string SMobileNumber { get; set; }
        public string SEmailAddress { get; set; }
        public int? IPostaCodeId { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? BEnable { get; set; }
        public int? BArchive { get; set; }
        public string SNewServiceAreaStatus { get; set; }
    }
}
