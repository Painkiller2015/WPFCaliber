using Caliber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliber.ViewModels;

namespace WPFCaliber.Model
{
    public class HandPriority
    {
        //TODO Брать с формы выставленный юзером лист 
        public static List<Resourse> GetHandPriority()
        {
            List<Resourse> priority = new ActuallyPriorityViewModel().ActuallyPriority;
            return priority;
        }
    }
}
