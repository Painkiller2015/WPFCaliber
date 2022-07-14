using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Caliber;
using DevExpress.Mvvm;

namespace Caliber.ViewModels
{
    public class DifferendResourseViewModel : BindableBase, ISingleton
    {
        public DifferendResourseViewModel()
        {
            UpdateCollection(true);
        }
        public ObservableCollection<int> ObsDifferendResourseCollection { get; private set; }
        public static event EventHandler<ObservableCollection<int>> DifferendResourses;
        public void UpdateCollection(bool init = false)
        {
            ObsDifferendResourseCollection = new(Resourse.DictNumResources.Values.Select(el => el.DiffNumber).ToList());
            if (!init)
                DifferendResourses.Invoke(this, ObsDifferendResourseCollection);
        }
    }
}
