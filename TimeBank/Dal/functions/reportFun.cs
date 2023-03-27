using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.functions
{
    public class reportFun
    {
        // משתנה שמכיל את המסד
        static Models.TimeBankContext db = new Models.TimeBankContext();

        public static void addReport(string phone,string categoryName,Report rep )
        {
            try
            {
                db.Members.Include(m => m.MemberCategories).ToList();
                db.Reports.Include(m => m.ReportsDetails).ToList();
                db.MemberCategories.Include(m => m.Reports).ToList();
                db.MemberCategories.Include(m => m.Category).ToList();
                //תקח מטבלת החברים את החבר 
            /*    Dal.Models.Member m = db.Members.FirstOrDefault(m => m.Phone == phone);
                //תחפש את הקטגוריה הנכונה
                Dal.Models.MemberCategory mC= m.MemberCategories.FirstOrDefault(c => c.Category.Name == categoryName);
                    //תוסיף לה את הדיווח
                Dal.Models.Report r= (rep);
                mC.Reports.Add(r);*/
               /* r.Category = mC;
                mC.Member = m;*/

                db.Members.FirstOrDefault(m => m.Phone == phone).MemberCategories.
                    FirstOrDefault(c => c.Category.Name == categoryName).Reports.
                    Add(rep);
               
                Dal.Models.Member r= db.Members.FirstOrDefault(m => m.Phone == phone);
                db.SaveChanges();
                return;
            }
            catch(Exception e)
            {
                throw new Exception();
            }
    
        }
    }
}
