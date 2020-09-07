using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblState
    {
        public int IStateId { get; set; }
        public int? ICountryId { get; set; }
        public string SCountryName { get; set; }
        public string SStateName { get; set; }
        public int? ICreateUserId { get; set; }
        public string ICreateUserFullName { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? IUpdateUserId { get; set; }
        public string IUpdateUserFullName { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public long? BEnable { get; set; }
        public long? BArchive { get; set; }
        public string SCapitalName { get; set; }
        public int? IStateStatusId { get; set; }
        public string SStateStatus { get; set; }
    }
}
