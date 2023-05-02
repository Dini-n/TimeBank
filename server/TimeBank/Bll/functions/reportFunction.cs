using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.functions
{
    public  class reportFunction
    {
        public static void addReport(string phone, string categoryName,Dto.dtoClasses.ReportsAndDetail rep)
        {
            Dal.functions.reportFun.addReport(phone, categoryName, 
                Bll.converters.reportAndDetialConvert.convertFromDtoToMicro(rep));
        }
    }
}
