using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblOrderCar
    {
        public int IOrderCarId { get; set; }
        public int? IOrderNumber { get; set; }
        public int? IUserId { get; set; }
        public int? IUserAddressId { get; set; }
        public int? IUserAddressTypeId { get; set; }
        public decimal? MTotalProductPrice { get; set; }
        public decimal? MAmountPaid { get; set; }
        public decimal? MAmountToBePaid { get; set; }
        public decimal? MUsedCreditAmount { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public string SUpdateContent { get; set; }
        public int? IStatusId { get; set; }
        public string SStatusName { get; set; }
        public DateTime? DSdateTime { get; set; }
        public DateTime? DHdateTime { get; set; }
        public DateTime? DYdateTime { get; set; }
        public DateTime? DTdateTime { get; set; }
        public DateTime? DIdateTime { get; set; }
        public int? BEnable { get; set; }
        public int? BArchive { get; set; }
        public int? ITheDeliveryTimeId { get; set; }
        public string STheDeliveryTimeDate { get; set; }
        public string SUserAddressDetail { get; set; }
        public int? IUpdateUserId { get; set; }
        public DateTime? DTdateTimeD { get; set; }
        public DateTime? DStdate { get; set; }
        public string SStdatetime { get; set; }
    }
}
