using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Bll
{
    public class memberConvert
    {
        //המרת חבר ממיקרוסופט אלינו
       public static Dto.dtoClasses.member convertFromMicToDto(Dal.Models.Member microMember)
        {
            Dto.dtoClasses.member m = new Dto.dtoClasses.member();
            m.name = microMember.Name;
            m.password = microMember.Password;
            m.mail = microMember.Mail;
            m.phone = microMember.Phone;
            m.address = microMember.Address;
            m.yearBorn =  microMember.YearBorn;
            m.gender = microMember.Gender;
            m.remainingHours = new Dto.dtoClasses.Time();
            m.remainingHours.hours = microMember.RemainingHours.Hours;
            m.remainingHours.minutes = microMember.RemainingHours.Minutes;
            m.active = microMember.Active;
            m.toCheck = microMember.ToCheck;
            return m;
        }
        // (ממנו למיקרוסופט (חבר
        public static Dal.Models.Member convertFromDtoToMicro(Dto.dtoClasses.member m)
        {
            Dal.Models.Member microMember = new Dal.Models.Member();
            microMember.Name = m.name;
            microMember.Password = m.password ;
            microMember.Mail = m.mail;
            microMember.Phone = m.phone;
            microMember.Address = m.address;
            microMember.YearBorn =  m.yearBorn;
            microMember.Gender = m.gender;
            microMember.RemainingHours = new TimeSpan(m.remainingHours.hours,m.remainingHours.minutes,0);
            microMember.Active  = m.active;
            microMember.ToCheck = m.toCheck;
            return microMember;
        }

        // ממיר רשימה של מיקרוסופט אלנו
        public static List<Dto.dtoClasses.member> ConvertListFromMicToDto(List<Dal.Models.Member> microMemberList)
        {
            List<Dto.dtoClasses.member> lm = new List<Dto.dtoClasses.member>();
            microMemberList.ForEach(m => lm.Add(convertFromMicToDto(m)));
            return lm;
        }
    }
}
