using Caliber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliber.ViewModels;
using WPFCaliber.Value;

namespace WPFCaliber.Model
{
    public class HandPriority : Priority
    {
        //TODO Брать с формы выставленный юзером лист, мб выкинуть этот класс
        public Dictionary<ResoursesCollectionEng, Resourse> ResourseCollection { get => Resourse.DictNumResources; }
        public static void SetPriority()
        {
            SetDesiredNumber();
            OrderPriority();
            UpdateData();
        }
    }
}
