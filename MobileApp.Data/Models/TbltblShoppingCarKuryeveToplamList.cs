using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TbltblShoppingCarKuryeveToplamList
    {
        public DateTime? DTdateTimeD { get; set; }
        public DateTime? DTdateTime { get; set; }
        public int? IUserId { get; set; }
        public int? IUserAddressId { get; set; }
        public decimal? Satis { get; set; }
        public decimal? ToplamKar { get; set; }
        public decimal? KuryeTutari { get; set; }
    }
}
