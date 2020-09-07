using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblUserAddress
    {
        public int IUserAddressId { get; set; }
        public int? ICountyId { get; set; }
        public string SCountyName { get; set; }
        public int? SUserAddressTypeId { get; set; }
        public string SUserAddressTypeName { get; set; }
        public int? INeighborhoodId { get; set; }
        public string SPostaCodeName { get; set; }
        public int? IStreetId { get; set; }
        public string SStreetName { get; set; }
        public string SNo { get; set; }
        public string SFloor { get; set; }
        public int? ICreateUserId { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? IUpdateUserId { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public long? BEnable { get; set; }
        public long? BArchive { get; set; }
        public int? IUserId { get; set; }
        public int? ISelected { get; set; }
        public string SBusinessPhone { get; set; }
    }
}
