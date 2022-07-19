using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;

namespace Caliber.ViewModels
{
    public class LimitResoursesViewModel : BindableBase, ISingleton
    {
        public string LimitResourses { get; set; } = 50000.ToString();

        public LimitResoursesViewModel()
        {
            foreach (var resourse in Resourse.DictNumResources)
            {
                resourse.Value.LimitNumber = Convert.ToInt32(LimitResourses);
            }
        }
    }
}
