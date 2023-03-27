using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.converters
{
    public class reportAndDetialConvert:IEnumerable
    {
        public static Dto.dtoClasses.ReportsAndDetail convertFromMicToDto(Dal.Models.Report report )
        {
            Dto.dtoClasses.ReportsAndDetail r = new Dto.dtoClasses.ReportsAndDetail();
            r.Date = report.Date;
            //כאן יש צורך לעשות לולאה עבור כל חברי הפעולה שקבלו.
            //ההמרה מתבצעת לרשימה כדי לגשת למקום הראשון כי יש חבר אחד
            //בניית החבר היחיד בינתיים שמקבל את הפעולה
            if (report.ReportsDetails.Count() != 0)
            {
                r.GetterMember = new Dto.dtoClasses.Receiver(report.ReportsDetails.ToList()[0].GetterMember.Name, report.ReportsDetails.ToList()[0].GetterMember.Phone);

                r.ReceiverApproved = report.ReportsDetails.ToList()[0].ReceiverApproved;
            }
            r.time =new Dto.dtoClasses.Time( report.Hour.Hours,report.Hour.Minutes);
            r.Note = report.Note;
            return r;
        }
        // (ממנו למיקרוסופט (חבר
        public static Dal.Models.Report convertFromDtoToMicro(Dto.dtoClasses.ReportsAndDetail report)
        {

            Dal.Models.Report r = new Dal.Models.Report();
            r.Date = report.Date;
            //כאן יש צורך לעשות לולאה עבור כל חברי הפעולה שקבלו.
            //ההמרה מתבצעת לרשימה כדי לגשת למקום הראשון כי יש חבר אחד
            //עי הפל' בניית החבר היחיד בינתיים שמקבל את הפעולה     
           
            r.ReportsDetails.Add(new Dal.Models.ReportsDetail()
            { 
                    GetterMemberId = Dal.functions.memberFun.getMemberByPhone(report.GetterMember.phone).Id,
                    ReceiverApproved = report.ReceiverApproved
                    ,GetterMember = Dal.functions.memberFun.getMemberByPhone(report.GetterMember.phone)
                   
            });;
            return r;
        }
        public static Dal.Models.Report convertFromDtoToMicroWhithRouter(Dto.dtoClasses.ReportsAndDetail report, string categoryName,string phone)
        {
            Dal.Models.Report r = new Dal.Models.Report();
            r.Date = report.Date;
            //כאן יש צורך לעשות לולאה עבור כל חברי הפעולה שקבלו.
            //ההמרה מתבצעת לרשימה כדי לגשת למקום הראשון כי יש חבר אחד
            //עי הפל' בניית החבר היחיד בינתיים שמקבל את הפעולה     
            r.ReportsDetails.Add(new Dal.Models.ReportsDetail()
            {
                GetterMemberId = Dal.functions.memberFun.getMemberByPhone(report.GetterMember.phone).Id,
                ReceiverApproved = report.ReceiverApproved
                    ,
                GetterMember = Dal.functions.memberFun.getMemberByPhone(report.GetterMember.phone)

            }); ;
            r.Category.Category = Dal.functions.categoryFun.GetAllCategories().FirstOrDefault(c => c.Name == categoryName);
            r.CategoryId = Dal.functions.categoryFun.GetAllCategories().FirstOrDefault(c => c.Name == categoryName).Id;
            r.Giver = Dal.functions.memberFun.GetAllMembers().FirstOrDefault(m => m.Phone == phone);
            r.GiverId = Dal.functions.memberFun.GetAllMembers().FirstOrDefault(m => m.Phone == phone).Id;
            r.Hour = new TimeSpan(report.time.hours, report.time.minutes, 0);
            r.Note = report.Note;
            return r;
        }
        // ממיר רשימה של מיקרוסופט אלנו
        public static List<Dto.dtoClasses.ReportsAndDetail> ConvertListFromMicToDto(List<Dal.Models.Report> microMemberList)
        {
            List<Dto.dtoClasses.ReportsAndDetail> lm = new List<Dto.dtoClasses.ReportsAndDetail>();
            microMemberList.ForEach(m => lm.Add(convertFromMicToDto(m)));
            return lm;
        }

        // ממיר רשימה שלנו למיקרוסופט
        public static List<Dal.Models.Report> ConvertListDtoToMic(List<Dto.dtoClasses.ReportsAndDetail> dto)
        {
            List<Dal.Models.Report> mic = new List<Dal.Models.Report>();
            dto.ForEach(m => mic.Add(convertFromDtoToMicro(m)));
            return mic;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
