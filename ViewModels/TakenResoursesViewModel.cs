using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;

namespace Caliber.ViewModels
{
    internal class TakenResoursesViewModel : BindableBase, ISingleton
    {
        public List<int> TakenResourses { get; set; } = Resourse.DictNumResources.Values.Select(el => el.DiffNumber).ToList();
    }
}
