using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblGiftCardType
    {
        public int IGiftCardTypeId { get; set; }
        public int? ICreateUserId { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? BEnable { get; set; }
        public int? BArchive { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public string SGiftCardTypeStatus { get; set; }
        public int? IUpdateUserId { get; set; }
        public int? IGiftCardTypeStatuId { get; set; }
        public decimal? MCreditAmount { get; set; }
        public decimal? SCreditRating { get; set; }
        public string SCreditRatingName { get; set; }
    }
}
