using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblRecommendedProduct
    {
        public int IRecommendedProductId { get; set; }
        public string SRecommendedProductName { get; set; }
        public int? ICountryId { get; set; }
        public string SCountryName { get; set; }
        public int? IConsumptionFrequencyId { get; set; }
        public string SConsumptionFrequencyName { get; set; }
        public int? IUserId { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? BEnable { get; set; }
        public int? BArchive { get; set; }
        public int? IApprovedId { get; set; }
        public string SApprovedName { get; set; }
        public int? IStatusId { get; set; }
        public string SStatusName { get; set; }
    }
}
