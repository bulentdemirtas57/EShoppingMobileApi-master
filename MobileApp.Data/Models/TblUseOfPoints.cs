using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblUseOfPoints
    {
        public int IUseOfPointsId { get; set; }
        public decimal? MUseOfPoints { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? ICreateUserId { get; set; }
        public int? BEnable { get; set; }
        public int? BArchive { get; set; }
        public string STheDeliveryTimeDate { get; set; }
        public decimal? MTotalAmount { get; set; }
    }
}
