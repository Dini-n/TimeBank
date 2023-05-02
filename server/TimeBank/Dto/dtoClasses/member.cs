using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.dtoClasses
{
    public class Time
    {
        public int hours { get; set; }
        public int minutes { get; set; }
        public Time()
        {
        }
         public Time(int h, int m)
        {
            this.hours = h;
            this.minutes = m;
        }
    }
    public class member
    {
        public member()
        {
            Categories = new List<categoryMember>();
        }
       
        public string name { get; set; }
        public string password { get; set; }
        public string? mail { get; set; }
        public string phone { get; set; }
        public string? address { get; set; }
        public int yearBorn { get; set; }
        public bool gender { get; set; }
        public Time remainingHours { get; set; }
        public bool active { get; set; }
        public bool? toCheck { get; set; }
        public bool? IsManager { get; set; }
        public List<categoryMember> Categories
        {
            get;
            set;
        }
    }
}
