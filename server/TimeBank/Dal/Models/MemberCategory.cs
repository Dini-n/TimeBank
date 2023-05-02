using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.Models
{
    public partial class MemberCategory
    {
        public MemberCategory()
        {
            Reports = new HashSet<Report>();
        }

        public short Id { get; set; }
        public short MemberId { get; set; }
        public short CategoryId { get; set; }
        public string Place { get; set; }
        public bool? PossibilityComeCustomerHome { get; set; }
        public short? ExperienceYears { get; set; }
        public string RestrictionsDescription { get; set; }
        public bool? ForGroup { get; set; }
        public short? MinGruop { get; set; }
        public short? MaxGroup { get; set; }

        public virtual Category Category { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
