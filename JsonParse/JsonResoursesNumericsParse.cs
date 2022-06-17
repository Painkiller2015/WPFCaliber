using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCaliber.Value;

namespace Caliber
{
    public class JsonResoursesNumericsParse
    {
        public ResourseValue ResourseValue { get; private set; }
        JsonResoursesNumericsParse()
        {
            ResourseValue = GetLogObject.GetResoursesAsync();
        }
    }
}
