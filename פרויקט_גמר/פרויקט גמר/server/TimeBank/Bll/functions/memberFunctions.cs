using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.functions
{
   public class memberFunctions
    {
        public static List<Dto.dtoClasses.member> GetAllMembersBll()
        {
           return  Bll.memberConvert.ConvertListFromMicToDto(Dal.functions.memberFun.GetAllMembers());
        }
        public static void addMember(Dto.dtoClasses.member mnew)
        {
            Dal.functions.memberFun.addMember(memberConvert.convertFromDtoToMicro(mnew));
        }
        public static List<Dto.dtoClasses.member> getMemberByName(string name)
        {
            return Bll.memberConvert.ConvertListFromMicToDto(Dal.functions.memberFun.getMemberByName(name));
        }
        public static Dto.dtoClasses.member getMemberByPhone(string phone)
        {
            Dto.dtoClasses.member d= Bll.memberConvert.convertFromMicToDto(Dal.functions.memberFun.getMemberByPhone(phone));
            return d;
        }
    }
}
