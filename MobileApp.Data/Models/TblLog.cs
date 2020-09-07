using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblLog
    {
        public int ILogId { get; set; }
        public int? ILogTypeId { get; set; }
        public string SLogTypeName { get; set; }
        public string SLogContent { get; set; }
        public int? ILogUserId { get; set; }
        public DateTime? DLogDate { get; set; }
        public DateTime? DLogDt { get; set; }
        public int? BEnable { get; set; }
        public int? BArchive { get; set; }
        public string SUserIpAdress { get; set; }
        public string DHour { get; set; }
    }
}
