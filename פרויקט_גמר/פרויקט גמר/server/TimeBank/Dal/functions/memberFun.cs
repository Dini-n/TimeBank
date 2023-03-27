using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.functions
{
    public class memberFun
    {
        static Models.TimeBankContext db = new Models.TimeBankContext();
        public static List<Models.Member> GetAllMembers()
        {
            try
            {
                return db.Members.ToList();
            }
            catch
            {
                return null;
            }
        }
        public static void addMember(Dal.Models.Member newm)
        {
            try
            {
                db.Members.Add(newm);
                db.SaveChanges();
            }
            catch
            {
                return;
            }
        }
        public static List< Models.Member> getMemberByName(string name)
        {

            try
            {
                return db.Members.Where(x => x.Name == name).ToList(); 
            }
            catch
            {
                throw new Exception();
            }
        }
        //getMemberByPhone(int phone)
        public static Models.Member getMemberByPhone(string phone)
        {

            try
            {
                Models.Member m= db.Members.FirstOrDefault(x => x.Phone.Equals(phone)); ;
                return m;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
