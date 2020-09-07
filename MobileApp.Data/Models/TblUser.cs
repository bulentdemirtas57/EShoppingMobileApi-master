using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblUser
    {
        public int IUserId { get; set; }
        public int? IUserTypeId { get; set; }
        public int? IUserStatusId { get; set; }
        public int? IAddressId { get; set; }
        public string SFirstName { get; set; }
        public string SSurname { get; set; }
        public string SUserFullName { get; set; }
        public string SUserName { get; set; }
        public string SPassword { get; set; }
        public string PPhoto { get; set; }
        public string SBusinessPhone { get; set; }
        public DateTime? DBirthDate { get; set; }
        public DateTime? DFirstLoginDt { get; set; }
        public DateTime? DLastLoginDt { get; set; }
        public string SNotes { get; set; }
        public int? ILoginCount { get; set; }
        public int? ICreateUser { get; set; }
        public int? IUpdateUserId { get; set; }
        public DateTime? DUpdateDt { get; set; }
        public long? BEnable { get; set; }
        public long? BArchived { get; set; }
        public int? IPasswordReminderControl { get; set; }
        public DateTime? DPasswordReminderControlDt { get; set; }
        public int? IWrongPasswordEntryId { get; set; }
        public DateTime? DWrongPasswordEntryDt { get; set; }
        public int? ILastPasswordChangeId { get; set; }
        public DateTime? DLastPasswordChangeDt { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? IGenderId { get; set; }
        public string SGenderName { get; set; }
        public string ICourierNumber { get; set; }
        public decimal? MCreditAmount { get; set; }
        public string? SRefreshToken { get; set; }
        public DateTime? DRefreshTokenEndDate { get; set; }
    }
}
