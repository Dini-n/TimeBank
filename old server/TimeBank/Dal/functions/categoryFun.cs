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
                List<Models.Category> l = db.Categories.ToList();
                return db.Categories.ToList();
            }
            catch
            {
                return null;
            }
        }
        // פונ שמקבלת משתנה קטגוריה מסוג המסד ומוסיפה אותו למסד
        public static void addMember(Dal.Models.Category newCate )
        {
            try
            {
                db.Categories.Add(newCate);
                db.SaveChanges();
                return;

            }
            catch
            {
                return;
            }
        }
      
    }
}
