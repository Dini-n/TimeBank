using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//DBNull.members.include(categories)
   
    //.toList()
namespace TimeBank.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("getAllCategories")]
        public ActionResult<List<Dto.dtoClasses.Category>> getAllCategories()
        {
            List<Dto.dtoClasses.Category> l = Bll.functions.categoriesFunctions.GetAllCategoriesBll();
            return Ok(l);
        }
        [HttpPost("addCategory")]
        public ActionResult<Dto.dtoClasses.Category> addCategory(Dto.dtoClasses.Category newCat ,string fatherName)
        {
            try
            {
                Bll.functions.categoriesFunctions.addCategory(newCat , fatherName);
                return Ok(newCat);
            }
            catch
            { return null; }

        }
    }
}
