using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblLogType
    {
        public int ILogTypeId { get; set; }
        public string SLogTypeName { get; set; }
        public DateTime? DLogTypeDate { get; set; }
        public DateTime? DLogTypeDt { get; set; }
        public int? BEnable { get; set; }
        public int? BArchive { get; set; }
    }
}
