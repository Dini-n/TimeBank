using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.Models
{
    public partial class Category
    {
        public Category()
        {
            InverseFatherCategory = new HashSet<Category>();
            MemberCategories = new HashSet<MemberCategory>();
            WaitingLists = new HashSet<WaitingList>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public short? FatherCategoryId { get; set; }
        public bool? Approved { get; set; }
        public short? AmountPeopleOffered { get; set; }

        public virtual Category FatherCategory { get; set; }
        public virtual ICollection<Category> InverseFatherCategory { get; set; }
        public virtual ICollection<MemberCategory> MemberCategories { get; set; }
        public virtual ICollection<WaitingList> WaitingLists { get; set; }
    }
}
