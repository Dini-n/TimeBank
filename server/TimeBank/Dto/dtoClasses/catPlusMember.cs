using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.dtoClasses
{
    public class catPlusMember
    {
        
        public catPlusMember()
        {
            Category = new Category();
        }
     //-----------------פרטי נותן הפעולה-----------
        public string memGiverName { get; set; }
        public string memPhone { get; set; }
        public string memEmail { get; set; }
        //---------------- פרטי קטגורית הפעולה של הנותן-----------
        public Category Category { get; set; }
        //0---------------המשך תיאור הקטגוריה פר חבר
        public string Place { get; set; }
        public bool? PossibilityComeCustomerHome { get; set; }
        public short? ExperienceYears { get; set; }
        public string RestrictionsDescription { get; set; }
        public bool? ForGroup { get; set; }
        public short? MinGruop { get; set; }
        public short? MaxGroup { get; set; }
    }
}
