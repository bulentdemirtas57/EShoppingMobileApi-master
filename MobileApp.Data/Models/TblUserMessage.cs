using System;
using System.Collections.Generic;

namespace MobileApp.Data.Models
{
    public partial class TblUserMessage
    {
        public int IUserMessageId { get; set; }
        public string SUserMessageContent { get; set; }
        public int? IReadId { get; set; }
        public string SReadName { get; set; }
        public int? ISenderId { get; set; }
        public int? IReceiverId { get; set; }
        public int? ISenderDeleteId { get; set; }
        public DateTime? ISenderDeleteDate { get; set; }
        public DateTime? DCreateDate { get; set; }
        public DateTime? DCreateDt { get; set; }
        public int? BArchive { get; set; }
        public int? BEnable { get; set; }
        public DateTime? DReceiverDate { get; set; }
        public DateTime? DReceiverDt { get; set; }
        public string SSenderName { get; set; }
        public DateTime? DReadDate { get; set; }
    }
}
