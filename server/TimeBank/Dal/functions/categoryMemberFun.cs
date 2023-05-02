using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.functions
{
    public class categoryMemberFun
    {
        static Models.TimeBankContext db = new Models.TimeBankContext();
        // פונקציה שמחזירה את הקטגוריות של חבר מהמסד בסוג המסד
        public static List<Models.MemberCategory> GetAllmemberCat()
        {
            try
            {
                db.Members.Include(m => m.MemberCategories).ToList();
                db.Reports.Include(m => m.ReportsDetails).ToList();
                db.MemberCategories.Include(m => m.Reports).ToList();
                db.MemberCategories.Include(m => m.Category).ToList();
                List<Models.MemberCategory> l = db.MemberCategories.ToList();
                return l;

            }
            catch
            {
                return null;
            }
        }

        public static Dictionary<string, List<Dal.Models.MemberCategory>> getAllCategoriesDict()

        {
            db.MemberCategories.Include(mc => mc.Member).ToList();
            Dictionary<string, List<Dal.Models.MemberCategory>> d = new Dictionary<string, List<Models.MemberCategory>>();
            db.Categories.ToList().ForEach(n => d.Add(n.Name,
            db.MemberCategories.ToList().Where(k => k.Category.Name == n.Name).ToList()));
            return d;


        }

        // פונ שמקבלת משתנה קטגורית חבר מסוג המסד ומוסיפה אותו למסד
        public static void addMemberCategory(Dal.Models.MemberCategory newMemCate)
        {
            try
            {
                //db.Members.Include(m => m.MemberCategories).ToList();
                //db.Reports.Include(m => m.ReportsDetails).ToList();
                // db.MemberCategories.Include(m => m.Reports).ToList();
                // db.MemberCategories.Include(m => m.Category).ToList();
                Dal.Models.MemberCategory r = new Dal.Models.MemberCategory() {
                    CategoryId = newMemCate.CategoryId,
                    MemberId = newMemCate.MemberId,
                    ExperienceYears = newMemCate.ExperienceYears,
                    Place = newMemCate.Place,
                    MinGruop = newMemCate.MinGruop,
                    RestrictionsDescription = newMemCate.RestrictionsDescription,
                    PossibilityComeCustomerHome = newMemCate.PossibilityComeCustomerHome
                };
                /*,ExperienceYears = newMemCate.ExperienceYears,ForGroup=newMemCate.ForGroup
                                    ,Place= newMemCate.Place,PossibilityComeCustomerHome = newMemCate.PossibilityComeCustomerHome,*/
                newMemCate.Category = null;
                newMemCate.Member = null;
                db.MemberCategories.Add(r);
                db.SaveChanges();

                return;

            }
            catch(Exception e)
            {
                throw new Exception("it is not work");
            }
        }
        public static Dal.Models.Category GetCategoryIdByName(string name)
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
