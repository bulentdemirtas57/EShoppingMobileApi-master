using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TbliPriceList
    {
        public int IPriceListId { get; set; }
        public int? ICreateUserId { get; set; }
        public string SWholesaler1 { get; set; }
        public string SWholesaler2 { get; set; }
        public string SWholesaler3 { get; set; }
        public string SWholesaler4 { get; set; }
        public string SWholesaler5 { get; set; }
        public string SWholesaler6 { get; set; }
        public string SWholesaler7 { get; set; }
        public int? IUpdateUserId { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public int? ISalesQuantity { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? IProductId { get; set; }
    }
}
