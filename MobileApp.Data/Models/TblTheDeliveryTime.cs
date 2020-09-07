using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblTheDeliveryTime
    {
        public int ITheDeliveryTimeId { get; set; }
        public int? ITheDeliveryTimeRanking { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public string STheDeliveryTimeDate { get; set; }
        public string STheDeliveryTimeContent { get; set; }
        public int? BEnable { get; set; }
        public int? BArchive { get; set; }
        public int? ITheDeliveryTimeStart { get; set; }
        public TimeSpan? DHour { get; set; }
        public string SStatus { get; set; }
        public decimal? SAmount { get; set; }
    }
}
