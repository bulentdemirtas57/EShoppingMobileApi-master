using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblProduct
    {
        public int IProductId { get; set; }
        public int? ICategoryId { get; set; }
        public int? ISubCategoryId { get; set; }
        public string SCategoryName { get; set; }
        public string SSubCategoryName { get; set; }
        public string SProductCode { get; set; }
        public string SProductName { get; set; }
        public string SDescription { get; set; }
        public string SProductImg { get; set; }
        public decimal? SProductPurchasePrice { get; set; }
        public decimal? IProductPrice { get; set; }
        public decimal? IProductPriceF { get; set; }
        public int? IProductDepositId { get; set; }
        public decimal? IProductDeposit { get; set; }
        public int? IProductStock { get; set; }
        public int? IBrandId { get; set; }
        public string SBrandName { get; set; }
        public int? ProductPriceTypeId { get; set; }
        public string SProductPriceTypeName { get; set; }
        public int? IHalalId { get; set; }
        public string SHalalName { get; set; }
        public int? IProductRow { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public DateTime? DUpdateDate { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public int? ICreateUserId { get; set; }
        public long? BEnable { get; set; }
        public long? BArchive { get; set; }
        public string SCreateUserFullName { get; set; }
        public string SProductStatus { get; set; }
        public int? IProductStatusId { get; set; }
        public decimal? SProfit { get; set; }
        public int? IDiscountId { get; set; }
    }
}
