using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.dtoClasses
{
   public class Category
    {
        public string name { get; set; }
        public short? fatherCategoryId { get; set; }
        public bool? approved { get; set; }
        public short? amountPeopleOffered { get; set; }
    }
}
