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
            return Ok(Bll.functions.memberFunction.GetAllMembersBll());
        }
        //הוספת חבר חדש
        [HttpPost("addMember")]
        public ActionResult<Dto.dtoClasses.member> addMember(Dto.dtoClasses.member newMem)
        {
            try
            { 
             Bll.functions.memberFunction.addMember(newMem);
             return Ok(newMem);
            }
            catch
            { return null; }

        }

        [HttpPut("aproveMember/{phone}")]
        public ActionResult<int> aproveMember(string phone)
        {
            try
            {
                Bll.functions.memberFunction.approveMember(phone);
                /*פה לקרוא לפונקציות של השכבות מתחת שלוקחות את החבר שנשלח ופשוט משנות את הערך של צק לשקר*/
                return Ok(1);
            }
            catch
            { return BadRequest(0); }

        }
        //getMemberByPhone
        [HttpGet("getMemberByPhone/{phone}")]
        public ActionResult<List<Dto.dtoClasses.member>> getMemberByPhone(string phone)
        {
            return Ok(Bll.functions.memberFunction.getMemberByPhone(phone));
        }
    }
}

