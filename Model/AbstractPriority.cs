using Caliber;
using Caliber.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCaliber.Value;
using System.Reflection;

namespace WPFCaliber.Model
{
    public abstract class Priority
    {
        protected static ResourseValue _limitResourseValue = new();
        protected Priority()
        {
            ModeViewModel.ModeChanged += (obj, mode) =>
            {
                int resourseLimit = Convert.ToInt32(VMLoader.Resolve<LimitResoursesViewModel>().LimitResourses);
                var resourseValueType = typeof(ResourseValue).GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

                switch (mode)
                {
                    case PriorityMode.Hand:

                        foreach (var field in resourseValueType)
                            field.SetValue(_limitResourseValue, resourseLimit);
                        break;

                    case PriorityMode.Max:

                        _limitResourseValue = MaxPriority.GetMaxPrise();
                        break;

                    case PriorityMode.Auto:

                        foreach (var field in resourseValueType)
                            field.SetValue(_limitResourseValue, resourseLimit);
                        break;

                    case PriorityMode.Tehnologies:

                        _limitResourseValue = TehnologiesPriority.GetPrice();
                        break;
                }
            };
        }
        protected static void SetDesiredNumber()
        {
            var resourseValueFields = typeof(ResourseValue).GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            foreach (var resourseField in resourseValueFields)
            {
                if (resourseField == resourseValueFields[0])
                    continue;

                var resourse = Enum.Parse(typeof(ResoursesCollectionEng), resourseField .Name);

                ResoursesCollectionEng res = (ResoursesCollectionEng)resourse;

                int neededResourse = Resourse.DictNumResources[res].Number - (int)resourseField.GetValue(_limitResourseValue);

                if (neededResourse <= 0)
                    Resourse.DictNumResources[res].DesiredNumber = 0;
                else
                    Resourse.DictNumResources[res].DesiredNumber = neededResourse;
            }
        }
        protected static void OrderPriority()
        {
            int priority = 0;
            foreach (var res in Resourse.DictNumResources.OrderBy(el => el.Value.DesiredNumber))
                res.Value.Priority = priority++;
        }
        protected static void UpdateData()
        {
            VMLoader.Resolve<ActuallyPriorityViewModel>().UpdateCollection();
            VMLoader.Resolve<NeededResoursesViewModel>().UpdateCollection();
            VMLoader.Resolve<DifferendResourseViewModel>().UpdateCollection();
        }
    }
}
