using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblNeighborhood
    {
        public int INeighborhoodId { get; set; }
        public string SNeighborhoodName { get; set; }
        public int? IPostaCodeName { get; set; }
        public int? ICountyId { get; set; }
        public string SCountyName { get; set; }
        public int? ICreateUserId { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? IUpdateUserId { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public long? BEnable { get; set; }
        public long? BArchive { get; set; }
        public int? INeighborhoodStatusId { get; set; }
        public string SNeighborhoodStatus { get; set; }
    }
}
