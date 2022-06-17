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
            ModeViewModel.ModeChanged += (object o, PriorityMode mode) =>
            {
                       //TODO закидывать сюда необходимые реусурсы из отдельного класса

                       /*NeededResourses.Add( 
                           mode switch
                       {
                           PriorityMode.Median => Convert.ToInt32(VMLoader.Resolve<ResoursesLimitViewModel>().ResoursesLimit - ),  
                       });*/
            };

        }
    }
}
