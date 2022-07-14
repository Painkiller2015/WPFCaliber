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
        public string LimitResourses { get; set; }
    }
}
