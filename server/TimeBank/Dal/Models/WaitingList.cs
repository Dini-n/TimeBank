using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.Models
{
    public partial class WaitingList
    {
        public short Id { get; set; }
        public short MemberId { get; set; }
        public short CategoryId { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual Member Member { get; set; }
    }
}
