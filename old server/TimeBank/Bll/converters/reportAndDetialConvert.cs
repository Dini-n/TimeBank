using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.converters
{
    public class reportAndDetialConvert
    {
        public static Dto.dtoClasses.ReportsAndDetail convertFromMicToDto(Dal.Models.Report report)
        {
            Dto.dtoClasses.ReportsAndDetail r = new Dto.dtoClasses.ReportsAndDetail();
            r.Date = report.Date;
            //כאן יש צורך לעשות לולאה עבור כל חברי הפעולה שקבלו.
            //ההמרה מתבצעת לרשימה כדי לגשת למקום הראשון כי יש חבר אחד
            //בניית החבר היחיד בינתיים שמקבל את הפעולה
            r.GetterMember = new Dto.dtoClasses.Receiver(report.ReportsDetails.ToList()[0].GetterMember.Name, report.ReportsDetails.ToList()[0].GetterMember.Phone);
            r.time = new Dto.dtoClasses.Time(report.Hour.Hours, report.Hour.Minutes);
            r.ReceiverApproved = report.ReportsDetails.ToList()[0].ReceiverApproved;
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
            r.ReportsDetails.ToList()[0].GetterMember = Dal.functions.memberFun.getMemberByPhone(report.GetterMember.phone);
            r.ReportsDetails.ToList()[0].ReceiverApproved = report.ReceiverApproved;
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
    }
}
