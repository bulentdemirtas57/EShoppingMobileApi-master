using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblGiftCard
    {
        public int IGiftCardId { get; set; }
        public int? IGiftCardTypeId { get; set; }
        public string SGiftCardCode { get; set; }
        public int? IUsable { get; set; }
        public int? ISalesStatusId { get; set; }
        public string SSalesStatusType { get; set; }
        public int? ISalesUserId { get; set; }
        public DateTime? DSellByDate { get; set; }
        public DateTime? DSellByDt { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? BEnable { get; set; }
        public int? BArchive { get; set; }
        public int? IPromotionId { get; set; }
        public int? IUpdateUserId { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public string SPromotionName { get; set; }
        public decimal? MCreditAmount { get; set; }
        public int? IUploadUserId { get; set; }
        public DateTime? DUploadDate { get; set; }
        public DateTime? DUploadDt { get; set; }
        public decimal? SCreditRating { get; set; }
    }
}
