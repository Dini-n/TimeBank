using System;

namespace Dto.dtoClasses
{
    public class Receiver
    {
        public string name { get; set; }
        public string phone { get; set; }
        public Receiver(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
    }

    public class ReportsAndDetail
    {
        public DateTime Date { get; set; }
        public Time time { get; set; }
        public string Note { get; set; }
        // כאן להפוך את זה אחר כך למערך
        public Receiver GetterMember { get; set; }
        public bool? ReceiverApproved { get; set; } 
    }
}