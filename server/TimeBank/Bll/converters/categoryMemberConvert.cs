using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.converters
{
    class categoryMemberConvert
    {

        public static Dal.Models.MemberCategory convertFromDtoToMicroWhithRouter(Dto.dtoClasses.categoryMember myMemberCategory,
            string phoneOfMember, string categoryName)
        {
           Dal.Models.MemberCategory m = convertFromDtoToMicro(myMemberCategory);
            Dal.Models.Member mem = Dal.functions.memberFun.getMemberByPhone(phoneOfMember);
            Dal.Models.Category c = Dal.functions.categoryFun.GetCategoryByName(categoryName);
            if (mem == null)
                return null;
                /*throw new Exception("החבר בעל הקטגוריה אינו קיים במערכת");*/
            m.MemberId = mem.Id;
            if (c == null)
                return null;
               /* throw new Exception("קטגוריה זו אינה קיימת במערכת");*/
            m.CategoryId = c.Id;
            return m;
        }

        public static Dto.dtoClasses.categoryMember convertFromMicToDto(Dal.Models.MemberCategory microMemberCategory)
        {
            Dto.dtoClasses.categoryMember m = new Dto.dtoClasses.categoryMember();
            m.Category =Bll.converters.categoryConvert.convertFromMicToDto(microMemberCategory.Category);
            m.ExperienceYears = microMemberCategory.ExperienceYears;
            m.ForGroup = microMemberCategory.ForGroup;
            m.MaxGroup = microMemberCategory.MaxGroup;
            m.MinGruop = microMemberCategory.MinGruop;
            m.Place = microMemberCategory.Place;
            m.PossibilityComeCustomerHome = microMemberCategory.PossibilityComeCustomerHome;
            m.RestrictionsDescription = microMemberCategory.RestrictionsDescription;
            m.reports =reportAndDetialConvert.ConvertListFromMicToDto(microMemberCategory.Reports.ToList());
            return m;
        }
        public static Dal.Models.MemberCategory convertFromDtoToMicro(Dto.dtoClasses.categoryMember dtoMemberCategory)
        {
            Dal.Models.MemberCategory m = new Dal.Models.MemberCategory();
            m.Category=Bll.converters.categoryConvert.convertFromDtoToMicro(dtoMemberCategory.Category);
            m.ExperienceYears= dtoMemberCategory.ExperienceYears;
            m.ForGroup= dtoMemberCategory.ForGroup;
            m.MaxGroup= dtoMemberCategory.MaxGroup;
            m.MinGruop= dtoMemberCategory.MinGruop;
            m.Place= dtoMemberCategory.Place;
            m.PossibilityComeCustomerHome= dtoMemberCategory.PossibilityComeCustomerHome;
            m.RestrictionsDescription= dtoMemberCategory.RestrictionsDescription;
/*            m.Reports = reportAndDetialConvert.ConvertListDtoToMic(dtoMemberCategory.reports);
*/            return m;
        }
        // (ממנו למיקרוסופט (חבר
      

        // ממיר רשימה של מיקרוסופט אלנו
        public static List<Dto.dtoClasses.categoryMember> ConvertListFromMicToDto(List<Dal.Models.MemberCategory> microMemberCategoryList)
        {
            List<Dto.dtoClasses.categoryMember> lm = new List<Dto.dtoClasses.categoryMember>();
            microMemberCategoryList.ForEach(m => lm.Add(convertFromMicToDto(m)));
            return lm;
        }
        // ממיר רשימה שלנו למיקרוסופט

        public static List<Dal.Models.MemberCategory> ConvertListFromDtoToMic(List<Dto.dtoClasses.categoryMember> dtoMemberCategoryList)
        {
            List<Dal.Models.MemberCategory> lm = new List<Dal.Models.MemberCategory>();
            dtoMemberCategoryList.ForEach(m => lm.Add(convertFromDtoToMicro(m)));
            return lm;
        }
    }
}
