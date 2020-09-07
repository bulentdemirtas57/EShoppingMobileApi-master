using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblBrand
    {
        public int IBrandId { get; set; }
        public string SBrandName { get; set; }
        public string SBrandManager { get; set; }
        public string SBrandPhone { get; set; }
        public string SBrandNote { get; set; }
        public string SBrandContractContent { get; set; }
        public DateTime? DBrandContractDate { get; set; }
        public int? ICreateUserId { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? BArchive { get; set; }
        public int? BEnable { get; set; }
        public int? IBrandStatusId { get; set; }
        public string SBrandStatus { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public int? IUpdateUserId { get; set; }
        public DateTime? DBrandContractEndDate { get; set; }
        public string SBrandEmail { get; set; }
    }
}
