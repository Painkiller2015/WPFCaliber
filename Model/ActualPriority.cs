using Caliber;
using Caliber.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WPFCaliber.Value;

namespace WPFCaliber.Model
{
    public class ActualPriority
    {
        //TODO выкинуть поле Priority, пусть все всё из словаря берут
        public List<Resourse> Priority { get; }
        //int _resourseLimit { get; set; } = Convert.ToInt32(new ResoursesLimitViewModel().ResoursesLimit);
        public ActualPriority(PriorityMode mode)
        {
            switch (mode)
            {
                case PriorityMode.Hand: HandPriority.GetHandPriority(); break;
                case PriorityMode.Max: MaxPriority.GetMaxPriority(); break;
                case PriorityMode.Auto: AutoPriority.GetPriority(); break;
                case PriorityMode.Tehnologies: TehnologiesPriority.GetTehnologiesPriority(); break;
            }
        }

        public static void OutHavenResourses(List<Resourse> priority)
        {
            foreach (var item in priority)
            {

            }

        }
        public static void OutOverLimitResourses(List<Resourse> priority)
        {
            foreach (var item in priority)
            {
                if (item.Number > Convert.ToInt32(new ResoursesLimitViewModel().ResoursesLimit))
                {
                    priority.Remove(item);
                }
            }
        }
    }
}
