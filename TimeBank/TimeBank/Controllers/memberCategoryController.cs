using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeBank.Controllers
{
     public class para
    {
        public string phone { get; set; }
        public string catName { get; set; }
        public Dto.dtoClasses.categoryMember newMemberCat { get; set; }

    }

    [Route("api/[controller]")]
    [ApiController]
    public class memberCategoryController : ControllerBase
    {//בפוסט שולחים רק משתנה אחד! בגט אפשר שתים בURL אבל אם אצ רוצה בפוסט-תצרי מערך
        [HttpPost("addMemberCategory")]
        public ActionResult<Dto.dtoClasses.categoryMember> addMemberCategory
            (para PhoneAndCatName)
        {
            Dto.dtoClasses.categoryMember newMemberCat = PhoneAndCatName.newMemberCat;
            string memberPhone = PhoneAndCatName.phone;
            string categoryName = PhoneAndCatName.catName;
            try
            {
                
                  Bll.functions.memberCategoryFunction.addMemberCategory(newMemberCat, memberPhone, categoryName);
                    return Ok(newMemberCat);
            }
            catch
            { return null; }

        }
        [HttpGet("getAllkeys")]
        public ActionResult<List<string>> getAllkeys()
        {
            Dictionary<string, List<Dto.dtoClasses.catPlusMember>> dd = Bll.functions.memberCategoryFunction.getAllCategoriesDict();
            List<string> keys = dd.Keys.ToList();
            //List<List<Dto.dtoClasses.categoryMember>> values = dd.Values.ToList();
            return Ok(keys);
        }
        [HttpGet("getAllValues")]

        public ActionResult<List<List<Dto.dtoClasses.catPlusMember>>> getAllValues()
        {
            Dictionary<string, List<Dto.dtoClasses.catPlusMember>> dd = Bll.functions.memberCategoryFunction.getAllCategoriesDict();
            List<string> keys = dd.Keys.ToList();
            List<List<Dto.dtoClasses.catPlusMember>> values = dd.Values.ToList();
            return Ok(values);
        }
    }
}
