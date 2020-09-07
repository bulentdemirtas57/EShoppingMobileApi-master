using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblSalesList
    {
        public int ISalesListId { get; set; }
        public int? IProductId { get; set; }
        public string SProductName { get; set; }
        public string SProductCount { get; set; }
        public string SProductImg { get; set; }
        public string SDescription { get; set; }
        public int? ICustomerId { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? BEnable { get; set; }
        public int? BArchive { get; set; }
    }
}
