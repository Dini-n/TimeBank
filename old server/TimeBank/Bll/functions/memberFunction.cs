using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.functions
{
   public class memberFunction
    {
        
        public static Dto.dtoClasses.member getMemberByPhone(string name)
        {
            return Bll.memberConvert.convertFromMicToDto
                (Dal.functions.memberFun.getMemberByPhone(name));
        }
        public static List<Dto.dtoClasses.member> GetAllMembersBll()
        {
            return Bll.memberConvert.ConvertListFromMicToDto(Dal.functions.memberFun.GetAllMembers());
        }
        public static void addMember(Dto.dtoClasses.member mnew)
        {
            Dal.functions.memberFun.addMember(memberConvert.convertFromDtoToMicro(mnew));
        }
        public static void approveMember(string phone)
        {
            Dal.functions.memberFun.approveMember(phone);
        }
    }
}
