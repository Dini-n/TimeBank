using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.functions
{
    public class categoriesFunctions
    {
        // מחזירה את כל הקטגוריות
        public static List<Dto.dtoClasses.Category> GetAllCategoriesBll()
        {
            List<Dto.dtoClasses.Category> l = Bll.converters.categoryConvert.ConvertListFromMicToDto(Dal.functions.categoryFun.GetAllCategories());
            return l;
        }
        // מוסיפה קטגוריה
        public static void addMember(Dto.dtoClasses.Category mnew , short? fatherCatId)
        {
            if (fatherCatId != null)
                mnew.fatherCategoryId = fatherCatId;
            else
                mnew.fatherCategoryId = null;
            Dal.functions.categoryFun.addMember(Bll.converters.categoryConvert.convertFromDtoToMicro(mnew));

        }
    }
}
