using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.converters
{
    class categoryMemberConvert
    {
        public static Dto.dtoClasses.categoryMember convertFromMicToDto(Dal.Models.MemberCategory microMemberCategory)
        {
            Dto.dtoClasses.categoryMember m = new Dto.dtoClasses.categoryMember();
            m.Category =Bll.converters.categoryConvert.convertFromMicToDto( microMemberCategory.Category);
            m.ExperienceYears = microMemberCategory.ExperienceYears;
            m.ForGroup = microMemberCategory.ForGroup;
            m.MaxGroup = microMemberCategory.MaxGroup;
            m.MinGruop = microMemberCategory.MinGruop;
            m.Place = microMemberCategory.Place;
            m.PossibilityComeCustomerHome = microMemberCategory.PossibilityComeCustomerHome;
            m.RestrictionsDescription = microMemberCategory.RestrictionsDescription;
            return m;
        }
        public static Dal.Models.MemberCategory convertFromDtoToMicro(Dto.dtoClasses.categoryMember dtoMemberCategory)
        {
            Dal.Models.MemberCategory m = new Dal.Models.MemberCategory();
            m.Category=Bll.converters.categoryConvert.convertFromDtoToMicro(dtoMemberCategory.Category);
            dtoMemberCategory.ExperienceYears = m.ExperienceYears;
            dtoMemberCategory.ForGroup= m.ForGroup;
            dtoMemberCategory.MaxGroup= m.MaxGroup;
            dtoMemberCategory.MinGruop = m.MinGruop;
            dtoMemberCategory.Place= m.Place;
            dtoMemberCategory.PossibilityComeCustomerHome= m.PossibilityComeCustomerHome;
             dtoMemberCategory.RestrictionsDescription = m.RestrictionsDescription;
            return m;
        }
        // (ממנו למיקרוסופט (חבר
      

        // ממיר רשימה של מיקרוסופט אלנו
        public static List<Dto.dtoClasses.categoryMember> ConvertListFromMicToDto(List<Dal.Models.MemberCategory> microMemberCategoryList)
        {
            List<Dto.dtoClasses.categoryMember> lm = new List<Dto.dtoClasses.categoryMember>();
            microMemberCategoryList.ForEach(m => lm.Add(convertFromMicToDto(m)));
            return lm;
        }
    }
}
