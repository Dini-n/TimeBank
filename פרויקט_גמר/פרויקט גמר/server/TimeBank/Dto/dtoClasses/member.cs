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
    }
    public class member
    {
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
    }
}
