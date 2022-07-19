using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Caliber;
using DevExpress.Mvvm;
using WPFCaliber.Value;

namespace Caliber.ViewModels
{
    public class NeededResoursesViewModel : BindableBase, ISingleton
    {
        public NeededResoursesViewModel()
        {
            UpdateCollection(true);
        }
        public ObservableCollection<int> ObsNeededResourseCollection { get; set; }
        public static event EventHandler<ObservableCollection<int>> NeededResoursesEvent;
        public void UpdateCollection(bool init = false)
        {
            ObsNeededResourseCollection = new();
            foreach (var resourse in Resourse.DictNumResources)
            {
                int need = resourse.Value.LimitNumber - resourse.Value.Number;
                need = need < 0 ? 0 : need;

                ObsNeededResourseCollection.Add(need);
            }
            if (!init)
                NeededResoursesEvent.Invoke(this, ObsNeededResourseCollection);
        }
    }
}
