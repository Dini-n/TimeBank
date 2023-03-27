using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.Models
{
    public partial class Member
    {
        public Member()
        {
            MemberCategories = new HashSet<MemberCategory>();
            Reports = new HashSet<Report>();
            ReportsDetails = new HashSet<ReportsDetail>();
            WaitingLists = new HashSet<WaitingList>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int YearBorn { get; set; }
        public bool Gender { get; set; }
        public TimeSpan RemainingHours { get; set; }
        public bool Active { get; set; }
        public bool? ToCheck { get; set; }
        public bool? IsManager { get; set; }

        public virtual ICollection<MemberCategory> MemberCategories { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<ReportsDetail> ReportsDetails { get; set; }
        public virtual ICollection<WaitingList> WaitingLists { get; set; }
    }
}
