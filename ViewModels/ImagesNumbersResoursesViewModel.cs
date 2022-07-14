using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliber.ViewModels
{
    public class ImagesNumbersResoursesViewModel : BindableBase, ISingleton
    {
        static ImagesNumbersResoursesViewModel()
        {
            ObsNumbersResoursesCollection = new(Resourse.DictNumResources.Values.ToList());
        }
        public static ObservableCollection<Resourse> ObsNumbersResoursesCollection { get; private set; }
    }
}
