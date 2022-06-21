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
        int _resourseLimit { get; set; } = Convert.ToInt32(new ResoursesLimitViewModel().ResoursesLimit);
        public ActualPriority(PriorityMode mode)
        {
            Priority = mode switch
            {
                PriorityMode.Hand => HandPriority.GetHandPriority(),
                PriorityMode.Max => MaxPriority.GetMaxPriority(),
                PriorityMode.Auto => AutoPriority.GetAutoPriority(),
                PriorityMode.Tehnologies => TehnologiesPriority.GetTehnologiesPriority()
            };
        }

        private List<Resourse> OutHavenResourses(List<Resourse> priority)
        {
            foreach (var item in priority)
            {
           
            }
            return priority;
        }
        private List<Resourse> OutOverLimitResourses(List<Resourse> priority)
        {
            foreach (var item in priority)
            {
                if (item.Number > _resourseLimit)
                {
                    priority.Remove(item);
                }
            }
            return priority;
        }
    }
}
