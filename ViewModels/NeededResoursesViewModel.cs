using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Caliber;
using DevExpress.Mvvm;

namespace Caliber.ViewModels
{
    internal class NeededResoursesViewModel : BindableBase, ISingleton
    {
        public List<int> NeededResourses { get; set; } = new();
        public NeededResoursesViewModel()
        {
            ResoursesLimitViewModel resourses = new();
            int neededResourses = default;

            foreach (var item in Resourse.DictNumResources)
            {
                neededResourses = Convert.ToInt32(resourses.ResoursesLimit) - item.Value.Number;
                if (neededResourses < 0)
                {
                    neededResourses = 0;
                }
                NeededResourses.Add(neededResourses); 
            }
        }
    }
}
