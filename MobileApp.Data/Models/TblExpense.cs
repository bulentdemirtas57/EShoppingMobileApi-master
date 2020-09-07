using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblExpense
    {
        public int IExpenseId { get; set; }
        public int? IExpenseTypeId { get; set; }
        public string SExpenseTypeName { get; set; }
        public decimal? SExpenseMoney { get; set; }
        public int? ICreateUserId { get; set; }
        public string SExpenseContent { get; set; }
        public DateTime? DExpenseDate { get; set; }
        public int? IExpenseStatuId { get; set; }
        public string SExpenseStatuName { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? BEnable { get; set; }
        public int? BArchive { get; set; }
    }
}
