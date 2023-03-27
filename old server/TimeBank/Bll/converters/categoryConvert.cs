using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.converters
{
   public class categoryConvert
    {
        //המרת קטגוריה ממיקרוסופט אלינו
        public static Dto.dtoClasses.Category convertFromMicToDto(Dal.Models.Category microCategory)
        {
            Dto.dtoClasses.Category retCategory = new Dto.dtoClasses.Category();
            retCategory.name = microCategory.Name;
            retCategory.fatherCategoryId = microCategory.FatherCategoryId;
            retCategory.approved = microCategory.Approved;
            retCategory.amountPeopleOffered = microCategory.AmountPeopleOffered;

            return retCategory;
                }

        // (ממנו למיקרוסופט (קטגוריה
        public static Dal.Models.Category convertFromDtoToMicro(Dto.dtoClasses.Category c)
        {
            Dal.Models.Category microCategory = new Dal.Models.Category();
            microCategory.Name = c.name; 
            microCategory.FatherCategoryId = c.fatherCategoryId;
            microCategory.Approved =  c.approved;
            microCategory.AmountPeopleOffered = c.amountPeopleOffered ;
            return microCategory;
        }

        // ממיר רשימה של מיקרוסופט אלנו
        public static List<Dto.dtoClasses.Category> ConvertListFromMicToDto(List<Dal.Models.Category> microCategoryList)
        {
            List<Dto.dtoClasses.Category> lc = new List<Dto.dtoClasses.Category>();
            microCategoryList.ForEach(m => lc.Add(convertFromMicToDto(m)));
            return lc;
        }
    }
}
