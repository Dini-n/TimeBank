using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.Models
{
    public partial class Report
    {
        public Report()
        {
            ReportsDetails = new HashSet<ReportsDetail>();
        }

        public short Id { get; set; }
        public short GiverId { get; set; }
        public short CategoryId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Hour { get; set; }
        public string Note { get; set; }

        public virtual MemberCategory Category { get; set; }
        public virtual Member Giver { get; set; }
        public virtual ICollection<ReportsDetail> ReportsDetails { get; set; }
    }
}
