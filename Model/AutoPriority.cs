using Caliber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCaliber.Value;
using Caliber.ViewModels;
using System.Reflection;

namespace WPFCaliber.Model
{
    public class AutoPriority : Priority
    {
        public static void SetPriority()
        {
            ResourseValue resourse = LogObject.GetResourseValue();
            var resourseValueFields = typeof(ResourseValue).GetFields();

            foreach (var resourseField in resourseValueFields)
            {
                if (resourseField.Name == "sc")
                    continue;
                ResoursesCollectionEng res = (ResoursesCollectionEng)Enum.Parse(typeof(ResoursesCollectionEng), resourseField.Name);
                Resourse.DictNumResources[res].Number = (int)resourseField.GetValue(resourse);
            }
            SetDesiredNumber();
            OrderPriority();
            UpdateData();
        }
    }
}