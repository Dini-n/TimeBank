using Dal.Models;
using Dto.dtoClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.functions;
using Microsoft.EntityFrameworkCore;

namespace Bll.converters
{
   public class catPlusMemberConvert
    {
        public static Dto.dtoClasses.catPlusMember convertFromMicToDto(Dal.Models.MemberCategory microMemberCategory)
        {
            Dto.dtoClasses.catPlusMember m = new Dto.dtoClasses.catPlusMember();
            m.memGiverName = microMemberCategory.Member.Name;
            m.memPhone = microMemberCategory.Member.Phone;
            m.memEmail = microMemberCategory.Member.Mail;
            m.Category = Bll.converters.categoryConvert.convertFromMicToDto(microMemberCategory.Category);
            m.ExperienceYears = microMemberCategory.ExperienceYears;
            m.ForGroup = microMemberCategory.ForGroup;
            m.MaxGroup = microMemberCategory.MaxGroup;
            m.MinGruop = microMemberCategory.MinGruop;
            m.Place = microMemberCategory.Place;
            m.PossibilityComeCustomerHome = microMemberCategory.PossibilityComeCustomerHome;
            m.RestrictionsDescription = microMemberCategory.RestrictionsDescription;
            return m;
        }

        public static List<catPlusMember> convertFromMicToDto(List<MemberCategory> microList)
        {
            List<catPlusMember> l = new List<catPlusMember>();
            microList.ForEach(m => l.Add(convertFromMicToDto(m)));
            return l;
        }
    }
}
