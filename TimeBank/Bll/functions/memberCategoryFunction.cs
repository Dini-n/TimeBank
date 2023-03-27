using Bll.converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.functions
{
    public class memberCategoryFunction
    {
        public static void addMemberCategory(Dto.dtoClasses.categoryMember mcnew, string phoneOfMember,string categoryName)
        {
            Dal.functions.categoryMemberFun.addMemberCategory(Bll.converters.categoryMemberConvert.
                convertFromDtoToMicroWhithRouter(mcnew, phoneOfMember,categoryName));

        }
        public static Dictionary<string, List<Dto.dtoClasses.catPlusMember>> getAllCategoriesDict()
        {
            Dictionary<string, List<Dal.Models.MemberCategory>> dDal = Dal.functions.categoryMemberFun.getAllCategoriesDict();
            Dictionary<string, List<Dto.dtoClasses.catPlusMember>> d = new Dictionary<string, List<Dto.dtoClasses.catPlusMember>>();
            foreach (var item in dDal)
            {
                d.Add(item.Key, catPlusMemberConvert.convertFromMicToDto(item.Value));
            }
            return d;
        }
    }
}
