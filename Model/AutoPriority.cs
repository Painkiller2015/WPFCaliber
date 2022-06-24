using Caliber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCaliber.Value;

namespace WPFCaliber.Model
{
    public class AutoPriority : IPriority
    {
        public static void GetPriority()
        {
            ResourseValue resourse = LogObject.GetResourseValue();
            var resourseValueFields = typeof(ResourseValue).GetFields();

            foreach (var resourseField in resourseValueFields)
            {
                ResoursesCollectionEng res = (ResoursesCollectionEng)Enum.Parse(typeof(ResoursesCollectionEng), resourseField.Name);
                Resourse.DictNumResources[res].Number = (int)resourseField.GetValue(resourse);
            }
            SetPriority();
        }

        private static void SetPriority()
        {
            int priority = 0;
            foreach (var res in Resourse.DictNumResources.OrderByDescending(el => el.Value.Number))
                res.Value.Priority = priority++;
        }
    }
}
