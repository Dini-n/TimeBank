using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TimeBank.Controllers
{
    public class postReport
    {
        public string phone { get; set; }
        public string categoryName { get; set; }

    }
    [Route("api/[controller]")]
    [ApiController]
    public class reportController : ControllerBase
    {
        /* [HttpPost("addReport")]
         public ActionResult<Dto.dtoClasses.ReportsAndDetail> addReport(Dto.dtoClasses.ReportsAndDetail rep, postReport p)
         {
             string phone = p.phone;
             string categoryName = p.categoryName;
             if (phone.Count() == 9)
                 phone = phone + " ";
             for (int i = categoryName.Count(); i < 30; i++)
             {
                 categoryName += " ";
             }
             if (rep.GetterMember.phone.Count() == 9)
                 phone = phone + " ";
             Bll.functions.reportFunction.addReport(phone, categoryName, rep);
             return Ok(rep);
         }*/
        [HttpPost("addReport/{phone}/{categoryName}")]
        public ActionResult<Dto.dtoClasses.ReportsAndDetail> addReport(string phone, string categoryName, Dto.dtoClasses.ReportsAndDetail rep)
        {
            if (phone.Count() == 9)
                phone = phone + " ";
            for (int i = categoryName.Count(); i < 30; i++)
            {
                categoryName += " ";
            }
            if (rep.GetterMember.phone.Count() == 9)
                phone = phone + " ";
           /* for (int i = rep.GetterMember.name.Count(); i < 40; i++)
            {
                categoryName += " ";
            }*/
            Bll.functions.reportFunction.addReport(phone, categoryName, rep);
            return Ok(rep);
        }
    }
}

