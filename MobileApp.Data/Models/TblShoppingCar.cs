using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblShoppingCar
    {
        public int IShoppingCarId { get; set; }
        public int? IOrderNumber { get; set; }
        public int? IProductId { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public decimal? IProductPrice { get; set; }
        public decimal? IProductDeposit { get; set; }
        public int? IUserAddressId { get; set; }
        public int? IUserId { get; set; }
        public int? IStatusId { get; set; }
        public long? BEnable { get; set; }
        public long? BArchive { get; set; }
        public int? IUpdateUserId { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public string SStatusName { get; set; }
        public DateTime? DSdateTime { get; set; }
        public DateTime? DHdateTime { get; set; }
        public DateTime? DYdateTime { get; set; }
        public DateTime? DTdateTime { get; set; }
        public DateTime? DIdateTime { get; set; }
        public int? IListenstatus { get; set; }
        public decimal? SProfit { get; set; }
        public DateTime? DTdateTimeD { get; set; }
        public int? ITheDeliveryTimeId { get; set; }
        public string STheDeliveryTimeDate { get; set; }
        public decimal? STheDeliveryTimeAmount { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public int? IOrderCarId { get; set; }
        public int? IUserAddressTypeId { get; set; }
    }
}
