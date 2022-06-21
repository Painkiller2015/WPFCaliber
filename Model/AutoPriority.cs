using Caliber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCaliber.Model
{
    internal class AutoPriority
    {
        public static List<Resourse> GetAutoPriority()
        {
            List<Resourse> resoursesOrderByNumber = Resourse.DictNumResources.Values.OrderBy(el => el.Number).ToList();
            return resoursesOrderByNumber;
        }
    }
}
