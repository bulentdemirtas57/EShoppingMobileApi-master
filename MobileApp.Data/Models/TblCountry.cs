using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblCountry
    {
        public int ICountryId { get; set; }
        public string SCountryName { get; set; }
        public string SCountryCode { get; set; }
        public int? ICreateUserId { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? IUpdateUserId { get; set; }
        public string IUpdateUserFullName { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public long? BEnable { get; set; }
        public long? BArchive { get; set; }
        public int? ICountryStatusId { get; set; }
        public string SCountryStatus { get; set; }
    }
}
