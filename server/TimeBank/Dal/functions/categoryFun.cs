using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.functions
{
   public class categoryFun
    {
        // משתנה שמכיל את המסד
        static Models.TimeBankContext db = new Models.TimeBankContext();

        // פונקציה שמחזירה את הקטגוריות מהמסד בסוג המסד
        public static List<Models.Category> GetAllCategories()
        {
            try
            {
                db.Members.Include(m => m.MemberCategories).ToList();
                db.Reports.Include(m => m.ReportsDetails).ToList();
                db.MemberCategories.Include(m => m.Reports).ToList();
                db.MemberCategories.Include(m => m.Category).ToList();
                List<Models.Category> l = db.Categories.ToList();
                return db.Categories.ToList();

            }
            catch
            {
                return null;
            }
        }

       

        // פונ שמקבלת משתנה קטגוריה מסוג המסד ומוסיפה אותו למסד
        public static void addCategory(Dal.Models.Category newCate )
        {
            try
            {
                /*       db.Members.Include(m => m.MemberCategories).ToList();
                       db.Reports.Include(m => m.ReportsDetails).ToList();
                       db.MemberCategories.Include(m => m.Reports).ToList();
                       db.MemberCategories.Include(m => m.Category).ToList();*/

                newCate.FatherCategoryId = null;
                db.Categories.Add(newCate);
                db.SaveChanges();

                return;

            }
            catch
            {
                return;
            }
        }
        public static Dal.Models.Category GetCategoryByName(string name)
        {
            try
            {
                return db.Categories.FirstOrDefault(c => c.Name == name);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
