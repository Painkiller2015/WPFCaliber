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
    public class ResoursesValuesViewModel : BindableBase, ISingleton
    {
        public Dictionary<ResoursesCollectionEng, Resourse> Resourse  { get => Caliber.Resourse.DictNumResources; }
    }
}
