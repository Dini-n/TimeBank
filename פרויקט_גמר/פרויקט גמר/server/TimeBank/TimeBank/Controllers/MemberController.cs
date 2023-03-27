using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        [HttpGet("getAllMembers")]
        public ActionResult<List<Dto.dtoClasses.member>> getAllMembers()
        {
            return Ok(Bll.functions.memberFunctions.GetAllMembersBll());
        }
        //הוספת חבר חדש
        [HttpPost("addMember")]
        public ActionResult<Dto.dtoClasses.member> addMember(Dto.dtoClasses.member newMem)
        {
            try
            { 
             Bll.functions.memberFunctions.addMember(newMem);
             return Ok(newMem);
            }
            catch
            { return null; }

        }

        /* [HttpPost("aproveMember")]
         public ActionResult<Dto.dtoClasses.member> aproveMember(Dto.dtoClasses.member newMem)
         {
             try
             {
                 Bll.functions.memberFunctions.addMember(newMem);
                 return Ok(newMem);
             }
             catch
             { return null; }

         }*/
        [HttpGet("getMemberByName/{name}")]
        public ActionResult<List<Dto.dtoClasses.member>> getMemberByName(string name)
        {
            return Ok(Bll.functions.memberFunctions.getMemberByName(name));
        }
        [HttpGet("getMemberByPhone/{phone}")]
        public ActionResult<Dto.dtoClasses.member> getMemberByPhone(string phone)
        {
            Dto.dtoClasses.member d= Bll.functions.memberFunctions.getMemberByPhone(phone);
            return Ok(d);
        }
    }
}
