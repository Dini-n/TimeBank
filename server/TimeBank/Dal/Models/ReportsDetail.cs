using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.Models
{
    public partial class ReportsDetail
    {
        public short Id { get; set; }
        public short ReportId { get; set; }
        public short GetterMemberId { get; set; }
        public bool? ReceiverApproved { get; set; }

        public virtual Member GetterMember { get; set; }
        public virtual Report Report { get; set; }
    }
}
